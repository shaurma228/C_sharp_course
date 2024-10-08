using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string input;
            Console.Write("choose task: ");
            string task = Console.ReadLine();
            switch (task) {
                case "11":

                    Console.Write("Input: ");
                    input = Console.ReadLine();
                    if (!double.TryParse(input, out double x))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("Output: " + p.fraction(x));
                    return;

                case "13":

                    Console.Write("Input: ");
                    char x1 = Console.ReadLine()[0];
                    if (!char.IsDigit(x1))
                    {
                        Console.WriteLine("x is not digit");
                        return;
                    }

                    Console.WriteLine("Output: " + p.charToNum(x1));
                    return;

                case "15":

                    Console.Write("Input: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x2))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("Output: " + p.is2Digits(x2));

                    return;
                case "17":

                    Console.Write("Input left border: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int a))
                    {
                        Console.WriteLine("left border is not number");
                        return;
                    }

                    Console.Write("Input right border: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int b))
                    {
                        Console.WriteLine("right border is not number");
                        return;
                    }
                    if (b < a)
                    {
                        Console.WriteLine("left border must be less, than right");
                        return;
                    }

                    Console.Write("Input num: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int num))
                    {
                        Console.WriteLine("num is not number");
                        return;
                    }

                    Console.WriteLine("Num in borders: " + p.isInRange(a, b, num));
                    return;

                case "19":

                    Console.Write("Input a: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int a1))
                    {
                        Console.WriteLine("a is not number");
                        return;
                    }

                    Console.Write("Input b: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int b1))
                    {
                        Console.WriteLine("b is not number");
                        return;
                    }

                    Console.Write("Input c: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int c1))
                    {
                        Console.WriteLine("c is not number");
                        return;
                    }

                    Console.WriteLine("a, b and c is equal: " + p.isEqual(a1, b1, c1));
                    return;

                case "21":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x3))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("ABS x: " + p.abs(x3));
                    return;

                case "23":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x4))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("Output: " + p.is35(x4));
                    return;

                case "25":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x5))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.Write("Input y: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int y5))
                    {
                        Console.WriteLine("y is not number");
                        return;
                    }

                    Console.Write("Input z: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int z5))
                    {
                        Console.WriteLine("z is not number");
                        return;
                    }

                    Console.WriteLine("Max: " + p.max3(x5, y5, z5));
                    return;

                case "27":

                    Console.Write("Input y: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x6))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.Write("Input y: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int y6))
                    {
                        Console.WriteLine("y is not number");
                        return;
                    }

                    Console.WriteLine("Output: " + p.sum2(x6, y6));
                    return;

                case "29":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x7))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("Day: " + p.day(x7));
                    return;

                case "31":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x8))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }
                    if (x8 < 0)
                    {
                        Console.WriteLine("x nust be more than 0");
                        return;
                    }

                    Console.WriteLine(p.listNums(x8));
                    return;

                case "33":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x9))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }
                    if (x9 < 0)
                    {
                        Console.WriteLine("x must be more than 0");
                        return;
                    }

                    Console.WriteLine("Output: " + p.chet(x9));
                    return;

                case "35":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!long.TryParse(input, out long x10))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("Output: " + p.numLen(x10));
                    return;

                case "37":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x11))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }
                    if (x11 < 0)
                    {
                        Console.WriteLine("x must be more than 0");
                        return;
                    }

                    Console.WriteLine("Output: ");
                    p.square(x11);
                    return;

                case "39":

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x12))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }
                    if (x12 < 0)
                    {
                        Console.WriteLine("x must be more than 0");
                        return;
                    }

                    Console.WriteLine("Output: ");
                    p.rightTriangle(x12);
                    return;

                case "41":

                    Console.Write("Input arr lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int len))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] arr = new int[len];
                    for (int i = 0; i < len; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out arr[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x13))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.WriteLine("x index in arr: " + p.findFirst(arr, x13));
                    return;

                case "43":

                    Console.Write("Input arr lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int len1))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len1 <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] arr1 = new int[len1];
                    for (int i = 0; i < len1; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out arr1[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.WriteLine("Max by abs: " + p.maxAbs(arr1));
                    return;

                case "45":

                    Console.Write("Input arr lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int len2))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len2 <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] arr2 = new int[len2];
                    for (int i = 0; i < len2; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out arr2[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.Write("Input ins lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out len2))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len2 <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] ins2 = new int[len2];
                    for (int i = 0; i < len2; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out ins2[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.Write("Input pos: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int pos))
                    {
                        Console.WriteLine("pos is not number");
                        return;
                    }
                    if (pos > arr2.Length)
                    {
                        Console.WriteLine("pos must be in arr");
                        return;
                    }

                    Console.Write("Result: ");
                    int[] res = p.add(arr2, ins2, pos);
                    foreach (int i in res)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    return;

                case "47":

                    Console.Write("Input arr lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int len3))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len3 <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] arr3 = new int[len3];
                    for (int i = 0; i < len3; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out arr3[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.Write("Output: ");
                    int[] res3 = p.reverseBack(arr3);
                    foreach (int i in res3)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    return;

                case "49":

                    Console.Write("Input arr lenght: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int len4))
                    {
                        Console.WriteLine("lenght is not number");
                        return;
                    }
                    if (len4 <= 0)
                    {
                        Console.WriteLine("lenght must be more than 0");
                        return;
                    }

                    int[] arr4 = new int[len4];
                    for (int i = 0; i < len4; i++)
                    {
                        Console.Write("arr " + i + ": ");
                        input = Console.ReadLine();
                        if (!int.TryParse(input, out arr4[i]))
                        {
                            Console.WriteLine("arr element is not number");
                            return;
                        }
                    }

                    Console.Write("Input x: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int x14))
                    {
                        Console.WriteLine("x is not number");
                        return;
                    }

                    Console.Write("Output: ");
                    int[] res4 = p.findAll(arr4, x14);
                    foreach (int i in res4)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    return;

                default:
                    Console.WriteLine("no task");
                    return;
            }
        }

        //11
        public double fraction(double x)
        {
            return x - Math.Truncate(x);
        }

        //13
        public int charToNum(char x)
        {
            return x - '0';
        }

        //15
        public bool is2Digits(int x)
        {
            return (x >= 10 && x <= 99) || (x >= -99 && x <= -10);
        }

        //17
        public bool isInRange(int a, int b, int num)
        {
            return num >= a && num <= b;
        }

        //19
        public bool isEqual(int a, int b, int c)
        {
            return a == b && a == c;
        }

        //21
        public int abs(int x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            return x;
        }

        //23
        public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                return false;
            }
            return x % 3 == 0 || x % 5 == 0;
        }

        //25
        public int max3(int x, int y, int z)
        {
            if (x < y)
            {
                x = y;
            }
            if (x < z)
            {
                x = z;
            }
            return x;
        }

        //27
        public int sum2(int x, int y)
        {
            if (x + y >= 10 && x + y <= 19)
            {
                return 20;
            }
            return x + y;
        }

        //29
        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    return "monday";
                    break;
                case 2:
                    return "tuesday";
                    break;
                case 3:
                    return "wednesday";
                    break;
                case 4:
                    return "thursday";
                    break;
                case 5:
                    return "friday";
                    break;
                case 6:
                    return "saturday";
                    break;
                case 7:
                    return "sunday";
                    break;
                default:
                    return "x is not day of the week";
                    break;
            }
        }

        //31
        public String listNums(int x)
        {
            string s = "0 to x: ";
            for (int i = 0; i <= x; i++)
            {
                s += i + " ";
            }
            return s;
        }

        //33
        public String chet(int x)
        {
            string s = "";
            for (int i = 0; i <= x; i += 2)
            {
                s += i + " ";
            }
            return s;
        }

        //35
        public int numLen(long x)
        {
            int count = 0;
            while (x != 0)
            {
                x = x / 10;
                count++;
            }
            return count;
        }

        //37
        public void square(int x)
        {
            string line = new String('*', x);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(line);
            }
        }

        //39
        public void rightTriangle(int x)
        {
            string line;
            for (int i = 1; i <= x; i++)
            {
                line = new String(' ', x - i) + new String('*', i);
                Console.WriteLine(line);
            }
        }

        //41
        public int findFirst(int[] arr, int x)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //43
        public int maxAbs(int[] arr)
        {
            int max = 0;
            int sign = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    if (arr[i] * -1 > max)
                    {
                        max = arr[i] * -1;
                        sign = -1;
                    }
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    sign = 1;
                }
            }
            return max * sign;
        }

        //45
        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] res = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
            {
                res[i] = arr[i];
            }
            for (int i = 0; i < ins.Length; i++)
            {
                res[i + pos] = ins[i];
            }
            for (int i = pos; i < arr.Length; i++)
            {
                res[i + pos + ins.Length - 2] = arr[i];
            }

            return res;
        }

        //47
        public int[] reverseBack(int[] arr)
        {
            int[] res = new int[arr.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = arr[arr.Length - i - 1];
            }

            return res;
        }

        //49
        public int[] findAll(int[] arr, int x)
        {
            int[] res = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    Array.Resize<int>(ref res, res.Length + 1);
                    res[res.Length - 1] = i;
                }
            }

            return res;
        }
    }
}
