using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_01_Creating_a_Class
{
    internal class Person
    {
        //Class members
        public string name, gender;
        public int age;

        //Methods for display
        public void Greet()
        {
            Console.WriteLine(" Hi Everyone, My name is " + name + ", "+ +age+ " years old " +  "and my gender is " + gender);

            Console.ReadKey();
        }
    }
}
