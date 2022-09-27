using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Custom_Attribute
{
    public class CustomValidation
    {
        public sealed class CheckAge : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null || Convert.ToInt32(value) < 18)
                {
                    return new ValidationResult("Age must be greater than 18");
                }
                else
                    return ValidationResult.Success;
            }
        }

        public sealed class CheckCountry : ValidationAttribute
        {
            public string AllowCountry { get; set; }
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                string[] myArr = AllowCountry.Split(',');
                if (!myArr.Contains(value))
                {
                    return new ValidationResult("Country not found..");
                }
                else
                    return ValidationResult.Success;
            }
        }
    }
}