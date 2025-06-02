package shim

import (
	"github.com/hashicorp/terraform-plugin-framework/provider"
	statsig "github.com/statsig-io/terraform-provider-statsig/internal"
)

func New() provider.Provider {
	return statsig.New()
}
