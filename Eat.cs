﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖注入测试特性
{
    public class Eat: IEat
    {
        public void EatSomething(string str)
        {
            Console.WriteLine("eat "+ str);
        }
    }
}
