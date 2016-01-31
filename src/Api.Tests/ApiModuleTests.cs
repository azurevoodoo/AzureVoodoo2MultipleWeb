using Nancy;
using Nancy.Testing;
using Xunit;

namespace Api.Tests
{
    public sealed class ApiModuleTests
    {
        public sealed class TheDefaultRoute
        {
            [Fact]
            public void Should_return_status_ok_when_route_exists()
            {
                // Given
                var browser = new Browser(with=>with.Module<ApiModule>());

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
                var browser = new Browser(with => with.Module<ApiModule>());

                // When
                var result = browser.Get("/", with => {
                    with.HttpRequest();
                });

                // Then
                Assert.Equal("{\"message\":\"Hello from the API!\"}", result.Body.AsString());
            }
        }
    }
}
