namespace Feladatsor
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static int ISzamBekeres()
        {
            int? number = null;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható számmá, kérlek add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"A megadott számnak {int.MinValue} és {int.MaxValue} között kell lennie, kérlek próbáld újra: ");
                }
            }
            while (number is null);

            return number.Value;
        }

        static uint USzamBekeres()
        {
            uint? number = null;
            do
            {
                try
                {
                    number = uint.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható számmá, kérlek add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"A megadott számnak {uint.MinValue} és {uint.MaxValue} között kell lennie, kérlek próbáld újra: ");
                }
            }
            while (number is null);

            return number.Value;
        }

        static double DoubleBekeres()
        {
            double? number = null;
            do
            {
                try
                {
                    number = double.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.Write("A megadott érték nem alakítható számmá, kérlek add meg újra: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"A megadott számnak {double.MinValue} és {double.MaxValue} között kell lennie, kérlek próbáld újra: ");
                }
            }
            while (number is null);

            return number.Value;
        }

        static void F1()
        {
            Console.WriteLine("Hello World!");
        }

        static void F2()
        {
            Console.Write("Add meg a neved:");
            string name = Console.ReadLine()!;
            Console.WriteLine($"Szia {name}!");
        }

        static void F3()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int a = ISzamBekeres();
            Console.WriteLine($"A szám kétszerese: {a * (long)2}");
        }

        static void F4()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int a = ISzamBekeres();
            Console.WriteLine("Adj meg egy egész számot:");
            int b = ISzamBekeres();

            Console.WriteLine($"A számok összege: {a + b}");
            Console.WriteLine($"A számok különbözete: {a - b}");
            Console.WriteLine($"A számok szorzata: {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"A számok hányadosa: {a / b}");
            }
            else
            {
                Console.WriteLine("Nullával nem osztunk!");
            }
        }

        static void F5()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int a = ISzamBekeres();
            Console.WriteLine("Adj meg egy egész számot:");
            int b = ISzamBekeres();

            if (a > b)
            {
                Console.WriteLine($"{a} nagyobb, mint {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} nagyobb, mint {a}");
            }
            else
            {
                Console.WriteLine("Egyenlőek a számok.");
            }
        }

        static void F6()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint b = USzamBekeres();
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint c = USzamBekeres();

            if (c < b && c < a)
            {
                Console.WriteLine($"{c} a legkisebb szám");
            }
            else if (b < c && b < a)
            {
                Console.WriteLine($"{b} a legkisebb szám");
            }
            else
            {
                Console.WriteLine($"{a} a legkisebb szám");
            }
        }

        static void F7()
        {
            Console.WriteLine("Add meg az első oldalt:");
            uint a = USzamBekeres();
            Console.WriteLine("Add meg a második oldalt:");
            uint b = USzamBekeres();
            Console.WriteLine("Add meg a harmadik oldalt:");
            uint c = USzamBekeres();

            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine("Ezekkel az oldalakkal szerkeszthető háromszög.");
            }
            else
            {
                Console.WriteLine("Ezekkel az oldalakkal nem szerkeszthető háromszög.");
            }
        }

        static void F8()
        {
            Console.WriteLine("Add meg az első oldalt:");
            uint a = USzamBekeres();
            Console.WriteLine("Add meg a második oldalt:");
            uint b = USzamBekeres();
            
            Console.WriteLine($"A számtani közepe a számoknak: {(a + b) / 2}");
            Console.WriteLine($"A mértani közepe a számoknak: {Math.Sqrt(a * b)}");
        }

        static void F9()
        {
            Console.WriteLine("Add meg az első együtthatót:");
            int a = ISzamBekeres();
            Console.WriteLine("Add meg a második együtthatót:");
            int b = ISzamBekeres();
            Console.WriteLine("Add meg a harmadik együtthatót:");
            int c = ISzamBekeres();

            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása.");
            }
            else
            {
                Console.WriteLine("Az egyenletnek legalább 1 megoldása van.");
            }
        }

        static void F10()
        {
            Console.WriteLine("Add meg az első együtthatót:");
            int a = ISzamBekeres();
            Console.WriteLine("Add meg a második együtthatót:");
            int b = ISzamBekeres();
            Console.WriteLine("Add meg a harmadik együtthatót:");
            int c = ISzamBekeres();

            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                double plusz = (-b + Math.Sqrt(D)) / (2 * a);
                double minusz = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Az egyenletnek van megoldása: {plusz} és {minusz}");
            }
            else
            {
                Console.WriteLine("Az egyenletnek nincs megoldása.");
            }
        }

        static void F11()
        {
            Console.WriteLine("Add meg az első oldalt:");
            uint a = USzamBekeres();
            Console.WriteLine("Add meg a második oldalt:");
            uint b = USzamBekeres();

            double atlo = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Az átló hossza: {atlo:F2}");
        }

        static void F12()
        {
            Console.WriteLine("Add meg az első élet:");
            uint a = USzamBekeres();
            Console.WriteLine("Add meg a második élet:");
            uint b = USzamBekeres();
            Console.WriteLine("Add meg a harmadik élet:");
            uint c = USzamBekeres();

            Console.WriteLine($"A téglatest felszíne: {2 * (a * b) + 4 * (b * c)}");
            Console.WriteLine($"A téglatest térfogata: {a * b * c}");
        }

        static void F13()
        {
            Console.WriteLine("Add meg a kör átmérőjét:");
            uint a = USzamBekeres();
            double r = a / 2.0;

            double K = 2 * r * Math.PI;
            double T = r * r * Math.PI;

            Console.WriteLine($"A kör kerülete: {K} és területe: {T}");
        }

        static void F14()
        {
            Console.WriteLine("Add meg a körív sugarát:");
            uint a = USzamBekeres();
            Console.WriteLine("Add meg a körív középponti szögét fokban:");
            uint b = USzamBekeres();

            double L = b * Math.PI * a / 180;
            double T = a * a * Math.PI / 360 * b;

            Console.WriteLine($"A határoló ív hossza: {L}");
            Console.WriteLine($"A körcikk területe: {T}");
        }

        static void F15()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();
            
            for (int i = 0; i < a; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void F16()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();
            
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void F17()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();
            
            List<int> osztok = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    osztok.Add(i);
                }
            }

            for (int i = 0; i < osztok.Count(); i++)
            {
                Console.Write($"{osztok[i]} ");
            }
        }

        static void F18()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();

            List<int> osztok = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    osztok.Add(i);
                }
            }

            int osszeg = 0;

            for (int i = 0; i < osztok.Count(); i++)
            {
                osszeg += osztok[i];
            }

            Console.WriteLine($"Az osztok összege: {osszeg}");
        }

        static void F19()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot:");
            uint a = USzamBekeres();

            List<int> osztok = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    osztok.Add(i);
                }
            }

            int osszeg = 0;

            for (int i = 0; i < osztok.Count(); i++)
            {
                osszeg += osztok[i];
            }

            if (osszeg == 2 * a)
            {
                Console.WriteLine($"{a} tökéletes szám.");
            }
            else
            {
                Console.WriteLine($"{a} nem tökéletes szám.");
            }
        }

        static void F20()
        {
            Console.WriteLine("Hatványalap:");
            int a = ISzamBekeres();
            Console.WriteLine("Kitevő:");
            int b = ISzamBekeres();
            Console.WriteLine($"Hatványérték: {Math.Pow(a, b)}");
        }

        static void F21()
        {
            Console.WriteLine("Adj meg egy pozitív számot:");
            uint a = USzamBekeres();
            Console.WriteLine("Ez a szám pozitív.");
        }

        static void F22()
        {
            bool nagyobb = false;
            List<int> szamok = new List<int>();

            while (!nagyobb)
            {
                Console.WriteLine("írj egy számot:");
                int a = ISzamBekeres();

                if (a < 10)
                {
                    nagyobb = true;
                }
                else
                {
                    szamok.Add(a);
                }
            }

            int osszeg = 0;
            for (int i = 0; i < szamok.Count(); i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine($"A számok összege: {osszeg}");
        }


    }
}
