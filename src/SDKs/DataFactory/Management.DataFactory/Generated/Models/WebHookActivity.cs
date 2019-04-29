// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// WebHook activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("WebHook")]
    [Rest.Serialization.JsonTransformation]
    public partial class WebHookActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the WebHookActivity class.
        /// </summary>
        public WebHookActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebHookActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="url">WebHook activity target endpoint and path. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="timeout">The timeout within which the webhook should
        /// be called back. If there is no value specified, it defaults to 10
        /// minutes. Type: string. Pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="headers">Represents the headers that will be sent to
        /// the request. For example, to set the language and type on a
        /// request: "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="body">Represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="authentication">Authentication method used for calling
        /// the endpoint.</param>
        public WebHookActivity(string name, object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), string timeout = default(string), object headers = default(object), object body = default(object), WebActivityAuthentication authentication = default(WebActivityAuthentication))
            : base(name, additionalProperties, description, dependsOn, userProperties)
        {
            Url = url;
            Timeout = timeout;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for WebHookActivity class.
        /// </summary>
        static WebHookActivity()
        {
            Method = "POST";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets webHook activity target endpoint and path. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets the timeout within which the webhook should be called
        /// back. If there is no value specified, it defaults to 10 minutes.
        /// Type: string. Pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or sets represents the headers that will be sent to the
        /// request. For example, to set the language and type on a request:
        /// "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headers")]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.body")]
        public object Body { get; set; }

        /// <summary>
        /// Gets or sets authentication method used for calling the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authentication")]
        public WebActivityAuthentication Authentication { get; set; }

        /// <summary>
        /// Rest API method for target endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public static string Method { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (Authentication != null)
            {
                Authentication.Validate();
            }
        }
    }
}
