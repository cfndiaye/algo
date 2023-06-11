
namespace DSA;

class ArrayArrange {
    
    public int[] Rearrange(int[] a, int n)
    {
        // Your code goes here
        int[] negative = new int[n];
        int[] positive = new int[n];
        
        
        int sizeArray_1 = 0;
        int sizeArray_2 = 0;
        
        Array.Sort(a);
        
        for(int i = 0; i <= n -1; i++)
        {
            if(a[i] < 0)
            {
                negative[i] = a[i];
                sizeArray_1++;
            }
            else if(a[i] >= 0)
            {
                positive[i] = a[i];
                sizeArray_2++;
            }
            
            
        }
        
        a = new int[sizeArray_1 + sizeArray_2];
        
        Array.Sort(negative);
        Array.Sort(positive);
        
        Array.Reverse(positive);
        //Array.Reverse(negative);

        Array.Resize(ref negative, sizeArray_1);
        Array.Resize(ref positive, sizeArray_2);

        Array.Copy(negative, 0, a, 0, sizeArray_1);
        Array.Copy(positive, 0, a, sizeArray_1, sizeArray_2);
        
        return a;
        
        
        
    }
}