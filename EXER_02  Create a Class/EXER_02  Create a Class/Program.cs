using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_02__Create_a_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //IT 306
            //Exercise 2: Create a Class

            Manwha manwha1 = new Manwha();
            Manwha manwha2 = new Manwha();
            Manwha manwha3 = new Manwha();

            //Initialization values for the fields
            manwha1.title = "Blue lock";
            manwha1.genra = "Sports, Drama";
            manwha1.yearofRelease = 2018;

            manwha2.title = "Solo Leveling";
            manwha2.genra = "Action, Fantasy";
            manwha2.yearofRelease =2016;

            manwha3.title = "The Beginning After The End";
            manwha1.genra = "Action, Adventure";
            manwha3.yearofRelease = 2013;

            //call the method
            Console.WriteLine("My anime List");
            Console.WriteLine("Title: "+ manwha1.title +  "\n" + "Genra: " + manwha1.genra + "\n" + "Year of Release: " + manwha1.yearofRelease + "\n");
            Console.WriteLine("Title: " + manwha2.title + "\n" + "Genra: " + manwha2.genra + "\n" + "Year of Release: " + manwha2.yearofRelease + "\n");
            Console.WriteLine("Title: " + manwha3.title + "\n" + "Genra: " + manwha3.genra + "\n" + "Year of Release: " + manwha3.yearofRelease + "\n");

            Console.ReadLine();
        }
    }
}
