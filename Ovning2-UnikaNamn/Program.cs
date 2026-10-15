List<string> namn = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ange namn {i}: ");
    string nyttNamn = Console.ReadLine() ?? "";

    namn.Add(nyttNamn);
}

List<string> unikaNamn = namn.Distinct().ToList();

Console.WriteLine("\nUnika namn:");

foreach (string namnItem in unikaNamn)
{
    Console.WriteLine(namnItem);
}
