using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPIFoo.Controllers
{
    public class DoublerController : ApiController
    {
        // GET api/doubler/abc
        async public Task<string> Get(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53753/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("/api/upper/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpResponseException(response);
                }

                id = await response.Content.ReadAsAsync<string>();
            }
            
            return id + id;
        }
    }
}
