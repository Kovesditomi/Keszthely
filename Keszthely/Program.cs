namespace Keszthely
{
    internal class Program
    {
        
        static double atlag(List<Keszthely> a)
        { 
        var f1=a.Average(x=>x.SzuletesiEv = 2014 - x.SzuletesiEv);
            return f1;
        }
        static void Main(string[] args)
        {
            var keszthely = new List<Keszthely>();
            using(var sr=new StreamReader(@"..\..\..\src\Eredmenyek.txt"))
            {
                while(!sr.EndOfStream) 
                {
                    keszthely.Add(new Keszthely(sr.ReadLine()));
                }
                foreach (var item in keszthely)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("2.feladat");

                Console.WriteLine($"A versenyt {keszthely.Count} versenyző fejezte be.");

                Console.WriteLine("3.feladat");
                int elit = 0;
                for (int i = 0; i < keszthely.Count; i++) 
                {
                    if (keszthely[i].Eletkor.Contains("elit junior"))
                    { 
                    elit++;
                    }
                }
                Console.WriteLine($"Versenyzők száma az elit junior kategóriában: {elit} fő");

                Console.WriteLine("4.feladat");

                Console.WriteLine($"Atlag életkor: {atlag(keszthely):0.0}év");

                Console.WriteLine("5.feladat");

                Console.WriteLine("Adj meg egy kategóriát: ");
                string kategoria = (Console.ReadLine());
                var otos = keszthely.Where(x => x.Eletkor == kategoria).Select(x => x.Rajtszam);
                if (otos.Any())
                {
                    Console.WriteLine($"Rajtszamok:");
                    Console.WriteLine(string.Join(" ", otos));
                }
                else
                {
                    Console.WriteLine("Nincs ilyen kategória");
                }


                Console.WriteLine("6.feladat");
                Console.WriteLine($"A legjobb idő {keszthely.Where(x=> x.Neme=="n").OrderBy(x=>x.Osszesido).First()}");
              
            }
        }
    }
}
