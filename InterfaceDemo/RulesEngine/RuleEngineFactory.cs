using InterfaceDemo.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo.RulesEngine
{
    static public class RuleEngineFactory<T> where T : class
    {
        public static IRuleEngine<T> GetEngine()
        {
            //var t = typeof(T);
            //var ruleEngineTypeAttr = t.GetCustomAttributes(typeof(RuleEngineTypeAttribute),true);

            //if(ruleEngineTypeAttr != null)
            //{
            //    var ruleEngineType = Activator.CreateInstance((ruleEngineTypeAttr[0] as RuleEngineTypeAttribute).RuleType);
            //    return ruleEngineType as IRuleEngine<T>;
            //}

            return new DefaultRuleEngine<T>();
        }
    }
}
