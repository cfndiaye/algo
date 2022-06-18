using System;
using System.Collections.Generic;
using System.Linq;

namespace CloseToZero
{
    public class CloserToZero
    {
        public List<int> ListInput { get; set; }
        public int Closer { get; set; }

        public CloserToZero(List<int> input)
        {
            ListInput = input;
        }

        public int TheMostCloserToZero()
        {
            // var list = new List<int>();
            // for (int i = 0; i < ListInput.Count; i++)
            // {
            //     if (ListInput[i] < 0)
            //     {
            //         list.Add(-1 * ListInput[i]);
            //     }
            //     else
            //     {
            //         list.Add(ListInput[i]);
            //     }
            // }

            var dico = new Dictionary<int, int>();
            for (int i = 0; i < ListInput.Count; i++)
            {
                if (ListInput[i] < 0)
                {
                    try
                    {
                        dico.Add(ListInput[i],-1 * ListInput[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        
                    }
                   
                }
                else
                {
                    try
                    {
                        dico.Add(ListInput[i],ListInput[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        //throw;
                    }
                    
                }
            }
            var result = dico.MinBy(c => c.Value);
            return result.Key;
        }
    }
}