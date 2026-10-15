List<string> ord = new List<string>
{
    "Apple",
    "Banana",
    "Orange",
    "Kiwi"
};

List<string> omvandaOrd = VandOrd(ord);

Console.WriteLine("Original lista:");
Console.WriteLine(string.Join(", ", ord));

Console.WriteLine("\nOmvänd lista:");
Console.WriteLine(string.Join(", ", omvandaOrd));


// Metod som vänder ordningen
static List<string> VandOrd(List<string> ordLista)
{
    List<string> nyLista = new List<string>(ordLista);

    nyLista.Reverse();

    return nyLista;
}
