using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day02
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInput = File.ReadAllText("inputDay02.txt");
            List<int> codes = fileInput.Split(",").Select(Int32.Parse).ToList();
            List<int> resetCodes = fileInput.Split(",").Select(Int32.Parse).ToList(); 
            codes[1] = 12;
            codes[2] = 2;
            int res = 0;

            for (int i = 0; i < codes.Count; i++)
            {
                if (codes[i] == 1)
                {
                    res = codes[codes[i + 1]] + codes[codes[i + 2]];
                    codes[codes[i + 3]] = res;
                    i += 3;
                }
                else if (codes[i] == 2)
                {
                    res = codes[codes[i + 1]] * codes[codes[i + 2]];
                    codes[codes[i + 3]] = res;
                    i += 3;

                }
                else if (codes[i] == 99)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error, not valid code: " + codes[i]);
                }
            }

            Console.WriteLine("Result for part 1: " + codes[0]);

            int noun = -1;
            int verb = 0;
            int target = 19690720;

            while (codes[0] != target)
            {
                codes = fileInput.Split(",").Select(Int32.Parse).ToList();
                noun++;
                if (noun == 100)
                {
                    noun = 0;
                    verb++;
                }
                codes[1] = noun;
                codes[2] = verb;

                for (int i = 0; i < codes.Count; i++)
                {
                    if (codes[i] == 1)
                    {
                        res = codes[codes[i + 1]] + codes[codes[i + 2]];
                        codes[codes[i + 3]] = res;
                        i += 3;
                    }
                    else if (codes[i] == 2)
                    {
                        res = codes[codes[i + 1]] * codes[codes[i + 2]];
                        codes[codes[i + 3]] = res;
                        i += 3;

                    }
                    else if (codes[i] == 99)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, not valid code: " + codes[i]);
                        break;
                    }
                }

            }
            Console.WriteLine("Result for part 2: " + (100 * noun + verb));
            Console.ReadLine();

        }
    }
}
