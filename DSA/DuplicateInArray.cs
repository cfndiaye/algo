

public class RemoveDuplicatesFromArray
{
	public static void main(String[] args) {
		int [] array={1,2,3,2,4,3,5,1};
		
		int[] uniqueArray=removeDuplicates(array);
		System.Console.WriteLine("Original array: " + Arrays.toString(array) );
		System.Console.WriteLine("New array: " + Arrays.toString(uniqueArray) );

	}
	public static int[] removeDuplicates(int[] array){
	    int[] uniqueArray=new int[array.length];
	    int size=0;
	    
	    for(int i=0;i<array.length;i++){
	        boolean isDuplicate=false;
	        
	        //check if present element is present in the array or not 
	        for(int j=0;j<size;j++){
	            if(array[i]==uniqueArray[j]){
	                isDuplicate=true;
	                break;
	            }
	        }
	        
	        //if the current element is not duplicate add it to the unique array 
	        if(!isDuplicate){
	            uniqueArray[size]=array[i];
	            size++;
	        }
	    }
	    uniqueArray=Arrays.copyOf(uniqueArray,size);
	    
	    return uniqueArray;
	}
	
}