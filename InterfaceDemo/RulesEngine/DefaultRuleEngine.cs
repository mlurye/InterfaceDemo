using InterfaceDemo.Rules;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace InterfaceDemo.RulesEngine
{
    public class DefaultRuleEngine<T> : RuleEngineBase<T>, IRuleEngine<T>
    {
        public List<BrokenRule> Validate(T value)
        {
            var results = new List<BrokenRule>();
            var props = value.GetType().GetProperties();

            foreach (var prop in props)
            {
                var rules = Rules[prop.Name];

                foreach (var rule in rules)
                {
                    var ruleAttribute = rule as ValidationAttribute;
                    var ruleResult = ruleAttribute.Validate(prop.GetValue(value), new ValidationContext { SourceObject = value });
                    if (ruleResult.IsBroken)
                    {
                        results.Add(ruleResult);
                    }
                }
            }
            return results;
        }

        public override void BuildRuleSet()
        {
            var value = typeof(T);
            var props = value.GetProperties();

            foreach (var prop in props)
            {
                var rulesAtts = prop.GetCustomAttributes(typeof(ValidationAttribute), true);
                var rulesItems = new List<ValidationAttribute>();

                foreach (var rule in rulesAtts)
                {
                    var ruleAttribute = rule as ValidationAttribute;
                    rulesItems.Add(ruleAttribute);
                }

                Rules[prop.Name] = rulesItems;
            }
        }

    }
}
