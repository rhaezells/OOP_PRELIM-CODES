using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_04_Basics_on_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //IT 306
            //EXER_04: Basics on Encapsulation

            //Instantiate Shoes Object
            Shoe shoe1 = new Shoe();

            //Use encapsulated properties to set values
            shoe1.Brand = "KQ";
            shoe1.Size = 42;

            //Call the method
            shoe1.DisplayDetails();

            Console.ReadLine();
        }
    }
}
