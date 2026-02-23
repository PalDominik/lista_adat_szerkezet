namespace lista_adat_zserkezet;

internal class Program
{
    private static List<int> lista = new List<int>();
    private static List<string> sutik = new List<string>{"csokis muffin","epertorta","túrótorta","isler","citromtorta","francia krémes","almás muffin","csokis keksz","Rákoczi túros","csokis szelet","édes szölő", "Krémes édes"};
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

    static void UtikElehlyezese()
    {
        sutik.Add("csoki torta");
        foreach (string suti in sutik)
        {
            Console.WriteLine(suti);
        }
    }

    static void Csokissutik()
    {
        int db = 0;
        foreach (var item in sutik)
        {
            if (item.Contains("csoki"))
            {
                Console.WriteLine(item);
                db++;
            }
        }

        Console.WriteLine($"{db} darab csokis édesség van.");
    }

    static void LeghosszabbNevu()
    {
        string leghosszabb = sutik[0];
        foreach (string item in sutik)
        {
            if(leghosszabb.Length < item.Length)
            {
                leghosszabb = item;
            }
        }

        Console.WriteLine($"A leghosszabb sütemény neve. {leghosszabb}");
        Console.WriteLine($"A legnagybobb értékü: {leghosszabb.Max()}");
    }

    static List<string> KezdodikEVele()
    {
        List<string> valogatas = new List<string>();
        string keresett = "acm";
        foreach (string item in sutik)
        {
            // if (item.StartsWith("a") || item.StartsWith("c") || item.StartsWith("m"))
            // {
            //     valogatas.Add(item);
            // }
            if (keresett.Contains(item[0]))
            {
                valogatas.Add(item);
            }
        }
        return valogatas;
    }
    //Magas hangrendű sütik: teniszütő: eéiíüűöő

    static void Magashang()
    {
        string keresett = "aáoóuú";
        Console.Write("Magasak: ");
        foreach (string item in sutik)
        {
            bool magasE = true;
            foreach (char betu in item)
            {
                if (keresett.Contains(betu))
                {
                    magasE = false;
                }
            }

            if (magasE)
            {
                Console.Write(item + ", ");
            }

        }

    }

    static List<string> Forditas()
    {
        List<string> forditottja = new List<string>();
        
        foreach (string item in sutik)
        {
            string seged = "";
            for (int i = item.Length - 1; i >= 0; i--)
            {
                seged += item[i];
            }
            forditottja.Add(seged);
        }
        
        return forditottja;
    }
    static void Main(string[] args)
    {
        // Feltolt(20);
        // NegativSzamok();
        // Atlag();
        UtikElehlyezese();
        Console.WriteLine("-----------");
        Csokissutik();
        if (sutik.Contains("epertorta"))
        {
            Console.WriteLine("Van epertorta");
        }
        else
        {
            Console.WriteLine("Nincs epertorta");
        }
        LeghosszabbNevu();
        sutik.Sort();
        foreach (string item in sutik)
        {
            Console.WriteLine(item);
        }
        List<string> kezdodik = KezdodikEVele();
        Console.WriteLine("------------------");
        foreach (string item in kezdodik)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------");
        Magashang();
        Console.WriteLine("-----------");
        List<string> forditas = Forditas();
        foreach (string item in forditas)
            Console.WriteLine(item);
    }
}