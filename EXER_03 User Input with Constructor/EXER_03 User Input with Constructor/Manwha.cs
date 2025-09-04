using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_03_User_Input_with_Constructor
{
    internal class Manwha
    {
        //Declaring the fields
        public string title;
        public string genra;
        public int yearofRelease;

        public Manwha(string aTitle, string aGenra, int year) //Parestirized Constrictor
        {
            title = aTitle;
            genra = aGenra;
            yearofRelease = year;
        }

        //Method to display the book details

        public void DisplayMawhaDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-------Here are the Manwha Details");
            Console.WriteLine("Manwha Title: " + title);
            Console.WriteLine("Manwha Genra: " + genra);
            Console.WriteLine("Year of Release: " + yearofRelease);
        }
    }
}
