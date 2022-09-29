using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSourcecol
{
    internal class TextString
    {
        public String text(string character)
        {
            string txt = character.Substring(0, 20) + "...";
            return txt;
        }

        public void caller()
        {
            string result = text("DesarrolladorDeSoftware");
            Console.WriteLine(result);
        }
    }
}
