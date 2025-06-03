---
title: Statsig Provider
meta_desc: Provides an overview on how to configure the Pulumi Statsig provider.
layout: package
---

## Installation

The Statsig provider is available as a package in the following Pulumi languages:

* JavaScript/TypeScript: [`@statsig/pulumi-statsig`](https://www.npmjs.com/package/@statsig/pulumi-statsig)
* Python: [`pulumi-statsig`](https://pypi.org/project/pulumi-statsig/)
* Go: [`github.com/statsig-io/pulumi-statsig/sdk/go/statsig`](https://github.com/statsig-io/pulumi-statsig)
* .NET: [`Pulumi.Statsig`](https://www.nuget.org/packages/Pulumi.Statsig)

## Overview

The Statsig provider is used to interact with resources supported by
Statsig. The provider needs to be configured with the proper credentials
before it can be used.
## Example Usage

{{< chooser language "typescript,python,go,csharp" >}}
{{% choosable language typescript %}}
```yaml
# Pulumi.yaml provider configuration file
name: configuration-example
runtime: nodejs
config:
    statsig:consoleApiKey:
        value: 'TODO: var.console_api_key'

```
```typescript
import * as pulumi from "@pulumi/pulumi";
import * as statsig from "@statsig/pulumi-statsig";

// Create a Feature Gate
const gate = new Statsig.Gate("my-gate", {});
```
{{% /choosable %}}
{{% choosable language python %}}
```yaml
# Pulumi.yaml provider configuration file
name: configuration-example
runtime: python
config:
    statsig:consoleApiKey:
        value: 'TODO: var.console_api_key'

```
```python
import pulumi
import pulumi_statsig as statsig

# Create a DNS record
gate = statsig.Gate("my-gate")
```
{{% /choosable %}}
{{% choosable language csharp %}}
```yaml
# Pulumi.yaml provider configuration file
name: configuration-example
runtime: dotnet
config:
    statsig:consoleApiKey:
        value: 'TODO: var.console_api_key'

```
```csharp
using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Statsig = Pulumi.Statsig;

return await Deployment.RunAsync(() =>
{
    // Create a Feature Gate
    var gate = new Statsig.Gate("my-gate");

});

```
{{% /choosable %}}
{{% choosable language go %}}
```yaml
# Pulumi.yaml provider configuration file
name: configuration-example
runtime: go
config:
    statsig:consoleApiKey:
        value: 'TODO: var.console_api_key'

```
```go
package main

import (
  "github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/statsig-io/pulumi-statsig/sdk/go/statsig"
)

func main() {
	pulumi.Run(func(ctx *pulumi.Context) error {
		// Create a Feature Gate
		_, err := statsig.NewGate(ctx, "my-gate", nil)
		if err != nil {
			return err
		}
		return nil
	})
}
```
{{% /choosable %}}
{{< /chooser >}}
## Configuration Reference

- `consoleApiKey` (String) The Statsig Console API key retrieved from Statsig console.
