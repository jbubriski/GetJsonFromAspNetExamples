using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using GetJsonFromAspNet.Repositories;

namespace GetJsonFromAspNet
{
    public class PeopleHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            context.Response.ContentType = "application/json";
            context.Response.Write(JsonConvert.SerializeObject(people));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}