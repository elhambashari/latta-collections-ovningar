List<int> tal = new List<int>
{
    12, 7, 5, 20, 9, 4, 16, 3, 11, 8
};

// Hitta alla jämna tal
List<int> jamnaTal = tal.FindAll(t => t % 2 == 0);

Console.WriteLine("Alla tal:");
Console.WriteLine(string.Join(", ", tal));

Console.WriteLine("\nJämna tal:");
Console.WriteLine(string.Join(", ", jamnaTal));
