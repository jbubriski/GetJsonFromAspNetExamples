using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetJsonFromAspNet.Repositories
{
    public class Person
    {
        public string Name { get; set; }

        public string Age { get; set; }

        public Address Address { get; set; }
    }
}
