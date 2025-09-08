using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_01_Creating_a_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            //Initialition of fields
            person1.name = "John";
            person1.age = 25;
            person1.gender = "Male";

            person1.Greet();
        }
    }
}
