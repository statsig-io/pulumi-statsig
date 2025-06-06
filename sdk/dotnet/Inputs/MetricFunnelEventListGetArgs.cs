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

    public sealed class MetricFunnelEventListGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the funnel event used in the metric.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The type of funnel event, specifying how the event is tracked.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public MetricFunnelEventListGetArgs()
        {
        }
        public static new MetricFunnelEventListGetArgs Empty => new MetricFunnelEventListGetArgs();
    }
}
