using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class ReflectionInfo
    {
        public void Info()
        {
            Type type = Type.GetType("ReflectionDemo.Customer");
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name + " " + property.PropertyType.Name);
            }
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor.ToString());
            }
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name+" "+method.ReturnType.Name);
            }
        }
    }
}
