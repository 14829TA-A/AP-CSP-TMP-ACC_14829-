using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Programming challenge");
                Console.Write("Challenge #");
                char num = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (num)
                {
                    case '1':
                        Console.Write("1st INT: ");
                        string line = Console.ReadLine();
                        int int1 = int.Parse(line);
                        Console.Write("2nd INT: ");
                        line = Console.ReadLine();
                        int int2 = int.Parse(line);
                        if (int1 != int2)
                        {
                            int result = int1 + int2;
                            Console.WriteLine("Result: "+result);
                        }
                        else
                        {
                            int result = int1 + int2;
                            result *= 2;
                            Console.WriteLine("Result: "+result);
                        }
                        break;
                    case '2':
                        Console.Write("1st INT: ");
                        string llline = Console.ReadLine();
                        int iiint1 = int.Parse(llline);
                        Console.Write("2nd BOOL (Y/N): ");
                        ConsoleKeyInfo key = Console.ReadKey();
                        Console.WriteLine();
                        switch (key.KeyChar)
                        {
                            case 'y':
                                if (iiint1 < 8 || iiint1 > 20)
                                {
                                    Console.WriteLine("Result: Problem!");
                                }
                                else
                                {
                                    Console.WriteLine("Result: No Problem!");
                                }
                                break;
                            case 'n':
                                Console.WriteLine("Result: No Problem!");
                                break;
                            case 'Y':
                                if (iiint1 < 8 || iiint1 > 20)
                                {
                                    Console.WriteLine("Result: Problem!");
                                }
                                else
                                {
                                    Console.WriteLine("Result: No Problem!");
                                }
                                break;
                            case 'N':
                                Console.WriteLine("Result: No Problem!");
                                break;
                            default:
                                break;
                        }
                        break;
                    case '3':
                        Console.Write("1st INT: ");
                        string lline = Console.ReadLine();
                        int iint1 = int.Parse(lline);
                        Console.Write("2nd INT: ");
                        lline = Console.ReadLine();
                        int iint2 = int.Parse(lline);
                        Console.Write("3rd INT: ");
                        lline = Console.ReadLine();
                        int iint3 = int.Parse(lline);
                        if (iint1+iint2>=iint3&&iint1<=iint3||iint1-iint2<=iint3&&iint1>=iint3)
                        {
                            Console.WriteLine("Result: Close Enough!");
                        }
                        else
                        {
                            Console.WriteLine("Result: Not Close!");
                        }
                        break;
                    default:
                        //doInvalid();
                        break;
                }
            }
            catch { };
            Console.Write("Press Any Key To Continue.");
            _ = Console.ReadKey();
        }
    }
}
