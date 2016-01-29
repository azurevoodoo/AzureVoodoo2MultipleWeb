using Nancy;

namespace BackOffice
{
    public class BackOfficeModule : NancyModule
    {
        public BackOfficeModule()
        {
            Get["/"] = _ => "Hello from the BackOffice!";
        }
    }
}