using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Dynamic;
using System.Collections;
using GetJsonFromAspNet.Repositories;

namespace GetJsonFromAspNet
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    public class PeopleService : WebService
    {
        [WebMethod]
        public object GetPeople()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return people;
        }

        [WebMethod]
        public object GetPeopleDictionary()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeopleDictionary();

            return people;
        }
    }
}
