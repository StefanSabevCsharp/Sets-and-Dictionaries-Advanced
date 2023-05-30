SortedDictionary<string,Dictionary<string,double>> shops = new SortedDictionary<string,Dictionary<string,double>>();

string command = Console.ReadLine();

while (command != "Revision")
{
    string[] info = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = info[0];
    string productName = info[1];
    double price = double.Parse(info[2]);

    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string,double>());
    }
    if (!shops[shopName].ContainsKey(productName))
    {
        shops[shopName].Add(productName, price);

    }

    command = Console.ReadLine();
}

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");

    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }

}