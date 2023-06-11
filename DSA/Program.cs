using System;
using System.Text;

namespace DSA;
public static class Program 
{
    public static void Main(string[] args)  
    {
            /*
            string[] words={"apple","banana","orange","grape","mango"};
    	    string targetWord="apple";
    	    
    	    bool isWordAvailable = WordAvailability.IsWordAvailable(words,targetWord);
		
			if(isWordAvailable)
			{
			System.Console.WriteLine(targetWord + " is available in the array");
			}

			else
			{
				System.Console.WriteLine(targetWord + " is not available in the array");
			}
            

            int [] array={1,2,3,2,4,3,5,1};
		
		int[] uniqueArray = RemoveDuplicatesFromArray.RemoveDuplicates(array);
		System.Console.WriteLine($"Original array: {array.ConvertArrayToString()}");
		System.Console.WriteLine($"New array: {uniqueArray.ConvertArrayToString()}");
		
		var matrice = new int[][]
		{
			new int[]{0,0,0}, 
			new int[]{0,1,0}
		};
		var potentielCelebrity = Solution.Celebrity(matrice, 2);

		Console.WriteLine(potentielCelebrity);
		

		var arr = new int[]{16,17,4,3,5,2};

		var leaders = Leader.LeadersVersion2(arr, 6);

		Console.WriteLine(leaders.ConvertArrayToString());
		*/

		var arrange = new ArrayArrange();

		var a = new int[] {-3, 3, -2, 2, 0, -1};

		var A = arrange.Rearrange(a, a.Length);

		Console.WriteLine(A.ConvertArrayToString());

    }

	
}