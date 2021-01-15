using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_position
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The sunset sets at twelve o' clock.";
            text = AlphabetPosition(text);
        }
        public static string AlphabetPosition(string text)
        {
            char[] sym = text.ToLower().ToCharArray();
            string newtext = "";
            foreach (var s in sym)
            {
                if (s >= 'a' && s <= 'z')
                    newtext += (((int)s - 96).ToString() + ' ');
            }
            return newtext.Trim();
        }
    }
    }
}
