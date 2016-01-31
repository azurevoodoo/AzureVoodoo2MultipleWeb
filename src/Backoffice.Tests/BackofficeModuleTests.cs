using Nancy;
using Nancy.Testing;
using Xunit;

namespace Backoffice.Tests
{
    public sealed class BackofficeModuleTests
    {
        public sealed class TheDefaultRoute
        {
            [Fact]
            public void Should_return_status_ok_when_route_exists()
            {
                // Given
                var browser = new Browser(with => with.Module<BackofficeModule>());

                // When
                var result = browser.Get("/", with => {
                    with.HttpRequest();
                });

                // Then
                Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            }
            [Fact]
            public void Should_return_hello_from_the_api_as_json()
            {
                // Given
                var browser = new Browser(with => with.Module<BackofficeModule>());

                // When
                var result = browser.Get("/", with => {
                    with.HttpRequest();
                });

                // Then
                Assert.Equal("Hello from the BackOffice!", result.Body.AsString());
            }
        }
    }
}
