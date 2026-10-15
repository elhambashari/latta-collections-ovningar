
List<string> ord = new List<string>
{
    "Jag",
    "är",
    "en",
    "student",
    "i",
    "Sverige",
    "och",
    "lär",
    "mig",
    "C#"
};

Console.WriteLine("Alla ord:");
Console.WriteLine(string.Join(", ", ord));

// Ta bort ord som har färre än 3 tecken
ord.RemoveAll(o => o.Length < 3);

Console.WriteLine("\nEfter borttagning:");
Console.WriteLine(string.Join(", ", ord));