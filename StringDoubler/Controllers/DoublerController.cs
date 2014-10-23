using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
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
                string upperCaseServiceUri = ConfigurationManager.AppSettings["UpperCaseServiceUri"];

                client.BaseAddress = new Uri(upperCaseServiceUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                if (!String.IsNullOrWhiteSpace(client.BaseAddress.UserInfo))
                {
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue(
                            "Basic",
                            Convert.ToBase64String(
                                System.Text.ASCIIEncoding.ASCII.GetBytes(
                                    client.BaseAddress.UserInfo)));
                }

                HttpResponseMessage response = await client.GetAsync("api/upper/" + id);
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpException(500, response.ToString());
                }

                id = await response.Content.ReadAsAsync<string>();
            }
            
            return id + id;
        }
    }
}
