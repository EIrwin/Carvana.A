using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Carvana.A.Gateway.Modules
{
    public class TestModule:NancyModule
    {
        public TestModule() : base("/test")
        {
            Get["/", true] = async (ctx, cancel) => Response.AsJson("Hello from A!");
        }
    }
}
