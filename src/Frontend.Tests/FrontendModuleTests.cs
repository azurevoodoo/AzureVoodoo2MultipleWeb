using Nancy;
using Nancy.Testing;
using Xunit;

namespace Frontend.Tests
{
    public sealed class FrontendModuleTests
    {
        public sealed class TheDefaultRoute
        {
            [Fact]
            public void Should_return_status_ok_when_route_exists()
            {
                // Given
                var browser = new Browser(with => with.Module<FrontendModule>());

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
                var browser = new Browser(with => with.Module<FrontendModule>());

                // When
                var result = browser.Get("/", with => {
                    with.HttpRequest();
                });

                // Then
                Assert.Equal("Hello from the Frontend!", result.Body.AsString());
            }
        }
    }
}
