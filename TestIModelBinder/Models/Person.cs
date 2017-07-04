using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIModelBinder.Models
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
    }

    public class PersonCompact
    {
        public string name_surname { get; set; }
        public int age { get; set; }
    }
}