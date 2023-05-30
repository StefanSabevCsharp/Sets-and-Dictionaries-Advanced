int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

List<int> result = new List<int>(numbers);
var sorted = result.OrderByDescending(x => x).Take(3).ToList();
Console.WriteLine(string.Join(" ",sorted));