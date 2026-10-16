namespace tombokGyak
{
    internal class Program
    {
        static int[] szamok = new int[10];

        static Random rnd = new Random();

        static void F01_Feltolt()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(5, 11);
            }
        }
        static void F01_Kiiratas()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"{szamok[i]}, ");
            }
            Console.WriteLine();
        }
        static bool[] igazhamis = new bool[10];

        static void F02_Feltolt()
        {
            bool igazhamiss = false;
            int szam = 0;
            for (int i = 0; i < igazhamis.Length; i++)
            {
                
                szam = rnd.Next(0, 2);
                
                if (szam == 0)
                {
                    igazhamiss = false;
                }
                else
                {
                    igazhamiss = true;
                }
                igazhamis[i] = igazhamiss;
            }
        }
        static void F02_Kiiratas()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                if (igazhamis[i] == true)
                {
                    Console.Write("igaz, ");
                }
                else
                {
                    Console.Write("hamis, ");
                }
            }
            Console.WriteLine();
        }
        static int[] Bekertszamok = new int[5];
        
        static void F05_feltoltes()
        {
            for (int i = 0; i < Bekertszamok.Length; i++)
            {
                Console.Write("Kérek egy számot: ");
                Bekertszamok[i] = Convert.ToInt32(Console.ReadLine());
                
            }
        }

        static void F05_Kiiratas()
        {
            Console.WriteLine("Sima sorrendben:");
            for (int i = 0; i < Bekertszamok.Length; i++)
            {
                Console.Write($"{Bekertszamok[i]}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Visszafele sorrendben:");
            for (int i = Bekertszamok.Length-1; i >= 0; i--)
            {
                Console.Write($"{Bekertszamok[i]}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Minden masodik: ");
            for (int i = 0; i < Bekertszamok.Length; i+=2)
            {
                Console.Write($"{Bekertszamok[i]}, ");
            }
            Console.WriteLine();

            Console.Write("Adj egy szamot 1 es 5 kozott: ");

            int bekertszam = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Bekertszamok.Length; i++)
            {
                if (Bekertszamok[i] == bekertszam)
                {
                    Console.WriteLine($"A {bekertszam} a {i + 1}. helyen van.");
                }
            }
        }





        static void Main(string[] args)
        {
            F01_Feltolt();
            F01_Kiiratas();
            F02_Feltolt();
            F02_Kiiratas();
            F05_feltoltes();
            F05_Kiiratas();
        }
    }
}
