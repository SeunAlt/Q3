using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = Char.ToUpper(charArray[i]);
        }

        string result = new string(charArray);
        Console.WriteLine("Uppercase string: " + result);
    }
}