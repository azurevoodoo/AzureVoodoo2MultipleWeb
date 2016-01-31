using Nancy;

namespace Backoffice
{
    public class BackofficeModule : NancyModule
    {
        public BackofficeModule()
        {
            Get["/"] = _ => "Hello from the BackOffice!";
        }
    }
}