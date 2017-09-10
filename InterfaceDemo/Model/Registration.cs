using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.Rules;
using InterfaceDemo.RulesEngine;

namespace InterfaceDemo.Model
{
    [RuleEngineType(RuleType = typeof(DefaultRuleEngine<Registration>))]
    public class Registration
    {
        [RequiredField("UserName","User Name cannot be empty!")]
        [MaxLenField("UserName","Max 15 chars allowed",15)]
        public string UserName { get; set; }
        public string Password { get; set; }
        [RequiredField("Email","Email is required")]
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
    }
}
