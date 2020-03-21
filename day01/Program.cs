using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace day01
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInput = File.ReadAllText("input.txt");
            List<string> masses = fileInput.Split("\r\n").ToList();
            int _fuel = 0;
            int _extrafuel = 0;

            foreach (var mass in masses)
            {
                int tmpmass = Convert.ToInt32(mass);
                
                tmpmass = fuel(tmpmass);
                _fuel += tmpmass;

                int extramass = tmpmass;
                while (extramass > 0)
                {
                    extramass = fuel(extramass);
                    if (extramass > 0) _extrafuel += extramass;
                }
            }
            Console.WriteLine("Day 1 Part one fuel needed: " + _fuel);
            Console.WriteLine("Day 1 Part two fuel needed: " + (_fuel + _extrafuel));
            Console.ReadLine();
        }

        private static int fuel(int mass)
        {
            mass = (int)(mass / 3) - 2;
            return mass;
        }

    }
}
