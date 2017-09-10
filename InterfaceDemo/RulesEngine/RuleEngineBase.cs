using System;
using System.Collections.Generic;
using System.Text;
using InterfaceDemo.Rules;

namespace InterfaceDemo.RulesEngine
{
    public abstract class RuleEngineBase<T>
    {
        public Dictionary<string, List<ValidationAttribute>> Rules { get; set; }
        public abstract void BuildRuleSet();

        public RuleEngineBase()
        {
            Rules = new Dictionary<string, List<ValidationAttribute>>();
            BuildRuleSet();
        }
    }
}
