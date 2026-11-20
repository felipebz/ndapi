# Security policy

## Supported versions

Security fixes are released for the latest major version of Ndapi on [NuGet](https://www.nuget.org/packages/Ndapi).

## Reporting a vulnerability

Please don't open a public issue. Report it privately through
[GitHub's private vulnerability reporting](https://github.com/felipebz/ndapi/security/advisories/new),
with the affected version, the Oracle Forms version and steps to reproduce.

You should get a first answer within a week. Once a fix is released, the advisory is published with credit to the
reporter, unless you prefer otherwise.

## Verifying a release

Packages published from GitHub Actions carry a build provenance attestation. Download the `.nupkg` from the GitHub
release or nuget.org and check that it was built by this repository:

```bash
gh attestation verify Ndapi.<version>.nupkg --repo felipebz/ndapi
```
