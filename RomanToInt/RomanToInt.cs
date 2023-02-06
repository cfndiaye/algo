public static class RomanToInt
{

//This code is a method that converts Roman numerals to their integer values. 
//It creates a dictionary of Roman numerals and their corresponding integer values, 
//then loops through the string of Roman numerals, 
//adding the corresponding integer values to a result variable. 
//If the current character has a higher value than the previous one, 
//it subtracts twice the value of the previous character from the result. 
//Finally, it returns the result.

    public static int RomainToInt(string s)
    {
        var romanUnit =  new Dictionary<char, int>();
        var result = 0;


        romanUnit.Add('I',1);
        romanUnit.Add('V',5);
        romanUnit.Add('X',10);
        romanUnit.Add('L',50);
        romanUnit.Add('C',100);
        romanUnit.Add('D',500);
        romanUnit.Add('M',1000);

        for (int i = 0; i < s.Length; i++)
        {
            if(i > 0 && romanUnit[s[i]] > romanUnit[s[i-1]] )
            {
                result += romanUnit[s[i]] - 2 * romanUnit[s[i - 1]];
            }
            else
            {
                result += romanUnit[s[i]];
            }
        }
        return result;
    }

}