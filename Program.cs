using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace _Setul2
{
    class Program
    {
        static void Main(string[] args)
        {
            // P1();
            // P2();
            // P3();
            // P4();
            // P5();
            // P6();
            // P7();
            // P8();
            
        }
        static void P1()
        {
            Console.WriteLine("Scrieti un numar natural n !");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrieti {n} numere !");
            int c = 0;
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(t[i]);
                if (nr % 2 == 0) c++;
                else;
            }
            Console.WriteLine($"{c} numere pare");
            Console.ReadKey();
        }


        static void P2()
        {
            Console.WriteLine("Scrieti un numar natural n !");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Scrieti {n} numere !");
            int c = 0;
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int r = int.Parse(t[i]);
                if (r < 0) c++;
                if (r == 0) c++;
                else;

            }
            Console.WriteLine(c);
            Console.ReadKey();

        }
        static void P3()
        {
            Console.WriteLine("Scrieti un numar natural n !");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int p = 1;
            for (int i = 1; i <= n; i++)
            {

                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma {s} Produs {p}");
            Console.ReadKey();
        }
        static void P4()
        {
            Console.WriteLine("Dati secventa !");
            string[] t = Console.ReadLine().Split(' ');
            Console.WriteLine("Scrieti cate elemente contine secventa !");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numarul a !");
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n == a)
                {
                    k = i;
                    break;
                    i++;
                }
                else k = -1;
            }

            Console.WriteLine($"{a} se afla pe pozitia {k}");
            Console.ReadKey();
        }
        static void P5()
        {
            Console.WriteLine("Dati secventa !");
            string[] t = Console.ReadLine().Split(' ');
            Console.WriteLine("Scrieti cate elemente are secventa !");
            int n = int.Parse(Console.ReadLine());
            int c = 0, p = -1;
            for (int i = 0; i <= n; i++)
            {
                int x = int.Parse(t[0]);
                p++;
                if (x == p) c++;
            }
            if (c == 0) Console.WriteLine("Nu sunt elemente egale cu pozitia lor");
            else if (c == 1) Console.WriteLine("Un element este egal cu pozitia sa");
            else Console.WriteLine($"{c} numere egale cu pozitia lor");
            Console.ReadKey();
        }
        static void P6()
        {
            Console.WriteLine("Introduceti numarul n !");
            int n = int.Parse(Console.ReadLine());
            int o = 1;
            while (n > 9)
            {
                if (n / 10 % 10 >= n % 10) o = 0;
                n = n / 10;
            }
            if (o == 1) Console.WriteLine("Da");
            else Console.WriteLine("Nu");
            Console.ReadKey();
        }
        static void P7()
        {
            Console.WriteLine("Scrieti numar natural n !");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti secventa !");
            string[] t = Console.ReadLine().Split(' ');
            int x = int.Parse(t[0]);
            for (int i = 0; i < n; i++)
                x = int.Parse(t[i]);
            int max = x;
            int min = max - (x - 1);
            for (int i = 1; i < n; i++)
            {
                if (min > x) min = x;
                if (max < x) max = x;
            }
            int m = max - min;
            int nr = 0;
            for (int i = 0; i < n; i++)
                if (x == m) ;
            nr++;

            Console.WriteLine(min + " " + max);
            Console.ReadKey();
        }
        static void P8()
        {
            Console.WriteLine("Dati un numar natural n !");
            int n = int.Parse(Console.ReadLine());
            int a = 1, b = 1;
            int c;
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
        
    }
}