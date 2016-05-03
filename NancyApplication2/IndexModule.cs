using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApplication2
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = x => GetFile(x);
        }

        private dynamic GetFile(dynamic paramz)
        {
            var data = new byte[2048];
            return Response.AsJson(data);
        }
    }
}
