using InterfaceDemo.Model;
using InterfaceDemo.RulesEngine;
using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration register = new Registration();

            //bad practice
            //IRuleEngine<Registration> ruleEngine = new DefaultRuleEngine<Registration>();

            IRuleEngine<Registration> ruleEngine = RuleEngineFactory<Registration>.GetEngine();

            register.UserName = "";
            register.Password = "demo";
            register.Email = "";
            register.ConfirmEmail = "";

            var results = ruleEngine.Validate(register);

            foreach (var r in results)
            {
                if(r.IsBroken)
                {
                    Console.WriteLine($"{r.Name} rule is broken and the error is {r.ErrorMessage}");
                }
            }

            Console.Read();
        }
    }
}
