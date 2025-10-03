namespace _1003
{
    internal class Program
    {
        static int X = Console.WindowWidth / 2;
        static int Y = Console.WindowHeight / 2;

        static int szin = 0;
        static int back = 15;
        static bool toll = false;
        static bool radir = false;

        static void Main(string[] args)
        {
            Info();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            KurzorSzin(szin);


            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft == Console.WindowWidth - 1)
                        {
                            Console.CursorLeft = 0;
                        }
                        else
                        {
                            Console.CursorLeft++;
                        }
                        if (toll)
                        {
                            Console.Write(" ");
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft == 0)
                        {
                            Console.CursorLeft = Console.WindowWidth-1;
                        }
                        else
                        {
                            Console.CursorLeft--;
                        }
                        if (toll)
                        {
                            Console.Write(" ");
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop == 0)
                        {
                            Console.CursorTop = Console.WindowHeight - 1;
                        }
                        else
                        {
                            Console.CursorTop--;
                        }
                        if (toll)
                        {
                            Console.Write(" ");
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop == Console.WindowHeight - 1)
                        {
                            Console.CursorTop = 0;
                        }
                        else
                        {
                            Console.CursorTop++;
                        }
                        if (toll)
                        {
                            Console.Write(" ");
                            Console.CursorLeft--;
                        }
                        break;

                    case ConsoleKey.Spacebar:
                        szin++;
                        if (szin == 16)
                        {
                            szin = 0;
                        }
                        Console.CursorLeft--;
                        KurzorSzin(szin);

                        if (!toll)
                        {
                            Console.BackgroundColor = (ConsoleColor)back;
                            Console.Write(" ");
                            Console.CursorLeft--;
                        }
                        else
                        {
                            Console.BackgroundColor = (ConsoleColor)szin;
                        }
                        
                        break;

                    case ConsoleKey.W:
                        szin = 15;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

                        break;

                    case ConsoleKey.G:
                        toll = !toll;
                        Console.Write("\b \b");
                        Console.BackgroundColor = (ConsoleColor)szin;
                        break;

                    case ConsoleKey.H:
                        radir = !radir;
                        RadirOn();
                        Console.Write("\b \b");
                        break;

                    case ConsoleKey.J:
                        Console.BackgroundColor = (ConsoleColor)back;
                        Console.Write("\b \b");
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        break;

                    case ConsoleKey.L:
                        back++;
                        if (back == 16)
                        {
                            back = 0;
                        }
                        Console.Write("\b \b");
                        break;

                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        break;

                    case ConsoleKey:
                        Console.Write("\b \b");
                        break;
                }

            }
        }

        static void KurzorSzin(int szin)
        {
            X = Console.CursorLeft;
            Y = Console.CursorTop;

            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("A kurzor színe: ");
            Console.BackgroundColor = (ConsoleColor)szin;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = (ConsoleColor)szin;

            Console.CursorTop = Y;
            Console.CursorLeft = X;
        }

        static void RadirOn()
        {
            X = Console.CursorLeft;
            Y = Console.CursorTop;

            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            if (radir)
            {
                Console.Write("A radír be van kapcsolva ");
                Console.BackgroundColor = (ConsoleColor)back;
                toll = true;
            }
            else
            {
                Console.Write("                         ");
                toll = false;
            }

            Console.CursorTop = Y;
            Console.CursorLeft = X;
        }

        static void Info()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Szimpla pixelart-os program.");
            Console.WriteLine("Köszönöm támogatásod éshogy megvetted ezt a játékot.");
            Console.WriteLine("\nW-vel kezdesz új lapot, szóközzel váltasz színt (16 szín van) és G-vel rakod le a tollat illetve emeled fel.");
            Console.WriteLine("H-val lesz megint fehér, L-vel váltasz háttérszínt, J-vel törlöd a képernyőt a háttérszínre.");
            Console.WriteLine("Nyilakkal mozogsz, és bárhol tudsz rajzolni.");

            Console.WriteLine("\nKnown bug: ha kirakod nagyba a programot míg a szín más pl. kék akkor az egész kék lesz.");

            Console.WriteLine("\nNyomj meg egy gombot, hogy kezdj.");
            Console.ReadKey();

            Console.Title = "PixelArt maker";
        }
    }
}
