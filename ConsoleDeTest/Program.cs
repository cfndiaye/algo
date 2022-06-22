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
            var nc = dataEntrer.Length;
            var dim = nc * 4;
            char[,] montableau = new char[dim, 5];
            var listAscii = new List<char[,]>();
            for (int i = 0; i < nc; i++)
            {
                var ascii_ = Ascii.GetAscii(dataEntrer[i]);
                listAscii.Add(ascii_);
            }
            
            int count = 0;
            foreach (var item in listAscii)
            {
                
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        montableau[i + count, j] = item[i, j];
                    }
                }
                count += 4;
            }
           
              

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < dim; i++)
                {

                    Console.Write(montableau[i, j]);
                }
                Console.WriteLine();
            }


           
        }

        
    }
}
