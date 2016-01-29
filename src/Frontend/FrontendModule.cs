using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Frontend
{
    public class FrontendModule : NancyModule
    {
        public FrontendModule()
        {
            Get["/"] = _ => "Hello from the Frontend!";
        }
    }
}