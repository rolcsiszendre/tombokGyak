namespace tombokGyak
{
    internal class Program
    {
        static int[] szamok = new int[10];

        static Random rnd = new Random();

        static void Feltolt()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(5, 11);
            }
        }
        static void Kiiratas()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write($"{szamok[i]}, ");
            }
            Console.WriteLine();
        }
        static bool[] igazhamis = new bool[10];

        static void Feltolt0()
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
        static void Kiiratas0()
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
        }


        static void Main(string[] args)
        {
            Feltolt();
            Kiiratas();
            Feltolt0();
            Kiiratas0();
            
        }
    }
}
