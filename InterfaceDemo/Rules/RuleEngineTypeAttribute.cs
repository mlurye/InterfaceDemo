﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo.Rules
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class RuleEngineTypeAttribute : Attribute
    {
        public Type RuleType { get; set; }

        public RuleEngineTypeAttribute() : base()
        {

        }

        //public RuleEngineTypeAttribute(string) : base()
        //{

        //}
    }
}
