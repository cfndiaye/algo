

/*
This code prompts the user for an amount and then calculates the change in coins and bills that should be given back. 
It first reads the user's input and converts it to an integer. 
It then creates an array of coins (10, 5, and 2) and a separate array of integers to store the number of each coin. 
It then loops through the array of coins, calculating how many of each coin should be given back. 
Finally, it stores the number of each coin in a Change object and prints out a string representation of that object.
*/

Console.WriteLine("Give the Amount");

var changeInput = Console.ReadLine();
int changedValue = 0;
var result = int.TryParse(changeInput, out changedValue);


if (result)
{
    var change = new Change(changedValue);
   
    System.Console.WriteLine(change.ToString());
}