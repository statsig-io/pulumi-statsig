// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
	"github.com/statsig-io/pulumi-statsig/sdk/go/statsig/internal"
)

var _ = internal.GetEnvOrDefault

// A Statsig Console API Key
func GetConsoleApiKey(ctx *pulumi.Context) string {
	return config.Get(ctx, "statsig:consoleApiKey")
}
