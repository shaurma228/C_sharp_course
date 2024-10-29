﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task1
{
    class Screen
    {
        protected int resH, resV, size; //resolution horisontal, resolution vertical, size (inch)

        public Screen(int a, int b, int c)
        {
            this.resH = a;
            this.resV = b;
            this.size = c;
        }

        public int MaxLastAboba()
        {
            int last_a = Math.Abs(resH) % 10;
            int last_b = Math.Abs(resV) % 10;
            int last_c = Math.Abs(size) % 10;
            return Math.Max(last_a, Math.Max(last_b, last_c));
        }

        public override string ToString()
        {
            return $"Resolution: {resH}x{resV}, Size: {size} inch";
        } 

        public int A
        {
            get { return resH; }
        }

        public int B
        {
            get { return resV; }
        }

        public int C
        {
            get { return size; }
        }
    }

    class Display : Screen
    {
        string  type; //display type (OLED, IPS etc.)
        int refR; //refresh rate

        public Display(int resH, int resV, int size, string type, int refR) : base(resH, resV, size)
        {
            this.type = type;
            this.refR = refR;
        }

        public string Type
        {
            get { return type; }
        }

        public int RefreshRate
        {
            get { return refR; }
        }

        public string Resolution()
        {
            switch (resV)
            {
                case 720:
                    return "HD";
                case 1080:
                    return "FHD";
                case 1440:
                    return "QHD";
                case 2160:
                    return "4K";
                case 4320:
                    return "8K";
                default:
                    return Convert.ToString(resV) + 'p';
            }
        }

        public double PPI()
        {
            return Math.Round(Math.Sqrt(resV * resV + resH * resH) / size, 1);
        }

        public override string ToString()
        {
            return base.ToString() + $", Type: {type}, Refresh rate: {refR}HZ";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int e = -1, n;
            int resH, resV, size, refR;
            string type;
            Screen[] screens = new Screen[0];
            Display[] displays = new Display[0];

            while (e != 0)
            {
                Console.WriteLine("____________________________________________________________________________________________________\nScreens: ");
                if (screens.Length == 0)
                {
                    Console.WriteLine("    No screens");
                }
                for (int i = 0; i < screens.Length; i++)
                {
                    Console.WriteLine($"    [{i}] " + screens[i].ToString());
                }

                Console.WriteLine("\nDisplays: ");
                if (displays.Length == 0)
                {
                    Console.WriteLine("    No displays");
                }
                for (int i = 0; i < displays.Length; i++)
                {
                    Console.WriteLine($"    [{i}] " + displays[i].ToString());
                }

                Console.Write("\n1 - add screen, 2 - add display, 3 - display resolution, 4 - display PPI, 0 - exit: ");
                e = p.Input();

                switch (e)
                {
                    case 1:
                        Console.Write("    Horisontal resolution: ");
                        resH = p.Input();
                        Console.Write("    Vertical resolution: ");
                        resV = p.Input();
                        Console.Write("    Size: ");
                        size = p.Input();

                        Array.Resize<Screen>(ref screens, screens.Length + 1);
                        screens[screens.Length - 1] = new Screen(resH, resV, size);
                        break;

                    case 2:
                        Console.Write("    Horisontal resolution: ");
                        resH = p.Input();
                        Console.Write("    Vertical resolution: ");
                        resV = p.Input();
                        Console.Write("    Size: ");
                        size = p.Input();
                        Console.Write("    Type: ");
                        type = Console.ReadLine();
                        Console.Write("    Refresh rate: ");
                        refR = p.Input();

                        Array.Resize<Display>(ref displays, displays.Length + 1);
                        displays[displays.Length - 1] = new Display(resH, resV, size, type, refR);
                        break;

                    case 3:
                        Console.Write("    Display number: ");
                        n = p.Input();

                        if (n < 0 || n >= displays.Length)
                        {
                            Console.WriteLine("    This display doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Display [{n}] resolution is " + displays[n].Resolution());
                        break;

                    case 4:
                        Console.Write("    Display number: ");
                        n = p.Input();

                        if (n < 0 || n >= displays.Length)
                        {
                            Console.WriteLine("    This display doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Display [{n}] PPI is " + displays[n].PPI());
                        break;
                }
            }
        }

        public int Input(int i = 0)
        {
            string line = Console.ReadLine();
            while(!int.TryParse(line, out i))
            {
                Console.Write("    Value must be digit: ");
                line = Console.ReadLine();
            }
            return i;
        }
    }
}