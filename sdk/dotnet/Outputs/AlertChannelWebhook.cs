// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Checkly.Outputs
{

    [OutputType]
    public sealed class AlertChannelWebhook
    {
        /// <summary>
        /// .
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Headers;
        /// <summary>
        /// Default is `POST`.
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// Webhook's channel name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// .
        /// </summary>
        public readonly ImmutableDictionary<string, object>? QueryParameters;
        /// <summary>
        /// .
        /// </summary>
        public readonly string? Template;
        /// <summary>
        /// .
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// .
        /// </summary>
        public readonly string? WebhookSecret;

        [OutputConstructor]
        private AlertChannelWebhook(
            ImmutableDictionary<string, object>? headers,

            string? method,

            string name,

            ImmutableDictionary<string, object>? queryParameters,

            string? template,

            string url,

            string? webhookSecret)
        {
            Headers = headers;
            Method = method;
            Name = name;
            QueryParameters = queryParameters;
            Template = template;
            Url = url;
            WebhookSecret = webhookSecret;
        }
    }
}
