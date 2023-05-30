Dictionary<double,int> dict = new Dictionary<double, int>();

double[] values = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

for (int i = 0; i < values.Length; i++)
{
    if (!dict.ContainsKey(values[i]))
    {
        dict.Add(values[i], 0);
    }
    dict[values[i]]++;
}

foreach (var item in dict)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");

}