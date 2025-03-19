using System.Security.Cryptography;

bool controllo(char n, char[] p, char[] ris)
{
    bool alastro = true;
    for (int i = 0; i < p.Length; i++)
    {
        if (n == p[i])
        {
            ris[i] = n;
        }
    }
    Console.Write("\n");
    for (int j = 0; j < p.Length; j++)
    {
        Console.Write(ris[j]);
        if (ris[j] == '_')
        {
            alastro = false;
        }
    }

    Console.Write("\n\n");
    return alastro;
}
bool ngplus=true;
while (ngplus = true)
{
    Console.WriteLine("\n------INIZIO PARTITA------\n \n");
    string par = "ParoleImpiccato.txt";
    StreamReader sr = new StreamReader(par);
    string line = sr.ReadLine();

    Console.WriteLine("Dimmi la difficolta: facile (15 Vite) media (10 vite) difficile (1 vita)");
    string diff = Console.ReadLine().ToLower();
    int t = 0;
    string ng = " ";
    if (diff == "facile" || diff == "f")
    {
        t = 15;
    }
    if (diff == "media" || diff == "m")
    {
        t = 10;
    }
    if (diff == "difficile" || diff == "d")
    {
        t = 5;
    }
    Console.WriteLine("Citta, animali, oggetti?");
    string b = Console.ReadLine().ToLower();
    string p1 = " ";
    if (b == "animali" || b == "a")
    {
        Random loona = new Random();
        int ran = loona.Next(0, 101);
        Console.WriteLine("-- ANIMALI --");
        for (int i = 0; i < ran; i++)
        {
            line = sr.ReadLine();
            p1 = line;
        }
    }
    else if (b == "citta" || b == "c")
    {
        Random loona = new Random();
        int ran = loona.Next(0, 101);
        Console.WriteLine("-- CITTA --");
        for (int i = 0; i < ran + 100; i++)
        {
            line = sr.ReadLine();
            p1 = line;
        }
    }
    else if (b == "oggetti" || b == "o")
    {
        Random loona = new Random();
        int ran = loona.Next(0, 101);
        Console.WriteLine("-- OGGETTI --");
        for (int i = 0; i < ran + 200; i++)
        {
            line = sr.ReadLine();
            p1 = line;
        }
        sr.Close();
    }
    char[] p = p1.ToCharArray();
    char[] ris = new char[p.Length];
    for (int i = 0; i < p.Length; i++)
    {
        ris[i] = '_';

        ris[0] = p[0];
    }
    bool Alastor = false;
    Console.WriteLine("");
    while (Alastor == false)
    {
        Console.WriteLine("lettera: l");
        Console.WriteLine("frase:   f");
        char sceltaR = char.ToLower(Console.ReadKey().KeyChar);
        if (sceltaR == 'l')
        {
            char n = ' ';
            controllo(n, p, ris);
            Console.WriteLine("\ndimmi la lettera");
            n = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine("\n");
            if (p.Contains(n))
            {
                Console.WriteLine("\n \n!! ESATTO !!\n");
            }
            else
            {
                t--;
                Console.WriteLine($"\n\nERRORE-- vite rimaste:{t}\n");
            }
            if (controllo(n, p, ris) == true)
            {
                Alastor = true;
            }
            if (t == 0)
            {
                Alastor = true;
            }
        }
        else if (sceltaR == 'f')
        {
            Console.WriteLine("\ndimmi la frase");
            if (Console.ReadLine() == p1)
            {
                Alastor = true;
            }
            else
            {
                t--;
                Console.WriteLine($"\n\nERRORE-- vite rimaste:{t}");
            }
        }
    }
    if (t == 0)
    {
        Console.WriteLine("\n --HAI FINITO LE VITE--");
        Console.WriteLine($"la parola era: {p1}\n\n");
        Console.WriteLine($"vuoi giocare dinuovo? Si No");
        ng = Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"\n !! HAI VINTO !!");
        Console.WriteLine($"la parola era: {p1}\n\n");
        Console.WriteLine($"vuoi giocare dinuovo? Si No");
        ng = Console.ReadLine().ToLower();
    }
    if (ng == "si" || ng == "s")
    {
        ngplus = true;
    }
    if (ng == "no" || ng == "n")
    {
        ngplus = false;
    }
}