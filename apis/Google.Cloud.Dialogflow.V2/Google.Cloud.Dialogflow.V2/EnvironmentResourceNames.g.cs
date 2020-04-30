// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>Environment</c> resource.</summary>
    public sealed partial class EnvironmentName : gax::IResourceName, sys::IEquatable<EnvironmentName>
    {
        /// <summary>The possible contents of <see cref="EnvironmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/agent/environments/{environment}</c>.
            /// </summary>
            ProjectEnvironment = 1
        }

        private static gax::PathTemplate s_projectEnvironment = new gax::PathTemplate("projects/{project}/agent/environments/{environment}");

        /// <summary>Creates a <see cref="EnvironmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnvironmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnvironmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnvironmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnvironmentName"/> with the pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnvironmentName"/> constructed from the provided ids.</returns>
        public static EnvironmentName FromProjectEnvironment(string projectId, string environmentId) =>
            new EnvironmentName(ResourceNameType.ProjectEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>.
        /// </returns>
        public static string Format(string projectId, string environmentId) =>
            FormatProjectEnvironment(projectId, environmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>.
        /// </returns>
        public static string FormatProjectEnvironment(string projectId, string environmentId) =>
            s_projectEnvironment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnvironmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/environments/{environment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName) => Parse(environmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/environments/{environment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName, bool allowUnparsed) =>
            TryParse(environmentName, allowUnparsed, out EnvironmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/environments/{environment}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, out EnvironmentName result) =>
            TryParse(environmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/agent/environments/{environment}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, bool allowUnparsed, out EnvironmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(environmentName, nameof(environmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectEnvironment.TryParseName(environmentName, out resourceName))
            {
                result = FromProjectEnvironment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(environmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnvironmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string environmentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EnvironmentId = environmentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnvironmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/agent/environments/{environment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnvironmentName(string projectId, string environmentId) : this(ResourceNameType.ProjectEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectEnvironment: return s_projectEnvironment.Expand(ProjectId, EnvironmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnvironmentName);

        /// <inheritdoc/>
        public bool Equals(EnvironmentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(EnvironmentName a, EnvironmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(EnvironmentName a, EnvironmentName b) => !(a == b);
    }

    public partial class Environment
    {
        /// <summary>
        /// <see cref="gcdv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEnvironmentsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}