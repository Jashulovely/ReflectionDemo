using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Customer
    {
        public int a, b;
        public int id { get; set; }
        public string name { get; set; }
        public Customer()
        {
            id = 1;
            name = "jashu";
        }
        public Customer(string name)
        {
            this.name = name;
        }
        public void Demo()
        {

        }
        public void Demo(int id)
        {

        }
    }
}
