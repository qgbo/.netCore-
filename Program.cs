using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace 依赖注入测试特性
{
   public class Program
    {
       public static ServiceProvider serviceProvider=null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            serviceProvider = new ServiceCollection()
               .AddTransient<IEat, Eat>()
               .BuildServiceProvider();


            var s = new Student();

            Type t = typeof(Student);

            foreach (var item in t.CustomAttributes)
            {
                List<Object> ar = new List<object>();
                foreach (var arg in item.ConstructorArguments)
                {
                    ar.Add(arg.Value);
                }
               var aa= Activator.CreateInstance(item.AttributeType, ar.ToArray());
                Console.WriteLine("-------");
            }
            Console.ReadLine();
        }
    }
}
