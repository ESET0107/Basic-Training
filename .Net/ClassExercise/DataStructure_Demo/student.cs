using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Demo
{
    internal class student
    {
        int id;
        string name;
        int age;

        
        public void display()
        {
            Console.WriteLine(id +"\t" + name + "\t " + age);
        }

        public student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }
}
