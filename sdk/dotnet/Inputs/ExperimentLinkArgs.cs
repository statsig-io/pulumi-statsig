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

    public sealed class ExperimentLinkArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The title of the link
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        /// <summary>
        /// The URL of the link
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public ExperimentLinkArgs()
        {
        }
        public static new ExperimentLinkArgs Empty => new ExperimentLinkArgs();
    }
}
