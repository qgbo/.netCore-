using System;
using System.Collections.Generic;
using System.Text;

namespace 依赖注入测试特性
{
    public class TestAttribute : Attribute
    {
        public IEat eat { get; set; }
        public TestAttribute(string food)
        {
            eat = (IEat)Program.serviceProvider.GetService(typeof(IEat));
            eat.EatSomething(food);
            Console.WriteLine("eeee");
        }
    }
}
