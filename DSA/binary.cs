

public class WordAvailability{
    	public static void main(String[] args) {
    	    String[] words={"apple","banana","orange","grape","mango"};
    	    String targetWord="Abishek";
    	    
    	    boolean isWordAvailable=IsWordAvailable(words,targetWord);
		
		if(isWordAvailable){
		   System.Console.WriteLine(targetWord + " is available in the array");
		}
		else{
		    System.Console.WriteLine(targetWord + " is not available in the array");

		}
	}
	
	public static boolean IsWordAvailable(String[] words,String targetWord)
    {
	    //sort the array in alphabetical order 
	    Arrays.sort(words);

	    int left = 0;
	    int right = words.length-1;
	    while(left <= right){
	        int mid = (left + right) / 2;
	        int comparisonResult = targetWord.compareTo(words[mid]);
	        if(comparisonResult == 0)
            {
	            return true;// word found
	        }
	        else if(comparisonResult < 0)
            {
	            right = mid - 1;
	        }
	        else
            {
	            left = mid + 1;
	        }
	    }
	    
	    return false; //word not found
	    
	}
    
}