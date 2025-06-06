// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Statsig.Pulumi
{
    /// <summary>
    /// This resource allows you to configure metric sources for your Statsig project.
    /// 
    /// To learn more about metric sources, see [Metric Source Documentation](https://docs.statsig.com/statsig-warehouse-native/configuration/metric-sources)
    /// 
    /// To learn more about the API powering this resource, see [Metrics API Documentation](https://docs.statsig.com/console-api/metrics)
    /// 
    /// &gt; Note: This resource is only available for [Warehouse Native](https://docs.statsig.com/statsig-warehouse-native/introduction/) projects
    /// </summary>
    [PulumiResourceType("statsig:index/metricSource:MetricSource")]
    public partial class MetricSource : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Optional array defining mappings for custom fields using specific formulas.
        /// </summary>
        [Output("customFieldMappings")]
        public Output<ImmutableArray<Outputs.MetricSourceCustomFieldMapping>> CustomFieldMappings { get; private set; } = null!;

        /// <summary>
        /// An optional description for the metric source, providing context and details about its purpose and usage.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Array defining the mapping between Statsig unit IDs and their respective source columns.
        /// </summary>
        [Output("idTypeMappings")]
        public Output<ImmutableArray<Outputs.MetricSourceIdTypeMapping>> IdTypeMappings { get; private set; } = null!;

        /// <summary>
        /// Specifies if the source can only be edited via the Console API.
        /// </summary>
        [Output("isReadOnly")]
        public Output<bool> IsReadOnly { get; private set; } = null!;

        /// <summary>
        /// The name of the metric source, serving as its primary identifier.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Schema for owner data including ID, type, name. Note that if Entity is created by CONSOLE API, owner will be undefined.
        /// </summary>
        [Output("owner")]
        public Output<Outputs.MetricSourceOwner> Owner { get; private set; } = null!;

        /// <summary>
        /// The type of source, indicating whether it is a database table or a custom query.
        /// </summary>
        [Output("sourceType")]
        public Output<string> SourceType { get; private set; } = null!;

        /// <summary>
        /// The SQL query or statement used to extract data from the metric source.
        /// </summary>
        [Output("sql")]
        public Output<string> Sql { get; private set; } = null!;

        /// <summary>
        /// The name of the database table if the source type is "table".
        /// </summary>
        [Output("tableName")]
        public Output<string> TableName { get; private set; } = null!;

        /// <summary>
        /// Optional array of tags to categorize the metric source, facilitating easier organization and retrieval.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the timestamp should be treated as a day-level granularity.
        /// </summary>
        [Output("timestampAsDay")]
        public Output<bool> TimestampAsDay { get; private set; } = null!;

        /// <summary>
        /// The name of the column containing timestamp data for the metric source.
        /// </summary>
        [Output("timestampColumn")]
        public Output<string> TimestampColumn { get; private set; } = null!;


        /// <summary>
        /// Create a MetricSource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MetricSource(string name, MetricSourceArgs args, CustomResourceOptions? options = null)
            : base("statsig:index/metricSource:MetricSource", name, args ?? new MetricSourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MetricSource(string name, Input<string> id, MetricSourceState? state = null, CustomResourceOptions? options = null)
            : base("statsig:index/metricSource:MetricSource", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MetricSource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MetricSource Get(string name, Input<string> id, MetricSourceState? state = null, CustomResourceOptions? options = null)
        {
            return new MetricSource(name, id, state, options);
        }
    }

    public sealed class MetricSourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("customFieldMappings")]
        private InputList<Inputs.MetricSourceCustomFieldMappingArgs>? _customFieldMappings;

        /// <summary>
        /// Optional array defining mappings for custom fields using specific formulas.
        /// </summary>
        public InputList<Inputs.MetricSourceCustomFieldMappingArgs> CustomFieldMappings
        {
            get => _customFieldMappings ?? (_customFieldMappings = new InputList<Inputs.MetricSourceCustomFieldMappingArgs>());
            set => _customFieldMappings = value;
        }

        /// <summary>
        /// An optional description for the metric source, providing context and details about its purpose and usage.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("idTypeMappings", required: true)]
        private InputList<Inputs.MetricSourceIdTypeMappingArgs>? _idTypeMappings;

        /// <summary>
        /// Array defining the mapping between Statsig unit IDs and their respective source columns.
        /// </summary>
        public InputList<Inputs.MetricSourceIdTypeMappingArgs> IdTypeMappings
        {
            get => _idTypeMappings ?? (_idTypeMappings = new InputList<Inputs.MetricSourceIdTypeMappingArgs>());
            set => _idTypeMappings = value;
        }

        /// <summary>
        /// Specifies if the source can only be edited via the Console API.
        /// </summary>
        [Input("isReadOnly")]
        public Input<bool>? IsReadOnly { get; set; }

        /// <summary>
        /// The name of the metric source, serving as its primary identifier.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Schema for owner data including ID, type, name. Note that if Entity is created by CONSOLE API, owner will be undefined.
        /// </summary>
        [Input("owner")]
        public Input<Inputs.MetricSourceOwnerArgs>? Owner { get; set; }

        /// <summary>
        /// The type of source, indicating whether it is a database table or a custom query.
        /// </summary>
        [Input("sourceType")]
        public Input<string>? SourceType { get; set; }

        /// <summary>
        /// The SQL query or statement used to extract data from the metric source.
        /// </summary>
        [Input("sql", required: true)]
        public Input<string> Sql { get; set; } = null!;

        /// <summary>
        /// The name of the database table if the source type is "table".
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Optional array of tags to categorize the metric source, facilitating easier organization and retrieval.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Indicates whether the timestamp should be treated as a day-level granularity.
        /// </summary>
        [Input("timestampAsDay")]
        public Input<bool>? TimestampAsDay { get; set; }

        /// <summary>
        /// The name of the column containing timestamp data for the metric source.
        /// </summary>
        [Input("timestampColumn", required: true)]
        public Input<string> TimestampColumn { get; set; } = null!;

        public MetricSourceArgs()
        {
        }
        public static new MetricSourceArgs Empty => new MetricSourceArgs();
    }

    public sealed class MetricSourceState : global::Pulumi.ResourceArgs
    {
        [Input("customFieldMappings")]
        private InputList<Inputs.MetricSourceCustomFieldMappingGetArgs>? _customFieldMappings;

        /// <summary>
        /// Optional array defining mappings for custom fields using specific formulas.
        /// </summary>
        public InputList<Inputs.MetricSourceCustomFieldMappingGetArgs> CustomFieldMappings
        {
            get => _customFieldMappings ?? (_customFieldMappings = new InputList<Inputs.MetricSourceCustomFieldMappingGetArgs>());
            set => _customFieldMappings = value;
        }

        /// <summary>
        /// An optional description for the metric source, providing context and details about its purpose and usage.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("idTypeMappings")]
        private InputList<Inputs.MetricSourceIdTypeMappingGetArgs>? _idTypeMappings;

        /// <summary>
        /// Array defining the mapping between Statsig unit IDs and their respective source columns.
        /// </summary>
        public InputList<Inputs.MetricSourceIdTypeMappingGetArgs> IdTypeMappings
        {
            get => _idTypeMappings ?? (_idTypeMappings = new InputList<Inputs.MetricSourceIdTypeMappingGetArgs>());
            set => _idTypeMappings = value;
        }

        /// <summary>
        /// Specifies if the source can only be edited via the Console API.
        /// </summary>
        [Input("isReadOnly")]
        public Input<bool>? IsReadOnly { get; set; }

        /// <summary>
        /// The name of the metric source, serving as its primary identifier.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Schema for owner data including ID, type, name. Note that if Entity is created by CONSOLE API, owner will be undefined.
        /// </summary>
        [Input("owner")]
        public Input<Inputs.MetricSourceOwnerGetArgs>? Owner { get; set; }

        /// <summary>
        /// The type of source, indicating whether it is a database table or a custom query.
        /// </summary>
        [Input("sourceType")]
        public Input<string>? SourceType { get; set; }

        /// <summary>
        /// The SQL query or statement used to extract data from the metric source.
        /// </summary>
        [Input("sql")]
        public Input<string>? Sql { get; set; }

        /// <summary>
        /// The name of the database table if the source type is "table".
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Optional array of tags to categorize the metric source, facilitating easier organization and retrieval.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Indicates whether the timestamp should be treated as a day-level granularity.
        /// </summary>
        [Input("timestampAsDay")]
        public Input<bool>? TimestampAsDay { get; set; }

        /// <summary>
        /// The name of the column containing timestamp data for the metric source.
        /// </summary>
        [Input("timestampColumn")]
        public Input<string>? TimestampColumn { get; set; }

        public MetricSourceState()
        {
        }
        public static new MetricSourceState Empty => new MetricSourceState();
    }
}
