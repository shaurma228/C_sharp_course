﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = -1, x, y, n, val;
            Program p = new Program();
            LineSegment[] lines = new LineSegment[0];

            while (e != 0)
            {
                Console.WriteLine("____________________________________________________________________________________________________\nLines: ");

                if (lines.Length == 0)
                {
                    Console.WriteLine("    No lines");
                }
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine($"    [{i}] " + lines[i].ToString());
                }

                Console.Write("\n1 - add line, 2 - line lenth, 3 - line borders+1, 4 - x int, 5 - y double, 6 - +int, 7 - <>, 0 - exit: ");
                e = p.Input();

                switch (e)
                {
                    case 1:
                        Console.Write("    line x: ");
                        x = p.Input();
                        Console.Write("    line y: ");
                        y = p.Input();

                        Array.Resize<LineSegment>(ref lines, lines.Length + 1);
                        lines[lines.Length - 1] = new LineSegment(x, y);
                        break;
                    case 2:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Line [{n}] lenth is " + !lines[n]);
                        break;
                    case 3:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }
                        lines[n]++;
                        break;
                    case 4:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Explicit cast to int x of [{n}] line is " + (int)lines[n]);
                        break;
                    case 5:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Implicit cast to double [{n}] line is " + (double)lines[n]);
                        break;
                    case 6:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }

                        Console.Write("    +int: ");
                        val = p.Input();
                        lines[n] = lines[n] + val;
                        break;
                    case 7:
                        Console.Write("    Line number: ");
                        n = p.Input();

                        if (n < 0 || n >= lines.Length)
                        {
                            Console.WriteLine("    This line doesn't exist");
                            break;
                        }
                        Console.Write("    Value in line: ");
                        val = p.Input();
                        if (lines[n] < val)
                        {
                            Console.WriteLine($"    {val} is in line [{n}]");
                        }
                        else
                        {
                            Console.WriteLine($"    {val} is not in line [{n}]");
                        }
                        break;
                }
            }
        }

        public int Input(int i = 0)
        {
            string line = Console.ReadLine();
            while (!int.TryParse(line, out i))
            {
                Console.Write("    Value must be digit: ");
                line = Console.ReadLine();
            }
            return i;
        }
    }
}
