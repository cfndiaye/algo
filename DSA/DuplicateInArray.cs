using System;
using System.Text;
namespace DSA;


public static class RemoveDuplicatesFromArray
{
	
	public static string ConvertArrayToString(this Array array)
	{
		var result = new StringBuilder();
		result.Append("{ ");
		foreach (var item in array)
		{
			result.Append(item.ToString() + ", ");
		}

		result.Remove(result.Length - 2, 2);
		result.Append(" }");

		return result.ToString();
	}
	public static int[] RemoveDuplicates(int[] array){
	    int[] uniqueArray=new int[array.Length];
	    int size = 0;
	    
	    for(int i=0; i<array.Length; i++)
		{
	        bool isDuplicate = false;
	        
	        //check if present element is present in the array or not 
	        for(int j=0;j<size;j++)
			{
	            if(array[i] == uniqueArray[j])
				{
	                isDuplicate=true;
	                break;
	            }
	        }
	        
	        //if the current element is not duplicate add it to the unique array 
	        if(!isDuplicate)
			{
	            uniqueArray[size] = array[i];
	            size++;
	        }
	    }
	    
		//uniqueArray=Array.CopyOf(uniqueArray,size);
		Array.Copy(uniqueArray, uniqueArray, size);
		Array.Resize(ref uniqueArray, size);
		
	    return uniqueArray;
	}
	
}