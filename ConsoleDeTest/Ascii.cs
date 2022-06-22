using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeTest
{
    public class Ascii
    {
        public static char[,] GetAscii(char c)
        {
            var MonDictionnaire = new Dictionary<char, char[,]>();
            char[,] A = new char[4, 5];
            A[0, 0] = ' '; A[0, 1] = '#'; A[0, 2] = '#'; A[0, 3] = '#'; A[0, 4] = '#';
            A[1, 0] = '#'; A[1, 1] = ' '; A[1, 2] = '#'; A[1, 3] = ' '; A[1, 4] = ' ';
            A[2, 0] = ' '; A[2, 1] = '#'; A[2, 2] = '#'; A[2, 3] = '#'; A[2, 4] = '#';
            A[3, 0] = ' '; A[3, 1] = ' '; A[3, 2] = ' '; A[3, 3] = ' '; A[3, 4] = ' ';


            MonDictionnaire.Add('A', A);
            if (MonDictionnaire.ContainsKey(c))
            {
                return MonDictionnaire[c];
            }
            else
            {
                return null;
            }


        }
    }
}
