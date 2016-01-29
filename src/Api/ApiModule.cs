using Nancy;

namespace Api
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get["/"] = _ => Response.AsJson(new {Message = "Hello from the API!"});
        }
    }
}