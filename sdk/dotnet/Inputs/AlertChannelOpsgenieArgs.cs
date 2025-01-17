// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Checkly.Inputs
{

    public sealed class AlertChannelOpsgenieArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// .
        /// </summary>
        [Input("apiKey", required: true)]
        public Input<string> ApiKey { get; set; } = null!;

        /// <summary>
        /// Webhook's channel name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// .
        /// </summary>
        [Input("priority", required: true)]
        public Input<string> Priority { get; set; } = null!;

        /// <summary>
        /// .
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        public AlertChannelOpsgenieArgs()
        {
        }
    }
}
