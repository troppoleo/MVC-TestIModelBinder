using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestIModelBinder.Models
{
    public class Person
    {
        [DisplayName("Name")]
        //[Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = nameof(Resource.ErrorNameMessage))]
        [Required(ErrorMessage ="ummm")]
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