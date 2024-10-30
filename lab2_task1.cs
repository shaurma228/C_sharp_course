using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_task1
{
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

                Console.Write("\n1 - add screen, 2 - add display, 3 - display ratio, 4 - display PPI, 5 - max last num in screen, 0 - exit: ");
                e = p.Input(false);

                switch (e)
                {
                    case 1:
                        Console.Write("    Horisontal resolution: ");
                        resH = p.Input(true);
                        Console.Write("    Vertical resolution: ");
                        resV = p.Input(true);
                        Console.Write("    Size: ");
                        size = p.Input(true);

                        Array.Resize<Screen>(ref screens, screens.Length + 1);
                        screens[screens.Length - 1] = new Screen(resH, resV, size);
                        break;

                    case 2:
                        Console.Write("    Horisontal resolution: ");
                        resH = p.Input(true);
                        Console.Write("    Vertical resolution: ");
                        resV = p.Input(true);
                        Console.Write("    Size: ");
                        size = p.Input(true);
                        Console.Write("    Type: ");
                        type = p.InputScreen();
                        Console.Write("    Refresh rate: ");
                        refR = p.Input(true);

                        Array.Resize<Display>(ref displays, displays.Length + 1);
                        displays[displays.Length - 1] = new Display(resH, resV, size, type, refR);
                        break;

                    case 3:
                        Console.Write("    Display number: ");
                        n = p.Input(false);

                        if (n < 0 || n >= displays.Length)
                        {
                            Console.WriteLine("    This display doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Display [{n}] ratio is " + displays[n].Ratio());
                        break;

                    case 4:
                        Console.Write("    Display number: ");
                        n = p.Input(false);

                        if (n < 0 || n >= displays.Length)
                        {
                            Console.WriteLine("    This display doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Display [{n}] PPI is " + displays[n].PPI());
                        break;
                    case 5:
                        Console.Write("    Screen number: ");
                        n = p.Input(false);

                        if (n < 0 || n >= screens.Length)
                        {
                            Console.WriteLine("    This screen doesn't exist");
                            break;
                        }
                        Console.WriteLine($"    Screen [{n}] max last num is " + screens[n].MaxLastNum());
                        break;
                }
            }
        }

        public int Input(bool ispos)
        {
            int i = 0;
            string line = Console.ReadLine();
            if (!ispos)
            {
                while(!int.TryParse(line, out i))
                {
                    Console.Write("    Value must be digit: ");
                    line = Console.ReadLine();
                }
            }
            else
            {
                while (!int.TryParse(line, out i) || i <= 0)
                {
                    Console.Write("    Value must be digit and more than zero: ");
                    line = Console.ReadLine();
                }
            }
            return i;
        }

        public string InputScreen()
        {
            string[] types = new string[4] {"IPS", "TN", "VA", "OLED" };
            string line = Console.ReadLine();
            while (!types.Contains(line))
            {
                Console.Write("    Screen type must be IPS, TN, VA or OLED: ");
                line = Console.ReadLine();
            }
            return line;
        }
    }
}
