
List<string> ord = new List<string>
{
    "Bil",
    "Programmering",
    "Hus",
    "Dator",
    "Sol"
};

string kortasteOrd = ord.OrderBy(o => o.Length).First();

string langstaOrd = ord.OrderByDescending(o => o.Length).First();

Console.WriteLine("Alla ord:");
Console.WriteLine(string.Join(", ", ord));

Console.WriteLine($"\nKortaste ord: {kortasteOrd}");
Console.WriteLine($"Längsta ord: {langstaOrd}");