using System.Collections.Generic;
using System.Web.Http;
using GetJsonFromAspNet.Repositories;

namespace AnonymousJsonTest.Controllers
{
    public class JsonController : ApiController
    {
        public IEnumerable<Person> People()
        {
            var peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetPeople();

            return people;
        }
    }
}
