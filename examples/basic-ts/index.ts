import * as statsig from "@statsig/pulumi-statsig";

new statsig.Gate("e2e-testing", {
  description: "A test gate",
});
