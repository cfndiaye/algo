using System;
namespace DSA;

public static class Leader
{
    public static int[] Leaders(int[] arr, int N)
    {
        //Your code here
        //var arrayLeaders = new List<int>();

        var arrayLeaders = new int[arr.Length];


        arrayLeaders[0] = arr[arr.Length - 1];
        int size = 1;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            bool isLeader = false;

            for (int j = i + 1; j <= arr.Length - 1; j++)
            {
                if (arr[i] >= arr[j])
                {
                    isLeader = true;
                }
                else
                {
                    isLeader = false;
                    break;
                }
            }

            if (isLeader)
            {
                arrayLeaders[i + 1] = (arr[i]);
                size++;
            }
        }

        Array.Sort(arrayLeaders);
        Array.Reverse(arrayLeaders);
        Array.Resize(ref arrayLeaders, size);



        return arrayLeaders;
    }

    public static int[] LeadersVersion2(int[] arr, int N)
    {
        //Your code here
            var arrayLeaders = new int[arr.Length];
            

            var max = arr[arr.Length - 1];
            int size = 0;
            
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i]>= max)
                {
                    arrayLeaders[i] = arr[i];
                    max = arr[i];
                    size++;
                }
            }
            
            Array.Sort(arrayLeaders);
            Array.Reverse(arrayLeaders);
            Array.Resize(ref arrayLeaders, size);
           
            
            
            return arrayLeaders;
    }
}