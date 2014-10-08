using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFoo.Controllers
{
    public class UpperController : ApiController
    {
        // GET api/upper/5
        public string Get(string id)
        {
            return id.ToUpperInvariant();
        }
    }
}
