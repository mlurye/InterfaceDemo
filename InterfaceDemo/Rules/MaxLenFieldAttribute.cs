using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.RulesEngine;

namespace InterfaceDemo.Rules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MaxLenFieldAttribute : ValidationAttribute
    {
        public int Max { get; set; }

        public MaxLenFieldAttribute() : base()
        {

        }

        public MaxLenFieldAttribute(string name, string message, int max) : base(name, message)
        {
            this.Max = max;
        }

        public override RulesEngine.BrokenRule Validate(object value, RulesEngine.ValidationContext context)
        {
            BrokenRule rule = new BrokenRule();

            if (value != null || !string.IsNullOrWhiteSpace(value.ToString()))
            {
                if(value.ToString().Length >= Max)
                {
                    rule.IsBroken = true;
                    rule.Name = this.Name;
                    rule.ErrorMessage = this.Message;
                }
            }
            return rule;
        }
        
    }
}
