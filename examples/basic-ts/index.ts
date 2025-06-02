import * as statsig from "@pulumi/statsig";

new statsig.Gate("e2e-testing", {
  description: "A test gate",
});
