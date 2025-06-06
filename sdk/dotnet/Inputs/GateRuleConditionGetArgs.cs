// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Statsig.Pulumi.Inputs
{

    public sealed class GateRuleConditionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customId")]
        public Input<string>? CustomId { get; set; }

        [Input("field")]
        public Input<string>? Field { get; set; }

        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("targetValues")]
        private InputList<string>? _targetValues;
        public InputList<string> TargetValues
        {
            get => _targetValues ?? (_targetValues = new InputList<string>());
            set => _targetValues = value;
        }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GateRuleConditionGetArgs()
        {
        }
        public static new GateRuleConditionGetArgs Empty => new GateRuleConditionGetArgs();
    }
}
