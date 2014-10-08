using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFoo.Controllers
{
    public class DoublerController : ApiController
    {
        // GET api/doubler/abc
        public string Get(string id)
        {
            return id + id;
        }
    }
}
