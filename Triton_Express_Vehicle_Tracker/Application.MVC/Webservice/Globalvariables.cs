using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Application.MVC.Webservice
{
    public static class Globalvariables
    {

        public static HttpClient client = new HttpClient();

        static Globalvariables()
        {
            client.BaseAddress = new Uri("https://localhost:44314/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}