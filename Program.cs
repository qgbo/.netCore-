using Microsoft.Extensions.DependencyInjection;
using System;

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
                var aa= Activator.CreateInstance(item.AttributeType,new object[] { "apple"});
                Console.WriteLine("-------");
            }
            Console.ReadLine();
        }
    }
}
