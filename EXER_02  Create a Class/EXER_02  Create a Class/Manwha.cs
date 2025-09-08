using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_02__Create_a_Class
{
    internal class Manwha
    {
        public string title, genra;
        public int yearofRelease;

        public Manwha()
        {
            title = "Blue lock";
            genra = "Sports, Drama";
            yearofRelease = 2018;

            title = "Solo Leveling";
            genra = "Action, Fantasy";
            yearofRelease = 2016;

            title = "The Beginning After The End";
            genra = "Action, Adventure";
            yearofRelease = 2013;
        }
    }
}
