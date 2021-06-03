using System;
using System.Collections.Generic;

namespace ConsoleDeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un texte: ");
            var entree = Console.ReadLine();
            char[] dataEntrer = entree.ToCharArray();
            char[,] montableau = new char[8, 5];

            char[,] ascii = GetAscii(dataEntrer[0]);
            char[,] ascii2 = GetAscii(dataEntrer[1]);
           // ascii.CopyTo(montableau,0);
           // ascii2.CopyTo(montableau, 4);
           
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        
                        montableau[i, j] = ascii[i,j];
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        montableau[i+4, j] = ascii2[i, j];
                    }
                }

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 8; i++)
                {

                    Console.Write(montableau[i, j]);
                }
                Console.WriteLine();
            }


            //if (ascii != null)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        for (int i = 0; i < 4; i++)
            //        {
            //            Console.Write(ascii[i, j]);
            //        }

            //        Console.WriteLine();
            //    }
            //}
        }

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
