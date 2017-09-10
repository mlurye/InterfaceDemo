using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.RulesEngine;

namespace InterfaceDemo.Rules
{
    public abstract class ValidationAttribute : Attribute
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public ValidationAttribute()
        {

        }

        public ValidationAttribute(string Name, string Message)
        {
            this.Name = Name;
            this.Message = Message;
        }

        public abstract BrokenRule Validate(object value, ValidationContext context);
    }
}
