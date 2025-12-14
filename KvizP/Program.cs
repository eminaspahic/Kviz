using System;

    namespace KvizP
{
internal class Program
    {
        static void Main()
        {
            int izbor = Menu.Odabir();
            if (izbor == 1)
            {
                Console.WriteLine("Singleplayer mode");
            }
            else
                Console.WriteLine("Multiplayer mode");
            Console.ReadKey();
        }
    }
}

