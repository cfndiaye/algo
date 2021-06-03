using System;

namespace Cipher
{
  class Program
  {
    static void Main(string[] args)
    {
      var messageSecret = "I LOVE PYTHON";
      System.Console.WriteLine("Message a cripté: ");
      Console.WriteLine(Caeser_shift(messageSecret, 1));
      System.Console.WriteLine("Massage décripté");
      Console.WriteLine(Caeser_shift_decode(Caeser_shift(messageSecret, 1), 1));
    }

    public static string Caeser_shift_decode(string message, int amount)
    {
      char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
      var unshifted_text = "";
      foreach (var c in message.ToLower())
      {
        if (c == ' ')
        {
          unshifted_text += ' ';
        }
        else
        {
          int index = Array.IndexOf(alphabet, c);
          int shifted_index = index - amount;
          if (shifted_index < 0)
          {
            shifted_index = 25 - amount;
          }
          unshifted_text += alphabet[shifted_index];
        }
      }
      return unshifted_text;
    }
    public static string Caeser_shift(string text, int amount)
    {
      var shifted_text = "";
      char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
      foreach (char c in text.ToLower())
      {
        if (c == ' ')
        {
          shifted_text += ' ';
        }
        else
        {
          int index = Array.IndexOf(alphabet, c);//on recherche l'index du caractere
          int shifted_index = index + amount;
          if (shifted_index > 25)
          {
            shifted_index = amount;

          }
          shifted_text += alphabet[shifted_index];
        }



      }

      return shifted_text;
    }
  }
}
