using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_03_User_Input_with_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //John Rhaezel C. Atillo
        //IT-306
        //EXER_03: User Input with Constructor

        Main:

            Console.Clear();
            //Ask the user to input values
            Console.WriteLine("This program will ask about your favorite Manwha.\n\n");
            Console.Write("Enter title of the manwha: \t\t");
            string aTitle = Console.ReadLine();

            Console.Write("Enter the genra of the manwha: \t\t");
            string aGenra = Console.ReadLine();

            Console.Write("Enter the year of release: \t\t");
            int year = int.Parse(Console.ReadLine());

            //Initialize a class object 
            Manwha manwha1 = new Manwha(aTitle, aGenra, year);

            //Call the method to display
            manwha1.DisplayMawhaDetails();

            //Input another book details
            Console.Write("\nDo you want to try again (y/n)? ");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                goto Main;
            }
            else if (ans == 'n')
            {
                return;
            }
        }
    }
}
