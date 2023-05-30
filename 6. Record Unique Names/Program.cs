int count = int.Parse(Console.ReadLine());

HashSet<string> list = new HashSet<string>();

for (int i = 0; i < count; i++)
{
    list.Add(Console.ReadLine());
}
foreach (string s in list)
{
    Console.WriteLine(s);
}