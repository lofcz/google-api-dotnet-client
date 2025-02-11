// Copyright 2022 Google LLC
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

namespace Google.Apis.CloudRun.v1alpha1
{
    /// <summary>The CloudRun Service.</summary>
    public class CloudRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Namespaces = new NamespacesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://run.googleapis.com/";
        #else
            "https://run.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://run.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Namespaces resource.</summary>
        public virtual NamespacesResource Namespaces { get; }
    }

    /// <summary>A base abstract class for CloudRun requests.</summary>
    public abstract class CloudRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRunBaseServiceRequest instance.</summary>
        protected CloudRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudRun parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "namespaces" collection of methods.</summary>
    public class NamespacesResource
    {
        private const string Resource = "namespaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NamespacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Jobs = new JobsResource(service);
        }

        /// <summary>Gets the Jobs resource.</summary>
        public virtual JobsResource Jobs { get; }

        /// <summary>The "jobs" collection of methods.</summary>
        public class JobsResource
        {
            private const string Resource = "jobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public JobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Create a job.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The namespace in which the job should be created. Replace {namespace_id} with the project ID
            /// or number.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CloudRun.v1alpha1.Data.Job body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Create a job.</summary>
            public class CreateRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1alpha1.Data.Job>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRun.v1alpha1.Data.Job body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace in which the job should be created. Replace {namespace_id} with the project
                /// ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudRun.v1alpha1.Data.Job Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1alpha1/{+parent}/jobs";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+$",
                    });
                }
            }

            /// <summary>Delete a job.</summary>
            /// <param name="name">
            /// Required. The name of the job to delete. For Cloud Run (fully managed), replace {namespace_id} with the
            /// project ID or number.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Delete a job.</summary>
            public class DeleteRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job to delete. For Cloud Run (fully managed), replace {namespace_id} with
                /// the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apiVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ApiVersion { get; set; }

                /// <summary>Optional. Cloud Run currently ignores this parameter.</summary>
                [Google.Apis.Util.RequestParameterAttribute("kind", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Kind { get; set; }

                /// <summary>
                /// Optional. Specifies the propagation policy of delete. Cloud Run currently ignores this setting, and
                /// deletes in the background. Please see
                /// kubernetes.io/docs/concepts/workloads/controllers/garbage-collection/ for more information.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("propagationPolicy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PropagationPolicy { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1alpha1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                    RequestParameters.Add("apiVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apiVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("kind", new Google.Apis.Discovery.Parameter
                    {
                        Name = "kind",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("propagationPolicy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "propagationPolicy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get information about a job.</summary>
            /// <param name="name">
            /// Required. The name of the job to retrieve. For Cloud Run (fully managed), replace {namespace_id} with
            /// the project ID or number.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get information about a job.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1alpha1.Data.Job>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the job to retrieve. For Cloud Run (fully managed), replace {namespace_id}
                /// with the project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1alpha1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/jobs/[^/]+$",
                    });
                }
            }

            /// <summary>List jobs.</summary>
            /// <param name="parent">
            /// Required. The namespace from which the jobs should be listed. Replace {namespace_id} with the project ID
            /// or number.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List jobs.</summary>
            public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1alpha1.Data.ListJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The namespace from which the jobs should be listed. Replace {namespace_id} with the
                /// project ID or number.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Optional. Optional encoded string to continue paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Continue { get; set; }

                /// <summary>
                /// Optional. Allows to filter resources based on a specific value for a field name. Send this in a
                /// query string format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string FieldSelector { get; set; }

                /// <summary>Optional. Not currently used by Cloud Run.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                /// <summary>
                /// Optional. Allows to filter resources based on a label. Supported operations are =, !=, exists, in,
                /// and notIn.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LabelSelector { get; set; }

                /// <summary>Optional. The maximum number of records that should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Limit { get; set; }

                /// <summary>
                /// Optional. The baseline resource version from which the list or watch operation should start. Not
                /// currently used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ResourceVersion { get; set; }

                /// <summary>
                /// Optional. Flag that indicates that the client expects to watch this resource as well. Not currently
                /// used by Cloud Run.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> Watch { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/run.googleapis.com/v1alpha1/{+parent}/jobs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+$",
                    });
                    RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                    {
                        Name = "continue",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeUninitialized",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                    {
                        Name = "labelSelector",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                    {
                        Name = "limit",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                    {
                        Name = "watch",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudRun.v1alpha1.Data
{
    /// <summary>
    /// Not supported by Cloud Run ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.
    /// The contents of the target ConfigMap's Data field will represent the key-value pairs as environment variables.
    /// </summary>
    public class ConfigMapEnvSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The ConfigMap to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the ConfigMap must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run Selects a key from a ConfigMap.</summary>
    public class ConfigMapKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key to select.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The ConfigMap to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the ConfigMap or its key must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run Adapts a ConfigMap into a volume. The contents of the target ConfigMap's Data field
    /// will be presented in a volume as files using the keys in the Data field as the file names, unless the items
    /// element is populated with specific mappings of keys to paths.
    /// </summary>
    public class ConfigMapVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Integer representation of mode bits to use on created files by default. Must be a value between
        /// 01 and 0777 (octal). If 0 or not set, it will default to 0644. Directories within the path are not affected
        /// by this setting. Notes * Internally, a umask of 0222 will be applied to any non-zero value. * This is an
        /// integer representation of the mode bits. So, the octal integer value should look exactly as the chmod
        /// numeric notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal) or 511
        /// (base-10). For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx),
        /// set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that affect the file
        /// mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// (Optional) If unspecified, each key-value pair in the Data field of the referenced Secret will be projected
        /// into the volume as a file whose name is the key and content is the value. If specified, the listed keys will
        /// be projected into the specified paths, and unlisted keys will not be present. If a key is specified that is
        /// not present in the Secret, the volume setup will error unless it is marked optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<KeyToPath> Items { get; set; }

        /// <summary>Name of the config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the Secret or its keys must be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single application container. This specifies both the container to run, the command to run in the container
    /// and the arguments to supply to it. Note that additional arguments may be supplied by the system to the container
    /// at runtime.
    /// </summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable
        /// references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the
        /// reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not.
        /// More info:
        /// https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>(Optional) List of environment variables to set in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("env")]
        public virtual System.Collections.Generic.IList<EnvVar> Env { get; set; }

        /// <summary>
        /// (Optional) List of sources to populate environment variables in the container. The keys defined within a
        /// source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting.
        /// When a key exists in multiple sources, the value associated with the last source will take precedence.
        /// Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envFrom")]
        public virtual System.Collections.Generic.IList<EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Only supports containers from Google Container Registry or Artifact Registry URL of the Container image.
        /// More info: https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual string Image { get; set; }

        /// <summary>
        /// (Optional) Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is
        /// specified, or IfNotPresent otherwise. More info:
        /// https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imagePullPolicy")]
        public virtual string ImagePullPolicy { get; set; }

        /// <summary>
        /// (Optional) Periodic probe of container liveness. Container will be restarted if the probe fails. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("livenessProbe")]
        public virtual Probe LivenessProbe { get; set; }

        /// <summary>
        /// (Optional) Name of the container specified as a DNS_LABEL. Currently unused in Cloud Run. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#dns-label-names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// (Optional) List of ports to expose from the container. Only a single port can be specified. The specified
        /// ports must be listening on all interfaces (0.0.0.0) within the container to be accessible. If omitted, a
        /// port number will be chosen and passed to the container through the PORT environment variable for the
        /// container to listen on.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ports")]
        public virtual System.Collections.Generic.IList<ContainerPort> Ports { get; set; }

        /// <summary>
        /// (Optional) Periodic probe of container service readiness. Container will be removed from service endpoints
        /// if the probe fails. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readinessProbe")]
        public virtual Probe ReadinessProbe { get; set; }

        /// <summary>
        /// (Optional) Compute Resources required by this container. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual ResourceRequirements Resources { get; set; }

        /// <summary>
        /// (Optional) Security options the pod should run with. More info:
        /// https://kubernetes.io/docs/concepts/policy/security-context/ More info:
        /// https://kubernetes.io/docs/tasks/configure-pod-container/security-context/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityContext")]
        public virtual SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// (Optional) Startup probe of application within the container. All other probes are disabled if a startup
        /// probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails.
        /// More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startupProbe")]
        public virtual Probe StartupProbe { get; set; }

        /// <summary>
        /// (Optional) Path at which the file to which the container's termination message will be written is mounted
        /// into the container's filesystem. Message written is intended to be brief final status, such as an assertion
        /// failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across
        /// all containers will be limited to 12kb. Defaults to /dev/termination-log.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePath")]
        public virtual string TerminationMessagePath { get; set; }

        /// <summary>
        /// (Optional) Indicate how the termination message should be populated. File will use the contents of
        /// terminationMessagePath to populate the container status message on both success and failure.
        /// FallbackToLogsOnError will use the last chunk of container log output if the termination message file is
        /// empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever
        /// is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationMessagePolicy")]
        public virtual string TerminationMessagePolicy { get; set; }

        /// <summary>
        /// (Optional) Volume to mount into the container's filesystem. Only supports SecretVolumeSources. Pod volumes
        /// to mount into the container's filesystem.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeMounts")]
        public virtual System.Collections.Generic.IList<VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// (Optional) Container's working directory. If not specified, the container runtime's default will be used,
        /// which might be configured in the container image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workingDir")]
        public virtual string WorkingDir { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    public class ContainerPort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Port number the container listens on. This must be a valid port number, 0 &amp;lt; x &amp;lt;
        /// 65536.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerPort")]
        public virtual System.Nullable<int> ContainerPortValue { get; set; }

        /// <summary>
        /// (Optional) If specified, used to specify which protocol to use. Allowed values are "http1" and "h2c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Protocol for port. Must be "TCP". Defaults to "TCP".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run EnvFromSource represents the source of a set of ConfigMaps</summary>
    public class EnvFromSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) The ConfigMap to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapRef")]
        public virtual ConfigMapEnvSource ConfigMapRef { get; set; }

        /// <summary>
        /// (Optional) An optional identifier to prepend to each key in the ConfigMap. Must be a C_IDENTIFIER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>(Optional) The Secret to select from</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretRef")]
        public virtual SecretEnvSource SecretRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    public class EnvVar : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the environment variable. Must be a C_IDENTIFIER.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// (Optional) Variable references $(VAR_NAME) are expanded using the previous defined environment variables in
        /// the container and any route environment variables. If a variable cannot be resolved, the reference in the
        /// input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME).
        /// Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>
        /// (Optional) Source for the environment variable's value. Only supports secret_key_ref. Source for the
        /// environment variable's value. Cannot be used if value is not empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrom")]
        public virtual EnvVarSource ValueFrom { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvVarSource represents a source for the value of an EnvVar.</summary>
    public class EnvVarSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) Not supported by Cloud Run Selects a key of a ConfigMap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configMapKeyRef")]
        public virtual ConfigMapKeySelector ConfigMapKeyRef { get; set; }

        /// <summary>(Optional) Selects a key (version) of a secret in Secret Manager.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretKeyRef")]
        public virtual SecretKeySelector SecretKeyRef { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run ExecAction describes a "run in container" action.</summary>
    public class ExecAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Command is the command line to execute inside the container, the working directory for the
        /// command is root ('/') in the container's filesystem. The command is simply exec'd, it is not run inside a
        /// shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call
        /// out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("command")]
        public virtual System.Collections.Generic.IList<string> Command { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run HTTPGetAction describes an action based on HTTP Get requests.</summary>
    public class HTTPGetAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders
        /// instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>(Optional) Custom headers to set in the request. HTTP allows repeated headers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpHeaders")]
        public virtual System.Collections.Generic.IList<HTTPHeader> HttpHeaders { get; set; }

        /// <summary>(Optional) Path to access on the HTTP server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>(Optional) Scheme to use for connecting to the host. Defaults to HTTP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheme")]
        public virtual string Scheme { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run HTTPHeader describes a custom header to be used in HTTP probes</summary>
    public class HTTPHeader : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The header field name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The header field value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of an instance attempt.</summary>
    public class InstanceAttemptResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The exit code of this attempt. This may be unset if the container was unable to exit cleanly with
        /// a code due to some other failure. See status field for possible failure details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitCode")]
        public virtual System.Nullable<int> ExitCode { get; set; }

        /// <summary>
        /// Optional. The status of this attempt. If the status code is OK, then the attempt succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual GoogleRpcStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InstanceSpec is a description of an instance.</summary>
    public class InstanceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Optional duration in seconds the instance may be active relative to StartTime before the system
        /// will actively try to mark it failed and kill associated containers. If set to zero, the system will never
        /// attempt to kill an instance based on time. Otherwise, value must be a positive integer. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDeadlineSeconds")]
        public virtual System.Nullable<long> ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Optional. List of containers belonging to the instance. We disallow a number of fields on this Container.
        /// Only a single container may be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>
        /// Optional. Restart policy for all containers within the instance. Allowed values are: - OnFailure: Instances
        /// will always be restarted on failure if the backoffLimit has not been reached. - Never: Instances are never
        /// restarted and all failures are permanent. Cannot be used if backoffLimit is set. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restartPolicy")]
        public virtual string RestartPolicy { get; set; }

        /// <summary>
        /// Optional. Email address of the IAM service account associated with the instance of a Job. The service
        /// account represents the identity of the running instance, and determines what permissions the instance has.
        /// If not provided, the instance will use the project's default service account. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountName")]
        public virtual string ServiceAccountName { get; set; }

        /// <summary>
        /// Optional. Optional duration in seconds the instance needs to terminate gracefully. Value must be
        /// non-negative integer. The value zero indicates delete immediately. The grace period is the duration in
        /// seconds after the processes running in the instance are sent a termination signal and the time when the
        /// processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for
        /// your process. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("terminationGracePeriodSeconds")]
        public virtual System.Nullable<long> TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Optional. List of volumes that can be mounted by containers belonging to the instance. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instance represents the status of an instance of a Job.</summary>
    public class InstanceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Represents time when the instance was completed. It is not guaranteed to be set in happens-before
        /// order across separate operations. It is represented in RFC3339 form and is in UTC. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual object CompletionTime { get; set; }

        /// <summary>Optional. The number of times this instance exited with code &gt; 0; +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failed")]
        public virtual System.Nullable<int> Failed { get; set; }

        /// <summary>Required. Index of the instance, unique per Job, and beginning at 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>Optional. Result of the last attempt of this instance. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAttemptResult")]
        public virtual InstanceAttemptResult LastAttemptResult { get; set; }

        /// <summary>Optional. Last exit code seen for this instance. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastExitCode")]
        public virtual System.Nullable<int> LastExitCode { get; set; }

        /// <summary>
        /// Optional. The number of times this instance was restarted. Instances are restarted according the
        /// restartPolicy configured in the Job template. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restarted")]
        public virtual System.Nullable<int> Restarted { get; set; }

        /// <summary>
        /// Optional. Represents time when the instance was created by the job controller. It is not guaranteed to be
        /// set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Optional. The number of times this instance exited with code == 0. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeeded")]
        public virtual System.Nullable<int> Succeeded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InstanceTemplateSpec describes the data an instance should have when created from a template.</summary>
    public class InstanceTemplateSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specification of the desired behavior of the instance. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual InstanceSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Job represents the configuration of a single job. A job an immutable resource that references a container image
    /// which is run to completion.
    /// </summary>
    public class Job : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. APIVersion defines the versioned schema of this representation of an object. Servers should
        /// convert recognized schemas to the latest internal value, and may reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// Optional. Kind is a string value representing the REST resource this object represents. Servers may infer
        /// this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Optional. Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Optional. Specification of the desired behavior of a job. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual JobSpec Spec { get; set; }

        /// <summary>
        /// Optional. Current status of a job. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual JobStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobCondition defines a readiness condition for a Revision.</summary>
    public class JobCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Last time the condition transitioned from one status to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTransitionTime")]
        public virtual object LastTransitionTime { get; set; }

        /// <summary>Optional. Human readable message indicating details about the current status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>Optional. One-word CamelCase reason for the condition's last transition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>Optional. How to interpret failures of this condition, one of Error, Warning, Info</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>Required. Status of the condition, one of True, False, Unknown.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Required. Type is used to communicate the status of the reconciliation process. See also:
        /// https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types
        /// include: * "Completed": True when the Job has successfully completed. * "Started": True when the Job has
        /// successfully started running. * "ResourcesAvailable": True when underlying resources have been provisioned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobSpec describes how the job execution will look like.</summary>
    public class JobSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Not supported. Specifies the duration in seconds relative to the startTime that the job may be
        /// active before the system tries to terminate it. If set to zero, the system will never attempt to terminate
        /// the job based on time. Otherwise, the value must be positive integer. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeDeadlineSeconds")]
        public virtual System.Nullable<long> ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// Optional. Specifies the number of retries per instance, before marking this job failed. If set to zero,
        /// instances will never retry on failure. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backoffLimit")]
        public virtual System.Nullable<int> BackoffLimit { get; set; }

        /// <summary>
        /// Optional. Specifies the desired number of successfully finished instances the job should be run with.
        /// Setting to 1 means that parallelism is limited to 1 and the success of that instance signals the success of
        /// the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completions")]
        public virtual System.Nullable<int> Completions { get; set; }

        /// <summary>
        /// Optional. Specifies the maximum desired number of instances the job should run at any given time. Must be
        /// &amp;lt;= completions. The actual number of instances running in steady state will be less than this number
        /// when ((.spec.completions - .status.successful) &amp;lt; .spec.parallelism), i.e. when the work left to do is
        /// less than max parallelism. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/ +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parallelism")]
        public virtual System.Nullable<int> Parallelism { get; set; }

        /// <summary>Optional. Describes the instance that will be created when executing a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("template")]
        public virtual InstanceTemplateSpec Template { get; set; }

        /// <summary>
        /// Optional. Not supported. ttlSecondsAfterFinished limits the lifetime of a Job that has finished execution
        /// (either Complete or Failed). If this field is set, ttlSecondsAfterFinished after the Job finishes, it is
        /// eligible to be automatically deleted. When the Job is being deleted, its lifecycle guarantees (e.g.
        /// finalizers) will be honored. If this field is set to zero, the Job won't be automatically deleted. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttlSecondsAfterFinished")]
        public virtual System.Nullable<int> TtlSecondsAfterFinished { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JobStatus represents the current state of a Job.</summary>
    public class JobStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of actively running instances. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("active")]
        public virtual System.Nullable<int> Active { get; set; }

        /// <summary>
        /// Optional. Represents time when the job was completed. It is not guaranteed to be set in happens-before order
        /// across separate operations. It is represented in RFC3339 form and is in UTC. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completionTime")]
        public virtual object CompletionTime { get; set; }

        /// <summary>
        /// Optional. The latest available observations of a job's current state. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/ +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<JobCondition> Conditions { get; set; }

        /// <summary>Optional. The number of instances which reached phase Failed. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failed")]
        public virtual System.Nullable<int> Failed { get; set; }

        /// <summary>
        /// Optional. ImageDigest holds the resolved digest for the image specified within
        /// .Spec.Template.Spec.Container.Image. The digest is resolved during the creation of the Job. This field holds
        /// the digest value regardless of whether a tag or digest was originally specified in the Container object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDigest")]
        public virtual string ImageDigest { get; set; }

        /// <summary>Optional. Status of completed, failed, and running instances. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<InstanceStatus> Instances { get; set; }

        /// <summary>Optional. The 'generation' of the job that was last processed by the controller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("observedGeneration")]
        public virtual System.Nullable<int> ObservedGeneration { get; set; }

        /// <summary>
        /// Optional. Represents time when the job was acknowledged by the job controller. It is not guaranteed to be
        /// set in happens-before order across separate operations. It is represented in RFC3339 form and is in UTC.
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>Optional. The number of instances which reached phase Succeeded. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("succeeded")]
        public virtual System.Nullable<int> Succeeded { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maps a string key to a path within a volume.</summary>
    public class KeyToPath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Secret Manager secret version. Can be 'latest' for the latest value or an integer for a specific
        /// version. The key to project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// (Optional) Mode bits to use on this file, must be a value between 01 and 0777 (octal). If 0 or not set, the
        /// Volume's default mode will be used. Notes * Internally, a umask of 0222 will be applied to any non-zero
        /// value. * This is an integer representation of the mode bits. So, the octal integer value should look exactly
        /// as the chmod numeric notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal)
        /// or 511 (base-10). For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755
        /// (u=rwx,g=rx,o=rx), set to 0755 (octal) or 493 (base-10). * This might be in conflict with other options that
        /// affect the file mode, like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual System.Nullable<int> Mode { get; set; }

        /// <summary>
        /// The relative path of the file to map the key to. May not be an absolute path. May not contain the path
        /// element '..'. May not start with the string '..'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ListJobsResponse is a list of Jobs resources.</summary>
    public class ListJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "run.googleapis.com/v1alpha1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of Jobs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Job> Items { get; set; }

        /// <summary>The kind of this resource, in this case "JobsList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this jobs list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>
        /// This field is equivalent to the metadata.continue field and is provided as a convenience for compatibility
        /// with https://google.aip.dev/158. The value is opaque and may be used to issue another request to the
        /// endpoint that served this list to retrieve the next set of available objects. Continuing a list may not be
        /// possible if the server configuration has changed or more than a few minutes have passed. The
        /// metadata.resourceVersion field returned when using this field will be identical to the value in the first
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A
    /// resource may have only one of {ObjectMeta, ListMeta}.
    /// </summary>
    public class ListMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// continue may be set if the user set a limit on the number of items returned, and indicates that the server
        /// has more data available. The value is opaque and may be used to issue another request to the endpoint that
        /// served this list to retrieve the next set of available objects. Continuing a list may not be possible if the
        /// server configuration has changed or more than a few minutes have passed. The resourceVersion field returned
        /// when using this continue value will be identical to the value in the first response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continue")]
        public virtual string Continue__ { get; set; }

        /// <summary>
        /// String that identifies the server's internal version of this object that can be used by clients to determine
        /// when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the
        /// server. Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>SelfLink is a URL representing this object. Populated by the system. Read-only. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run LocalObjectReference contains enough information to let you locate the referenced
    /// object inside the same namespace.
    /// </summary>
    public class LocalObjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// k8s.io.apimachinery.pkg.apis.meta.v1.ObjectMeta is metadata that all persisted resources must have, which
    /// includes all objects users must create.
    /// </summary>
    public class ObjectMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Annotations is an unstructured key value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run The name of the cluster which the object belongs to. This is used to
        /// distinguish resources with same name and namespace in different clusters. This field is not set anywhere
        /// right now and apiserver is going to ignore it if set in create or update request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// (Optional) CreationTimestamp is a timestamp representing the server time when this object was created. It is
        /// not guaranteed to be set in happens-before order across separate operations. Clients may not set this value.
        /// It is represented in RFC3339 form and is in UTC. Populated by the system. Read-only. Null for lists. More
        /// info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual object CreationTimestamp { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run Number of seconds allowed for this object to gracefully terminate
        /// before it will be removed from the system. Only set when deletionTimestamp is also set. May only be
        /// shortened. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionGracePeriodSeconds")]
        public virtual System.Nullable<int> DeletionGracePeriodSeconds { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run DeletionTimestamp is RFC 3339 date and time at which this resource
        /// will be deleted. This field is set by the server when a graceful deletion is requested by the user, and is
        /// not directly settable by a client. The resource is expected to be deleted (no longer visible from resource
        /// lists, and not reachable by name) after the time in this field, once the finalizers list is empty. As long
        /// as the finalizers list contains items, deletion is blocked. Once the deletionTimestamp is set, this value
        /// may not be unset or be set further into the future, although it may be shortened or the resource may be
        /// deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet
        /// will react by sending a graceful termination signal to the containers in the pod. After that 30 seconds, the
        /// Kubelet will send a hard termination signal (SIGKILL) to the container and after cleanup, remove the pod
        /// from the API. In the presence of network partitions, this object may still exist after this timestamp, until
        /// an administrator or automated process can determine the resource is fully terminated. If not set, graceful
        /// deletion of the object has not been requested. Populated by the system when a graceful deletion is
        /// requested. Read-only. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTimestamp")]
        public virtual object DeletionTimestamp { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run Must be empty before the object is deleted from the registry. Each
        /// entry is an identifier for the responsible component that will remove the entry from the list. If the
        /// deletionTimestamp of the object is non-nil, entries in this list can only be removed. +patchStrategy=merge
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizers")]
        public virtual System.Collections.Generic.IList<string> Finalizers { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run GenerateName is an optional prefix, used by the server, to generate a
        /// unique name ONLY IF the Name field has not been provided. If this field is used, the name returned to the
        /// client will be different than the name passed. This value will also be combined with a unique suffix. The
        /// provided value has the same validation rules as the Name field, and may be truncated by the length of the
        /// suffix required to make the value unique on the server. If this field is specified and the generated name
        /// exists, the server will NOT return a 409 - instead, it will either return 201 Created or 500 with Reason
        /// ServerTimeout indicating a unique name could not be found in the time allotted, and the client should retry
        /// (optionally after the time indicated in the Retry-After header). Applied only if Name is not specified. More
        /// info: https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency string generateName =
        /// 2;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateName")]
        public virtual string GenerateName { get; set; }

        /// <summary>
        /// (Optional) A sequence number representing a specific generation of the desired state. Populated by the
        /// system. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<int> Generation { get; set; }

        /// <summary>
        /// (Optional) Map of string keys and values that can be used to organize and categorize (scope and select)
        /// objects. May match selectors of replication controllers and routes. More info:
        /// http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name must be unique within a namespace, within a Cloud Run region. Is required when creating resources,
        /// although some resources may allow a client to request the generation of an appropriate name automatically.
        /// Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More
        /// info: http://kubernetes.io/docs/user-guide/identifiers#names +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace defines the space within each name must be unique, within a Cloud Run region. In Cloud Run the
        /// namespace must be equal to either the project ID or project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>
        /// (Optional) Not supported by Cloud Run List of objects that own this object. If ALL objects in the list have
        /// been deleted, this object will be garbage collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerReferences")]
        public virtual System.Collections.Generic.IList<OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// Optional. An opaque value that represents the internal version of this object that can be used by clients to
        /// determine when objects have changed. May be used for optimistic concurrency, change detection, and the watch
        /// operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified
        /// back to the server or omit the value to disable conflict-detection. They may only be valid for a particular
        /// resource or set of resources. Populated by the system. Read-only. Value must be treated as opaque by clients
        /// or omitted. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>
        /// (Optional) SelfLink is a URL representing this object. Populated by the system. Read-only. string selfLink =
        /// 4;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// (Optional) UID is the unique in time and space value for this object. It is typically generated by the
        /// server on successful creation of a resource and is not allowed to change on PUT operations. Populated by the
        /// system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OwnerReference contains enough information to let you identify an owning object. Currently, an owning object
    /// must be in the same namespace, so there is no namespace field.
    /// </summary>
    public class OwnerReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version of the referent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the
        /// key-value store until this reference is removed. Defaults to false. To set this field, a user needs "delete"
        /// permission of the owner, otherwise 422 (Unprocessable Entity) will be returned. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockOwnerDeletion")]
        public virtual System.Nullable<bool> BlockOwnerDeletion { get; set; }

        /// <summary>If true, this reference points to the managing controller. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controller")]
        public virtual System.Nullable<bool> Controller { get; set; }

        /// <summary>
        /// Kind of the referent. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run Probe describes a health check to be performed against a container to determine
    /// whether it is alive or ready to receive traffic.
    /// </summary>
    public class Probe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) One and only one of the following should be specified. Exec specifies the action to take. A field
        /// inlined from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exec")]
        public virtual ExecAction Exec { get; set; }

        /// <summary>
        /// (Optional) Minimum consecutive failures for the probe to be considered failed after having succeeded.
        /// Defaults to 3. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureThreshold")]
        public virtual System.Nullable<int> FailureThreshold { get; set; }

        /// <summary>
        /// (Optional) HTTPGet specifies the http request to perform. A field inlined from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpGet")]
        public virtual HTTPGetAction HttpGet { get; set; }

        /// <summary>
        /// (Optional) Number of seconds after the container has started before liveness probes are initiated. More
        /// info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialDelaySeconds")]
        public virtual System.Nullable<int> InitialDelaySeconds { get; set; }

        /// <summary>
        /// (Optional) How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("periodSeconds")]
        public virtual System.Nullable<int> PeriodSeconds { get; set; }

        /// <summary>
        /// (Optional) Minimum consecutive successes for the probe to be considered successful after having failed.
        /// Defaults to 1. Must be 1 for liveness. Minimum value is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successThreshold")]
        public virtual System.Nullable<int> SuccessThreshold { get; set; }

        /// <summary>
        /// (Optional) TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported A field inlined
        /// from the Handler message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tcpSocket")]
        public virtual TCPSocketAction TcpSocket { get; set; }

        /// <summary>
        /// (Optional) Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More
        /// info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeoutSeconds")]
        public virtual System.Nullable<int> TimeoutSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    public class ResourceRequirements : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Only memory and CPU are supported. Limits describes the maximum amount of compute resources
        /// allowed. The values of the map is string form of the 'quantity' k8s type:
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

        /// <summary>
        /// (Optional) Only memory and CPU are supported. Requests describes the minimum amount of compute resources
        /// required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified,
        /// otherwise to an implementation-defined value. The values of the map is string form of the 'quantity' k8s
        /// type:
        /// https://github.com/kubernetes/kubernetes/blob/master/staging/src/k8s.io/apimachinery/pkg/api/resource/quantity.go
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IDictionary<string, string> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run SecretEnvSource selects a Secret to populate the environment variables with. The
    /// contents of the target Secret's Data field will represent the key-value pairs as environment variables.
    /// </summary>
    public class SecretEnvSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>The Secret to select from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the Secret must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    public class SecretKeySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A Cloud Secret Manager secret version. Must be 'latest' for the latest version or an integer for a specific
        /// version. The key of the secret to select from. Must be a valid secret key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// This field should not be used directly as it is meant to be inlined directly into the message. Use the
        /// "name" field instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("localObjectReference")]
        public virtual LocalObjectReference LocalObjectReference { get; set; }

        /// <summary>
        /// The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project.
        /// If the secret is in another project, you must define an alias. An alias definition has the form:
        /// :projects//secrets/. If multiple alias definitions are needed, they must be separated by commas. The alias
        /// definitions must be set on the run.googleapis.com/secrets annotation. The name of the secret in the pod's
        /// namespace to select from.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Specify whether the Secret or its key must be defined</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The secret's value will be presented as the content of a file whose name is defined in the item path. If no
    /// items are defined, the name of the file is the secret_name. The contents of the target Secret's Data field will
    /// be presented in a volume as files using the keys in the Data field as the file names.
    /// </summary>
    public class SecretVolumeSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer representation of mode bits to use on created files by default. Must be a value between 01 and 0777
        /// (octal). If 0 or not set, it will default to 0644. Directories within the path are not affected by this
        /// setting. Notes * Internally, a umask of 0222 will be applied to any non-zero value. * This is an integer
        /// representation of the mode bits. So, the octal integer value should look exactly as the chmod numeric
        /// notation with a leading zero. Some examples: for chmod 777 (a=rwx), set to 0777 (octal) or 511 (base-10).
        /// For chmod 640 (u=rw,g=r), set to 0640 (octal) or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755
        /// (octal) or 493 (base-10). * This might be in conflict with other options that affect the file mode, like
        /// fsGroup, and the result can be other mode bits set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMode")]
        public virtual System.Nullable<int> DefaultMode { get; set; }

        /// <summary>
        /// (Optional) If unspecified, the volume will expose a file whose name is the secret_name. If specified, the
        /// key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file
        /// exposed in the volume. When items are defined, they must specify a key and a path. If unspecified, each
        /// key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose
        /// name is the key and content is the value. If specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified that is not present in the Secret, the
        /// volume setup will error unless it is marked optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<KeyToPath> Items { get; set; }

        /// <summary>(Optional) Specify whether the Secret or its keys must be defined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>
        /// The name of the secret in Cloud Secret Manager. By default, the secret is assumed to be in the same project.
        /// If the secret is in another project, you must define an alias. An alias definition has the form:
        /// :projects//secrets/. If multiple alias definitions are needed, they must be separated by commas. The alias
        /// definitions must be set on the run.googleapis.com/secrets annotation. Name of the secret in the container's
        /// namespace to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secretName")]
        public virtual string SecretName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Not supported by Cloud Run SecurityContext holds security configuration that will be applied to a container.
    /// Some fields are present in both SecurityContext and PodSecurityContext. When both are set, the values in
    /// SecurityContext take precedence.
    /// </summary>
    public class SecurityContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) The UID to run the entrypoint of the container process. Defaults to user specified in image
        /// metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and
        /// PodSecurityContext, the value specified in SecurityContext takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runAsUser")]
        public virtual System.Nullable<int> RunAsUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Not supported by Cloud Run TCPSocketAction describes an action based on opening a socket</summary>
    public class TCPSocketAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>(Optional) Optional: Host name to connect to, defaults to the pod IP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; }

        /// <summary>
        /// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be
        /// an IANA_SVC_NAME. This field is currently limited to integer types only because of proto's inability to
        /// properly support the IntOrString golang type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Volume represents a named volume in a container.</summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("configMap")]
        public virtual ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>Volume's name. In Cloud Run Fully Managed, the name 'cloudsql' is reserved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual SecretVolumeSource Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    public class VolumeMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Path within the container at which the volume should be mounted. Must not contain ':'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mountPath")]
        public virtual string MountPath { get; set; }

        /// <summary>The name of the volume. There must be a corresponding Volume with the same name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>(Optional) Only true is accepted. Defaults to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>
        /// (Optional) Path within the volume from which the container's volume should be mounted. Defaults to ""
        /// (volume's root).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subPath")]
        public virtual string SubPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
