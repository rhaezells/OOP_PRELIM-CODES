using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_05__Applying_Encapsulation_with_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //IT-306
            //EXER_05: Applying Encapsulation with User

            //Instantiate Shoes Object
            Shoe shoe1 = new Shoe();

            //Use encapsulated properties to set values
            Console.WriteLine("Put the Brand of shoes you like");
            shoe1.Brand = Console.ReadLine();

            Console.WriteLine("Put the Size of shoes you like");
            shoe1.Size = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();


            //Call the method
            shoe1.DisplayDetails();
        }
    }
}
