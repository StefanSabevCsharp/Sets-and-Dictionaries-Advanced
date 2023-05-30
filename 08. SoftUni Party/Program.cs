using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> vipGuests = new HashSet<string>();
        HashSet<string> regularGuests = new HashSet<string>();

        string input = Console.ReadLine();

        while (input != "PARTY")
        {
            if (input.Length == 8)
            {
                if (Char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "END")
        {
            if (input.Length == 8)
            {
                vipGuests.Remove(input);
                regularGuests.Remove(input);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(vipGuests.Count + regularGuests.Count);
        foreach (var vipGuest in vipGuests)
        {
            Console.WriteLine(vipGuest);
        }
        foreach (var regularGuest in regularGuests)
        {
            Console.WriteLine(regularGuest);
        }
    }
}
