HashSet<string> parking = new HashSet<string>();
string[] delimiters = { " ", ", " };

string[] command = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    
    string action = command[0];
    string namePlate = command[1];

    if (action == "IN")
    {
        parking.Add(namePlate);
    }
    else if(action == "OUT")
    {
        if (parking.Contains(namePlate))
        {
            parking.Remove(namePlate);
        }
    }


    command = Console.ReadLine().Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
}

if (parking.Any())
{
    foreach (string s in parking)
    {
        Console.WriteLine(s);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}