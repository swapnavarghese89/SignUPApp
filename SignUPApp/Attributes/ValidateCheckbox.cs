﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUPApp.Attributes
{
    public class ValidateCheckbox : ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
           context.Attributes.Add("data-val-checkbox", ErrorMessage);
           
        }

        public override bool IsValid(object value)
        {
            return (bool)value;
        }
    }
}
