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
    public sealed class CheckGroupAlertChannelSubscription
    {
        /// <summary>
        /// Determines if the checks in the group are running or not.
        /// </summary>
        public readonly bool Activated;
        public readonly int ChannelId;

        [OutputConstructor]
        private CheckGroupAlertChannelSubscription(
            bool activated,

            int channelId)
        {
            Activated = activated;
            ChannelId = channelId;
        }
    }
}
