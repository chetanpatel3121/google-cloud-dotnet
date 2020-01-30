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
using gctv = Google.Cloud.Talent.V4Beta1;
using sys = System;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Resource name for the <c>Company</c> resource.</summary>
    public sealed partial class CompanyName : gax::IResourceName, sys::IEquatable<CompanyName>
    {
        /// <summary>The possible contents of <see cref="CompanyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/companies/{company}</c>.</summary>
            ProjectCompany = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/tenants/{tenant}/companies/{company}</c>.
            /// </summary>
            ProjectTenantCompany = 2
        }

        private static gax::PathTemplate s_projectCompany = new gax::PathTemplate("projects/{project}/companies/{company}");

        private static gax::PathTemplate s_projectTenantCompany = new gax::PathTemplate("projects/{project}/tenants/{tenant}/companies/{company}");

        /// <summary>Creates a <see cref="CompanyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CompanyName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CompanyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CompanyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CompanyName"/> with the pattern <c>projects/{project}/companies/{company}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompanyName"/> constructed from the provided ids.</returns>
        public static CompanyName FromProjectCompany(string projectId, string companyId) =>
            new CompanyName(ResourceNameType.ProjectCompany, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), companyId: gax::GaxPreconditions.CheckNotNullOrEmpty(companyId, nameof(companyId)));

        /// <summary>
        /// Creates a <see cref="CompanyName"/> with the pattern
        /// <c>projects/{project}/tenants/{tenant}/companies/{company}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompanyName"/> constructed from the provided ids.</returns>
        public static CompanyName FromProjectTenantCompany(string projectId, string tenantId, string companyId) =>
            new CompanyName(ResourceNameType.ProjectTenantCompany, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), tenantId: gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), companyId: gax::GaxPreconditions.CheckNotNullOrEmpty(companyId, nameof(companyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/companies/{company}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/companies/{company}</c>.
        /// </returns>
        public static string Format(string projectId, string companyId) => FormatProjectCompany(projectId, companyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/companies/{company}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/companies/{company}</c>.
        /// </returns>
        public static string FormatProjectCompany(string projectId, string companyId) =>
            s_projectCompany.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(companyId, nameof(companyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/companies/{company}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tenantId">The <c>Tenant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompanyName"/> with pattern
        /// <c>projects/{project}/tenants/{tenant}/companies/{company}</c>.
        /// </returns>
        public static string FormatProjectTenantCompany(string projectId, string tenantId, string companyId) =>
            s_projectTenantCompany.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tenantId, nameof(tenantId)), gax::GaxPreconditions.CheckNotNullOrEmpty(companyId, nameof(companyId)));

        /// <summary>Parses the given resource name string into a new <see cref="CompanyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/companies/{company}</c></description></item>
        /// <item><description><c>projects/{project}/tenants/{tenant}/companies/{company}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="companyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CompanyName"/> if successful.</returns>
        public static CompanyName Parse(string companyName) => Parse(companyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompanyName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/companies/{company}</c></description></item>
        /// <item><description><c>projects/{project}/tenants/{tenant}/companies/{company}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="companyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CompanyName"/> if successful.</returns>
        public static CompanyName Parse(string companyName, bool allowUnparsed) =>
            TryParse(companyName, allowUnparsed, out CompanyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompanyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/companies/{company}</c></description></item>
        /// <item><description><c>projects/{project}/tenants/{tenant}/companies/{company}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="companyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompanyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string companyName, out CompanyName result) => TryParse(companyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompanyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/companies/{company}</c></description></item>
        /// <item><description><c>projects/{project}/tenants/{tenant}/companies/{company}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="companyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompanyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string companyName, bool allowUnparsed, out CompanyName result)
        {
            gax::GaxPreconditions.CheckNotNull(companyName, nameof(companyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectCompany.TryParseName(companyName, out resourceName))
            {
                result = FromProjectCompany(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectTenantCompany.TryParseName(companyName, out resourceName))
            {
                result = FromProjectTenantCompany(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(companyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CompanyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string companyId = null, string projectId = null, string tenantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CompanyId = companyId;
            ProjectId = projectId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CompanyName"/> class from the component parts of pattern
        /// <c>projects/{project}/companies/{company}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="companyId">The <c>Company</c> ID. Must not be <c>null</c> or empty.</param>
        public CompanyName(string projectId, string companyId) : this(ResourceNameType.ProjectCompany, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), companyId: gax::GaxPreconditions.CheckNotNullOrEmpty(companyId, nameof(companyId)))
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
        /// The <c>Company</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string CompanyId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tenant</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string TenantId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectCompany: return s_projectCompany.Expand(ProjectId, CompanyId);
                case ResourceNameType.ProjectTenantCompany: return s_projectTenantCompany.Expand(ProjectId, TenantId, CompanyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CompanyName);

        /// <inheritdoc/>
        public bool Equals(CompanyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CompanyName a, CompanyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CompanyName a, CompanyName b) => !(a == b);
    }

    public partial class Company
    {
        /// <summary>
        /// <see cref="gctv::CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::CompanyName CompanyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::CompanyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}