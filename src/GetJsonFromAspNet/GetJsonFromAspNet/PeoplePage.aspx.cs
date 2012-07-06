using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using GetJsonFromAspNet.Repositories;
using Newtonsoft.Json;

namespace GetJsonFromAspNet
{
    public partial class PeoplePage : Page
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var peopleRepository = new PeopleRepository();

            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(JsonConvert.SerializeObject(peopleRepository.GetPeople()));
        }

        [WebMethod]
        public static object GetViaWebMethod()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return people;
        }

        [WebMethod]
        [ScriptMethod]
        public static object GetViaScriptMethod()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return people;
        }
    }
}