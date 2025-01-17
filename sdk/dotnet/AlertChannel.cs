// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Checkly
{
    /// <summary>
    /// ## # checkly.AlertChannel
    /// 
    /// The `checkly.AlertChannel` resource allows users to manage Checkly alert channels.
    /// 
    /// Checkly's Alert Channels feature allows you to define global alerting channels for the checks in your account:
    /// 
    /// ## Example Usage
    /// 
    /// *An Email alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var emailAc = new Checkly.AlertChannel("emailAc", new Checkly.AlertChannelArgs
    ///         {
    ///             Email = new Checkly.Inputs.AlertChannelEmailArgs
    ///             {
    ///                 Address = "john@example.com",
    ///             },
    ///             SendDegraded = true,
    ///             SendFailure = false,
    ///             SendRecovery = true,
    ///             SslExpiry = true,
    ///             SslExpiryThreshold = 22,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *A SMS alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var smsAc = new Checkly.AlertChannel("smsAc", new Checkly.AlertChannelArgs
    ///         {
    ///             SendFailure = true,
    ///             SendRecovery = true,
    ///             Sms = new Checkly.Inputs.AlertChannelSmsArgs
    ///             {
    ///                 Name = "john",
    ///                 Number = "0123456789",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *A Slack alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var slackAc = new Checkly.AlertChannel("slackAc", new Checkly.AlertChannelArgs
    ///         {
    ///             Slack = new Checkly.Inputs.AlertChannelSlackArgs
    ///             {
    ///                 Channel = "#checkly-notifications",
    ///                 Url = "https://slack.com/webhook",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *An Opsgenie alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var opsgenieAc = new Checkly.AlertChannel("opsgenieAc", new Checkly.AlertChannelArgs
    ///         {
    ///             Opsgenie = new Checkly.Inputs.AlertChannelOpsgenieArgs
    ///             {
    ///                 ApiKey = "fookey",
    ///                 Name = "opsalerts",
    ///                 Priority = "foopriority",
    ///                 Region = "fooregion",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *An Pagerduty alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var pagerdutyAc = new Checkly.AlertChannel("pagerdutyAc", new Checkly.AlertChannelArgs
    ///         {
    ///             Pagerduty = new Checkly.Inputs.AlertChannelPagerdutyArgs
    ///             {
    ///                 Account = "checkly",
    ///                 ServiceKey = "key1",
    ///                 ServiceName = "pdalert",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *An Webhook alert channel*
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var webhookAc = new Checkly.AlertChannel("webhookAc", new Checkly.AlertChannelArgs
    ///         {
    ///             Webhook = new Checkly.Inputs.AlertChannelWebhookArgs
    ///             {
    ///                 Method = "get",
    ///                 Name = "foo",
    ///                 Template = "footemplate",
    ///                 Url = "http://example.com/foo",
    ///                 WebhookSecret = "foosecret",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *Connecting the alert channel to a check
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example_check = new Checkly.Check("example-check", new Checkly.CheckArgs
    ///         {
    ///             AlertChannelSubscriptions = 
    ///             {
    ///                 new Checkly.Inputs.CheckAlertChannelSubscriptionArgs
    ///                 {
    ///                     ChannelId = checkly_alert_channel.Email_ac.Id,
    ///                     Activated = true,
    ///                 },
    ///                 new Checkly.Inputs.CheckAlertChannelSubscriptionArgs
    ///                 {
    ///                     ChannelId = checkly_alert_channel.Sms_ac.Id,
    ///                     Activated = true,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// *Connecting the alert channel to a check group
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var test_group1 = new Checkly.CheckGroup("test-group1", new Checkly.CheckGroupArgs
    ///         {
    ///             AlertChannelSubscriptions = 
    ///             {
    ///                 new Checkly.Inputs.CheckGroupAlertChannelSubscriptionArgs
    ///                 {
    ///                     ChannelId = checkly_alert_channel.Email_ac.Id,
    ///                     Activated = true,
    ///                 },
    ///                 new Checkly.Inputs.CheckGroupAlertChannelSubscriptionArgs
    ///                 {
    ///                     ChannelId = checkly_alert_channel.Sms_ac.Id,
    ///                     Activated = true,
    ///                 },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [ChecklyResourceType("checkly:index/alertChannel:AlertChannel")]
    public partial class AlertChannel : Pulumi.CustomResource
    {
        /// <summary>
        /// :
        /// </summary>
        [Output("email")]
        public Output<Outputs.AlertChannelEmail?> Email { get; private set; } = null!;

        [Output("opsgenie")]
        public Output<Outputs.AlertChannelOpsgenie?> Opsgenie { get; private set; } = null!;

        [Output("pagerduty")]
        public Output<Outputs.AlertChannelPagerduty?> Pagerduty { get; private set; } = null!;

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Output("sendDegraded")]
        public Output<bool?> SendDegraded { get; private set; } = null!;

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Output("sendFailure")]
        public Output<bool?> SendFailure { get; private set; } = null!;

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Output("sendRecovery")]
        public Output<bool?> SendRecovery { get; private set; } = null!;

        [Output("slack")]
        public Output<Outputs.AlertChannelSlack?> Slack { get; private set; } = null!;

        /// <summary>
        /// :
        /// </summary>
        [Output("sms")]
        public Output<Outputs.AlertChannelSms?> Sms { get; private set; } = null!;

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Output("sslExpiry")]
        public Output<bool?> SslExpiry { get; private set; } = null!;

        /// <summary>
        /// . Possible values between 1 and 30. Default is `30`.
        /// </summary>
        [Output("sslExpiryThreshold")]
        public Output<int?> SslExpiryThreshold { get; private set; } = null!;

        [Output("webhook")]
        public Output<Outputs.AlertChannelWebhook?> Webhook { get; private set; } = null!;


        /// <summary>
        /// Create a AlertChannel resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AlertChannel(string name, AlertChannelArgs? args = null, CustomResourceOptions? options = null)
            : base("checkly:index/alertChannel:AlertChannel", name, args ?? new AlertChannelArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AlertChannel(string name, Input<string> id, AlertChannelState? state = null, CustomResourceOptions? options = null)
            : base("checkly:index/alertChannel:AlertChannel", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/checkly/pulumi-checkly/releases/${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AlertChannel resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AlertChannel Get(string name, Input<string> id, AlertChannelState? state = null, CustomResourceOptions? options = null)
        {
            return new AlertChannel(name, id, state, options);
        }
    }

    public sealed class AlertChannelArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// :
        /// </summary>
        [Input("email")]
        public Input<Inputs.AlertChannelEmailArgs>? Email { get; set; }

        [Input("opsgenie")]
        public Input<Inputs.AlertChannelOpsgenieArgs>? Opsgenie { get; set; }

        [Input("pagerduty")]
        public Input<Inputs.AlertChannelPagerdutyArgs>? Pagerduty { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendDegraded")]
        public Input<bool>? SendDegraded { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendFailure")]
        public Input<bool>? SendFailure { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendRecovery")]
        public Input<bool>? SendRecovery { get; set; }

        [Input("slack")]
        public Input<Inputs.AlertChannelSlackArgs>? Slack { get; set; }

        /// <summary>
        /// :
        /// </summary>
        [Input("sms")]
        public Input<Inputs.AlertChannelSmsArgs>? Sms { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sslExpiry")]
        public Input<bool>? SslExpiry { get; set; }

        /// <summary>
        /// . Possible values between 1 and 30. Default is `30`.
        /// </summary>
        [Input("sslExpiryThreshold")]
        public Input<int>? SslExpiryThreshold { get; set; }

        [Input("webhook")]
        public Input<Inputs.AlertChannelWebhookArgs>? Webhook { get; set; }

        public AlertChannelArgs()
        {
        }
    }

    public sealed class AlertChannelState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// :
        /// </summary>
        [Input("email")]
        public Input<Inputs.AlertChannelEmailGetArgs>? Email { get; set; }

        [Input("opsgenie")]
        public Input<Inputs.AlertChannelOpsgenieGetArgs>? Opsgenie { get; set; }

        [Input("pagerduty")]
        public Input<Inputs.AlertChannelPagerdutyGetArgs>? Pagerduty { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendDegraded")]
        public Input<bool>? SendDegraded { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendFailure")]
        public Input<bool>? SendFailure { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sendRecovery")]
        public Input<bool>? SendRecovery { get; set; }

        [Input("slack")]
        public Input<Inputs.AlertChannelSlackGetArgs>? Slack { get; set; }

        /// <summary>
        /// :
        /// </summary>
        [Input("sms")]
        public Input<Inputs.AlertChannelSmsGetArgs>? Sms { get; set; }

        /// <summary>
        /// . Possible values: `true` | `false`.
        /// </summary>
        [Input("sslExpiry")]
        public Input<bool>? SslExpiry { get; set; }

        /// <summary>
        /// . Possible values between 1 and 30. Default is `30`.
        /// </summary>
        [Input("sslExpiryThreshold")]
        public Input<int>? SslExpiryThreshold { get; set; }

        [Input("webhook")]
        public Input<Inputs.AlertChannelWebhookGetArgs>? Webhook { get; set; }

        public AlertChannelState()
        {
        }
    }
}
