namespace lista_adat_zserkezet;

internal class Program
{
    private static List<int> lista = new List<int>();
    static Random r = new Random();
    static void Feltolt(int elemekSzama)
    {
        for (int i = 0; i < elemekSzama; i++)
        {
            lista.Add(r.Next(-20,20));
            Console.WriteLine($"Az index: {i} - kapacitás: {lista.Capacity}");
        }

        for (int i = 0; i < lista.Count; i++)
        {
            Console.Write(lista[i]+ " ");
        }

        Console.WriteLine();
        Console.WriteLine($"A lista első eleme: {lista[0]}");
        Console.WriteLine($"A lista utolsó eleme: {lista[lista.Count-1]}");
        Console.WriteLine($"A legnagyobb elem: {lista.Max()}");
        Console.WriteLine($"A legkisebb elem: {lista.Min()}");
    }

    static void NegativSzamok()
    {
        int db = 0;
        Console.Write("A negatív számok: ");
        foreach (int item in lista)
        {
            if (item < 0)
            {
                db++;
                Console.Write(item + " ");
            }
        }

        Console.WriteLine($"\nA negatív számokból összesen: {db} db van");
        Console.WriteLine($"A pozitív számok száma: {lista.Count(x => x>0)} db van");
    }

    static void Atlag()
    {
        double ossz = lista.Sum();
        int db = lista.Count();
        double atlag = ossz / db;
        Console.WriteLine($"Az átlag: {Math.Round(atlag,2)}");
    }
    static void Main(string[] args)
    {
        Feltolt(20);
        NegativSzamok();
        Atlag();
    }
}