public static class Factoriel
{
    
    
    public static double FactorielDe(int n)
    {
        if(n == 0) return 1;
        if(n > 170) throw new Exception("Limite atteinte");
        return n > 1 ? n * FactorielDe(n-1) : n;
    }

    
}