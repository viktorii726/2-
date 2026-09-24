using System;

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            string buf = Console.ReadLine();
            int n;
            bool ok = int.TryParse(buf, out n);
            if (!ok)
            {
                Console.WriteLine("Некорректный ввод n");
                return;
            }

            Console.Write("Введите m: ");
            buf = Console.ReadLine();
            int m;
            ok = int.TryParse(buf, out m);
            if (!ok)
            {
                Console.WriteLine("Некорректный ввод m");
                return;
            }

            Console.WriteLine("n={0}", n);
            Console.WriteLine("m={0}", m);

            int r1 = m - ++n;
            Console.WriteLine("m-++n={0} m={1} n={2}", r1, m, n);

            bool r2 = m++ > --n;
            Console.WriteLine("m++>--n={0} m={1} n={2}", r2, m, n);

            bool r3 = m-- < ++n;
            Console.WriteLine("m--<++n={0} m={1} n={2}", r3, m, n);

            Console.WriteLine("Итог: m={0} n={1}", m, n);

            Console.WriteLine();
            Console.Write("Введите x: ");
            buf = Console.ReadLine();
            double x;
            ok = double.TryParse(buf, out x);
            if (!ok)
            {
                Console.WriteLine("Некорректный ввод x");
                return;
            }

            if (x < -2 || x > 0)
            {
                Console.WriteLine("Нельзя вычислить arcsin");
            }
            else
            {
                double r4 = Math.Asin(Math.Abs(x + 1));
                Console.WriteLine("arcsin(|x+1|) = {0}", r4);
            }

            Console.WriteLine();
            Console.Write("Введите x1: ");
            buf = Console.ReadLine();
            double x1;
            ok = double.TryParse(buf, out x1);
            if (!ok)
            {
                Console.WriteLine("Некорректный ввод x1");
                return;
            }

            Console.Write("Введите y1: ");
            buf = Console.ReadLine();
            double y1;
            ok = double.TryParse(buf, out y1);
            if (!ok)
            {
                Console.WriteLine("Некорректный ввод y1");
                return;
            }

            bool inside = (x1 >= 0) && ((x1 - 5) * (x1 - 5) + y1 * y1 <= 25);
            Console.WriteLine("Точка принадлежит области: " + inside);

            Console.WriteLine();
            double a = 1000;
            double b = 0.0001;

            double z1 = a - b;
            double z2 = Math.Pow(z1, 3);
            double z3 = Math.Pow(a, 3);
            double z4 = Math.Pow(b, 2);
            double z5 = 3 * a * z4;
            double z6 = z3 + z5;
            double numerator = z2 - z6;

            double z7 = Math.Pow(a, 2);
            double z8 = 3 * z7 * b;
            double z9 = Math.Pow(b, 3);
            double denominator = -z8 - z9;

            double res = numerator / denominator;
            Console.WriteLine("Результат double = " + res);

            float af = 1000f;
            float bf = 0.0001f;
            float fz1 = af - bf;
            float fz2 = (float)Math.Pow(fz1, 3);
            float fz3 = (float)Math.Pow(af, 3);
            float fz4 = (float)Math.Pow(bf, 2);
            float fz5 = 3 * af * fz4;
            float fz6 = fz3 + fz5;
            float fnumerator = fz2 - fz6;
            float fz7 = (float)Math.Pow(af, 2);
            float fz8 = 3 * fz7 * bf;
            float fz9 = (float)Math.Pow(bf, 3);
            float fdenominator = -fz8 - fz9;
            float fres = fnumerator / fdenominator;
            Console.WriteLine("Результат float = " + fres);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}