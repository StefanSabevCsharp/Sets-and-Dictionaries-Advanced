//Dictionary<string,Dictionary<string,string>> data = new Dictionary<string,Dictionary<string,string>>();

//int count = int.Parse(Console.ReadLine());

//for (int i = 0; i < count; i++)
//{
//    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
//    string continent = command[0];
//    string country = command[1];
//    string city = command[2];

//    if (!data.ContainsKey(continent))
//    {
//        data.Add(continent,new Dictionary<string,string>());
//    }
//    if (!data[continent].ContainsKey(country))
//    {
//        data[continent].Add(country, city);

//    }

//}
////foreach(var item in data)
////{
////    Console.WriteLine($"{item.Key}:");

////    foreach(var country in data.Values)
////    {
////        Console.WriteLine($"{country.Keys} -> {string.Join(", ",country.Values)}");
////    }
////}

//foreach (var continent in data)
//{
//    Console.WriteLine($"{continent.Key}:");

//    foreach (var country in continent.Value)
//    {
//        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
//    }
//}

Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = command[0];
    string country = command[1];
    string city = command[2];

    if (!data.ContainsKey(continent))
    {
        data.Add(continent, new Dictionary<string, string>());
    }

    if (!data[continent].ContainsKey(country))
    {
        data[continent].Add(country, city);
    }
    else
    {
        data[continent][country] += ", " + city;
    }
}

foreach (var continent in data)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"  {country.Key} -> {country.Value}");
    }
}
