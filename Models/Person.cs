using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApplication1.Custom_Attribute.CustomValidation;

namespace WebApplication1.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [CheckAge]
        public int Age { get; set; }

        [CheckCountry(AllowCountry = "IND,US,AUS")]
        public string Country { get; set; }
        public List<PersonAddress> Addresses { get; set; }
    }
}