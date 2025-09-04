using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_04_Basics_on_Encapsulation
{
    internal class Shoe
    {
        //Private Fields
        private string brand;
        private int size;

        //Public Properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        //Method To Display
        public void DisplayDetails()
        {
            Console.WriteLine("----Here are the Shoe Details----");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Size: "+ Size);
        }
        
    }
}
