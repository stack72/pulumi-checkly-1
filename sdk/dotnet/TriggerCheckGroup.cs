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
    /// ## # checkly.TriggerCheckGroup
    /// 
    /// `checkly.TriggerCheckGroup` allows users to manage Checkly trigger groups. Add a `checkly.TriggerCheckGroup` resource to your resource file.
    /// 
    /// ## Example Usage
    /// 
    /// Trigger group example
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Checkly = Pulumi.Checkly;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var test_trigger_group = new Checkly.TriggerCheckGroup("test-trigger-group", new Checkly.TriggerCheckGroupArgs
    ///         {
    ///             GroupId = 215,
    ///         });
    ///         this.Test_trigger_group_url = test_trigger_group.Url;
    ///     }
    /// 
    ///     [Output("test-trigger-group-url")]
    ///     public Output&lt;string&gt; Test_trigger_group_url { get; set; }
    /// }
    /// ```
    /// </summary>
    [ChecklyResourceType("checkly:index/triggerCheckGroup:TriggerCheckGroup")]
    public partial class TriggerCheckGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The id of the group that you want to attach the trigger to.
        /// </summary>
        [Output("groupId")]
        public Output<int> GroupId { get; private set; } = null!;

        [Output("token")]
        public Output<string> Token { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a TriggerCheckGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TriggerCheckGroup(string name, TriggerCheckGroupArgs args, CustomResourceOptions? options = null)
            : base("checkly:index/triggerCheckGroup:TriggerCheckGroup", name, args ?? new TriggerCheckGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TriggerCheckGroup(string name, Input<string> id, TriggerCheckGroupState? state = null, CustomResourceOptions? options = null)
            : base("checkly:index/triggerCheckGroup:TriggerCheckGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TriggerCheckGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TriggerCheckGroup Get(string name, Input<string> id, TriggerCheckGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new TriggerCheckGroup(name, id, state, options);
        }
    }

    public sealed class TriggerCheckGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the group that you want to attach the trigger to.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<int> GroupId { get; set; } = null!;

        [Input("token")]
        public Input<string>? Token { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public TriggerCheckGroupArgs()
        {
        }
    }

    public sealed class TriggerCheckGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The id of the group that you want to attach the trigger to.
        /// </summary>
        [Input("groupId")]
        public Input<int>? GroupId { get; set; }

        [Input("token")]
        public Input<string>? Token { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public TriggerCheckGroupState()
        {
        }
    }
}
