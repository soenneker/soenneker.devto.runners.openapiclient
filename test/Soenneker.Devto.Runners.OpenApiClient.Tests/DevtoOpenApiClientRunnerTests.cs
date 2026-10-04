using Soenneker.Tests.HostedUnit;

namespace Soenneker.Devto.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DevtoOpenApiClientRunnerTests : HostedUnitTest
{
    public DevtoOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

