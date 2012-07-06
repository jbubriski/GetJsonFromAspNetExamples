using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetJsonFromAspNet.Repositories;
using Newtonsoft.Json;
using GetJsonFromAspNet.ActionResults;

namespace GetJsonFromAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeopleViaJson()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return Json(people);
        }

        public ActionResult GetPeopleViaJsonDotNet()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return Content(JsonConvert.SerializeObject(people), "application/json");
        }

        public ActionResult GetPeopleViaJsonDotNetActionResult()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return new JsonNetResult { Data = people };
        }
    }
}
