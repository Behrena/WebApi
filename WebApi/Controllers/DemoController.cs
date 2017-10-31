using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "WelCome to web API";
        }

        public List<string> Get(int Id)
        {
            return new List<string>
            {
               "data-1",
               "Data-2"
            };
        }
    }
}
