namespace Feladatsor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int SzamBekeres()
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
            int a = SzamBekeres();
            Console.WriteLine($"A szám kétszerese: {a * (long)2}");
        }

        static void F4()
        {
            Console.WriteLine("Adj meg egy egész számot:");
            int a = SzamBekeres();
            Console.WriteLine("Adj meg egy egész számot:");
            int b = SzamBekeres();

            Console.WriteLine($"A számok összege: {a + b}");
            Console.WriteLine($"A számok különbözete: {a - b}");
            Console.WriteLine($"A számok szorzata: {a * b}");
            if (b != 0) {
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
            int a = SzamBekeres();
            Console.WriteLine("Adj meg egy egész számot:");
            int b = SzamBekeres();

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
            while (true)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int a = SzamBekeres();
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int b = SzamBekeres();
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int c = SzamBekeres();

                if (c > 0 && b > 0 && a > 0)
                {
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
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F7()
        {
            while (true)
            {
                Console.WriteLine("Add meg az első oldalt:");
                int a = SzamBekeres();
                Console.WriteLine("Add meg a második oldalt:");
                int b = SzamBekeres();
                Console.WriteLine("Add meg a harmadik oldalt:");
                int c = SzamBekeres();

                if (c > 0 && b > 0 && a > 0)
                {
                    if (a + b > c || a + c > b || b + c > a)
                    {
                        Console.WriteLine("Ezekkel az oldalakkal szerkeszthető háromszög.");
                    }
                    else
                    {
                        Console.WriteLine("Ezekkel az oldalakkal nem szerkeszthető háromszög.");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F8()
        {
            while (true)
            {
                Console.WriteLine("Add meg az első oldalt:");
                int a = SzamBekeres();
                Console.WriteLine("Add meg a második oldalt:");
                int b = SzamBekeres();

                if (b > 0 && a > 0)
                {
                    Console.WriteLine($"A számtani közepe a számoknak: {(a+b)/2}");
                    Console.WriteLine($"A mértani közepe a számoknak: {Math.Sqrt(a*b)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F9()
        {
            Console.WriteLine("Add meg az első együtthatót:");
            int a = SzamBekeres();
            Console.WriteLine("Add meg a második együtthatót:");
            int b = SzamBekeres();
            Console.WriteLine("Add meg a harmadik együtthatót:");
            int c = SzamBekeres();

            double D = b*b-4*a*c;
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
            int a = SzamBekeres();
            Console.WriteLine("Add meg a második együtthatót:");
            int b = SzamBekeres();
            Console.WriteLine("Add meg a harmadik együtthatót:");
            int c = SzamBekeres();

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
            while (true)
            {
                Console.WriteLine("Add meg az első oldalt:");
                int a = SzamBekeres();
                Console.WriteLine("Add meg a második oldalt:");
                int b = SzamBekeres();

                if (b > 0 && a > 0)
                {
                    double atlo = a * a + b * b;
                    Console.WriteLine($"Az átló hossza: {atlo:F2}");
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F12()
        {
            while (true)
            {
                Console.WriteLine("Add meg az első élet:");
                int a = SzamBekeres();
                Console.WriteLine("Add meg a második élet:");
                int b = SzamBekeres();
                Console.WriteLine("Add meg a harmadik élet:");
                int c = SzamBekeres();

                if (c > 0 && b > 0 && a > 0)
                {
                    Console.WriteLine($"A téglatest felszíne: {2*(a*b) + 4*(b*c)}");
                    Console.WriteLine($"A téglatest térfogata: {a*b*c}");
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F13()
        {
            while (true)
            {
                Console.WriteLine("Add meg a kör átmérőjét:");
                double a = DoubleBekeres()/2;

                if (a > 0)
                {
                    double K = 2 * a * Math.PI;
                    double T = a*a * Math.PI;

                    Console.WriteLine($"A kör kerülete: {K} és területe: {T}");
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F14()
        {
            while (true)
            {
                Console.WriteLine("Add meg a körív sugarát:");
                double a = DoubleBekeres();
                Console.WriteLine("Add meg a körív középponti szögét fokban:");
                double b = DoubleBekeres();

                if (a > 0 && b > 0)
                {
                    double L = b*Math.PI*a/180;
					double T = a*a*MAth.PI/360*b;

                    Console.WriteLine($"A határoló ív hossza: {L}");
					Console.WriteLine($"A körcikk területe: {T}");
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F15()
        {
            while (true)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int a = SzamBekeres();

                if (a > 0)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F16()
        {
            while (true)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int a = SzamBekeres();

                if (a > 0)
                {
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine(i);
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }

        static void F17()
        {
            while (true)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot:");
                int a = SzamBekeres();

                if (a > 0)
                {
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

                    return;
                }
                else
                {
                    Console.WriteLine("Kérlek pozitív egész számokat adj meg.");
                }
            }
        }
    }
}
