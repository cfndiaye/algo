public static class Solution{
   public static int Celebrity(int [][]M,int n){
        int potentialCelebrity = 0;
        
        //find a potential celebrity candidate
        for(int i = 1; i < n; i++)
        {
            if(M[potentialCelebrity][i] == 1)
            {
                potentialCelebrity = i;
            }
        }
        
        //verify if the potential celebrity is a valid celebrity
        for(int i = 0; i < n; i++){
            if(i != potentialCelebrity)
            {
                if(M[i][potentialCelebrity] == 0 || M[potentialCelebrity][i] == 1){
                    return -1;
                }
            }
        }
        
        return potentialCelebrity;
        
    }
}