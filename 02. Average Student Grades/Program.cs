int count = int.Parse(Console.ReadLine());

Dictionary<string,List<decimal>> dict = new Dictionary<string,List<decimal>>();

for (int i = 0; i < count; i++)
{
    string[] current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string student = current[0];
    decimal grade = decimal.Parse(current[1]);

    if (!dict.ContainsKey(student))
    {
        dict.Add(student, new List<decimal>());
    }
    dict[student].Add(grade);
}

foreach(var item in dict)
{
    Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(g => g.ToString("f2")))} (avg: {item.Value.Average():f2})");
}