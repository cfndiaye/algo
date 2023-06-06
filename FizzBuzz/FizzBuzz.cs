using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzns;

	public class FizzBuzz
	{
    public FizzBuzz()
    {

    }

    public ListNode MiddleNode(ListNode  head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        if (fast.next != null)
        {
            slow = slow.next;
        }
        return slow;
    }


    public ListNode MiddleNode2(ListNode head)
    {
        ListNode midle = head;
        ListNode end = head;

        while (end != null && end.next != null)
        {
            midle = midle.next;
            end = end.next.next;
        }

        
        return midle;
    }

    public IList<string> FizzBuzzToList(int n)
    {

        var result = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            if (((i & 3) == 0) && ((i & 5) == 0))
            {
                result.Add("FizzBuzz");
            }
            else if ((i & 3) == 0)
            {
                result.Add("Fizz");
            }
            else if ((i & 5) == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return result;
    }

    public int NumberOfSteps(int num)
    {
        int count = 0;
        while (num != 0)
        {
           
            if ((num % 2) == 0)
            {
                num /= 2;
                count++;

            }
            else
            {
                num -= 1;
                count++;
            }
        }

        return count;
    }

    

    public bool CanConstruct(string ransomNote, string magazine)
    {
       

        var ransomNoteMap = new Dictionary<char,int>();
        var magazineMap = new Dictionary<char, int>();

        var magazineListChar = magazine.ToCharArray();
        var ransomNoteListChar = ransomNote.ToCharArray();

        for (int i = 0; i < ransomNoteListChar.Length; i++)
        {
            var value = ransomNoteListChar[i];

            if (!ransomNoteMap.TryAdd( value,1))
            {
                ransomNoteMap[ransomNoteListChar[i]] = ransomNoteMap.GetValueOrDefault(ransomNoteListChar[i]) + 1;
            }
        }

        for (int i = 0; i < magazineListChar.Length; i++)
        {
            if(!magazineMap.TryAdd(magazineListChar[i],1))
            {
                magazineMap[magazineListChar[i]] = magazineMap.GetValueOrDefault(magazineListChar[i]) + 1;
            }
        }

        foreach (var item in ransomNoteMap)
        {
            if(!(magazineMap.Contains(item)))
            {
                return false;
            }
            
        }
        

        return true;
    }

    public bool CanConstructValid(string ransomNote, string magazine)
    {
        var magazineListChar = magazine.ToCharArray();
        

        int check, s1 = ransomNote.Length, s2 = magazine.Length;

        for (int i = 0; i < s1; i++)
        {
            check = 0;
            for (int j = 0; j < s2; j++)
            {
                if (ransomNote[i] == magazineListChar[j])  // check if required char exist
                {
                    check++;         // check=1 if match is found
                    //magazineListChar[i] = '@';  // replacing matched char with @ in magazine
                    break;
                }
            }
            if (check == 0)   // if no match found exit program
            {
                return false;
            }
        }
        return true;
    }

    public bool CanConstructSolution(string ransomeNote, string magazine)
    {
        for (int i = 0; i < ransomeNote.Length; i++)
        {
            char r = ransomeNote[i];

            int matchingIndex = ransomeNote.IndexOf(r);

            if(matchingIndex == -1)
            {
                return false;
            }

            magazine = magazine.Substring(0, matchingIndex) + magazine.Substring(matchingIndex +1);
        }
        return true;

    }

    public bool CanConstructSolutionTwo(string ransomNote, string magazine)
    {
        var magazineMap = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (!magazineMap.TryAdd(magazine[i], 1))
            {
                magazineMap[magazine[i]] = magazineMap.GetValueOrDefault(magazine[i]) + 1;
            }
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            char r = ransomNote[i];
            int currenCount = magazineMap.GetValueOrDefault(r, 0);
            if (currenCount == 0) return false;
            magazineMap[r] = currenCount - 1;
        }

        return true;
    }
}



