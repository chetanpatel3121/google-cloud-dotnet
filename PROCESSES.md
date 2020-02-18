# Processes, release procedures etc

This repository includes multiple projects at multiple versions,
some of which depend on each other. That makes things tricky, and
leads to rather more complicated procedures than a simple "single
package" repository. Please read this guide carefully to understand
how releases happen, and why they happen that way.

## The API catalog

Only the source within the `apis` directory is published, although not
every project within that directory is published.
(There are test projects and tools alongside the production code.)
Nothing in the `tools` directory is published as a package.

Most project files under `apis` are at least partially generated.
The master information is in [apis.json](apis/apis.json) - the API
catalog file. There's an entry for each API, containing:

- The kind of API (grpc, rest, other)
- The version number
- A product title and home page for documentation
- Dependencies
- Additional test project dependencies
- Target framework versions
- Package description for NuGet
- Tags for NuGet (in addition to default ones)
- Proto path within the googleapis repository
- Service YAML file

The catalog is used to generate project files and also during the
release process described below. Running the project generator is
very simple: from the root directory, in a bash shell, run

```bash
./generateprojects.sh
```

The CI systems run this before building, to ensure that the project
files are in a stable state.

Generating the project files allows for broad changes (such as
adding Source Link support) to be made very simply, just by changing
the generator. Modifying every project file by hand simply doesn't
scale.

However, sometimes manual editing of project files is required. The
project generator supports this by assuming it "owns":

- The first `PropertyGroup` element (for general properties)
- The first `ItemGroup` element (for dependencies)
- The `ItemGroup` element for Source Link (with a label of "dotnet pack instructions")
- The common import to only attempt to build desktop assemblies on Windows

Any other elements are left as they are - so if you wish to add an
`ItemGroup` such as for file grouping, just add it anywhere after
the generated one, and it should do the right thing.

Additionally, for each API, the project generator adds all projects
under the API directory (and project references) to the solution for
that API. It will create project files from scratch as well - so when adding a
new package from autogenerated API sources, the simplest approach is
to copy the source files, modify the API catalog, and run the
project generator. The project files and solution file will be
generated and should immediately be usable.

## Versioning

All releasable packages follow [Semantic Versioning](http://semver.org).
Non-releasable code (tests, tools, analyzers) are not versioned. The
precise meaning of a breaking change (dictating version number
increments) is out of the scope of this document. (Jon is writing a
blog post about this topic and will link to it when it is published.)

The version number in the API catalog (and therefore in project
files) is one of:

- The mostly recently released package version
- The version that's *about* to be released (see below)
- A prerelease with a suffix of 00 to indicate that the *next* release
  should be the first prerelease for that major/minor version.

The last of these cases can happen if either an existing version has
gone to GA and new features have been merged since (to ensure that
we don't add features within a minor GA version) or for brand-new
APIs that haven't been released at all. The tooling for tagging is
aware of this convention, and doesn't create tags for `alpha00` or
`beta00` suffixes.

Typically version numbers should be changed in a commit which does
nothing else, for clarity. Include both the `apis.json` change and
the project file changes that occur when the project generator has
been run, in the same commit.

### Dependencies

Dependencies in the API catalog are specified as properties where
the property name is the package name and the value is the version
number.

If the version number is set to "project", then a project reference
is used. If project X has a production dependency on project Y, then
both X and Y *must* be released together, to avoid misaligned
versions. The tagging tool enforces this.

If the version number is set to "default", then the version number
is determined by the project generator, to keep these dependencies
in sync for all appropriate packages.

Two project types gain dependencies automatically if they're not
specified:

- "grpc" projects always have dependencies on Google.Api.Gax.Grpc
  and Grpc.Core
- "rest" projects always have a dependency on Google.Api.Gax.Rest

The best dependency version to specify depends on the version of the
project itself:

- For GA versions, every version must be explicitly specified. This
  prevents us from accidentally upgrading a dependency minor version
  when creating a patch version of the project itself.
- For alpha/beta versions, specify as little as possible: allow
  the "grpc"/"rest" dependencies above to be added automatically,
  and use the "default" version number where possible. Explicit
  versions should only be used either for dependencies without
  default versions, or when the desired version is ahead of the
  default version, for example to use a GAX prerelease.

## Releasing

Releasing consists of these steps:

- Updating the version number in GitHub (via standard pull requests)
- Creating a release tag and GitHub release
- Building and testing
- Pushing the package to nuget.org
- Updating the documentation in GitHub (in the `gh-pages` branch)

The last three of these are typically performed by a Kokoro release
job.

### Detailed steps

**Create the release PR**

1. Edit the API catalog (`apis/apis.json`). Find the package you
want to release (by ID) and edit the version key to the new release
version. Usually this will be a bump of prerelease (e.g.
1.0.0-beta03 to 1.0.0-beta04) or a minor version bump (e.g. 1.3.0 to
1.4.0). You may update any dependencies at the same time.

2. Run `generateprojects.sh` from the root directory. This should
indicate that it has updated the project file for the package you're
releasing.

3. If this is the first release of a package, or it's been updated
from beta to GA, update `README.md` and `docs/root/index.md`
accordingly.

4. Update the version history for the package (in
`apis/{package_id}/docs/history.md`). There is a script in the root
directory to help with this: run `prepare-release.sh` passing in the
package ID, which will perform version comparisons and perform an
initial edit on the file, but you'll need to edit the file manually
afterwards to make the history as useful as possible. (The tool is
very new, and we hope to reduce the manual edit requirements over
time.)

5. Commit the changes. The first line of the commit message should
be "Release {package_id} version {version}". Optionally, add release
notes as the rest of the commit message, potentially by copying from
the `history.md` file you've just edited. ([Sample
commit](https://github.com/googleapis/google-cloud-dotnet/commit/3b580a6a0e8248daec4c84f6a45d0e07c094013d))

6. Create a pull request for the commit, and get it reviewed.

Sample session when releasing Google.Cloud.Speech.V1:

```text
$ git checkout -b release-speech
$ pico apis/apis.json
$ ./generateprojects.sh
$ ./prepare-release.sh Google.Cloud.Speech.V1
$ pico apis/Google.Cloud.Speech.V1/docs/history.md
$ git commit -a
$ git push
```

**Tagging the release**

Prerequisite: the PR above has been reviewed and merged into the
master branch.

1. Checkout the master branch and pull the latest code, which should
now include the changes you've made.

2. Run `tagreleases.sh` in the root directory, specifying a github
access token. This will ask you to confirm that you want to create a
release.

Sample session:

```text
$ git checkout master
$ git pull upstream master
$ ./tagreleases.sh your_access_token_here
```

Note that `tagreleases.sh` checks that there are no project
references from APIs being released now to APIs that *aren't* being
released. Without this check, it's possible for a released version
to depend on unreleased changes.

**Building and publishing the release**

On a Google corp machine, trigger a Kokoro release build. (This
can only be performed by Googlers.)

If you want to release anything other than the current head of
`master`, specify the commitish that was tagged (either the commit
itself, or the tag that's listed on the [releases
page](https://github.com/googleapis/google-cloud-dotnet/releases).

The Kokoro build will:

- Fetch the commit
- See which tags are present for that commit (to work out which packages need releasing)
- For all those packages:
  - Build
  - Run unit tests
  - Run integration/snippet tests
  - Build documentation
  - Push packages to nuget.org
  - Push documentation to GitHub packages
  - Push documentation to googelapis.dev

If you wish to perform a manual build instead, use
the command line displayed by `tagreleases.sh` to run
`buildrelease.sh`, which then displays final instructions for
pushing to nuget.org and updating the docs.
