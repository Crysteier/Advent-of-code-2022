using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day3 : BaseDay, IDay
    {
        public Day3(string inputPath) : base(inputPath) { }

        private int CalculateChars(List<char> characters)
        {
            int sum = 0;
            foreach (var character in characters)
            {
                if (Char.IsUpper(character))
                {
                    sum += Math.Abs(('A' - character - 27));
                }
                else
                {
                    sum += Math.Abs(('a' - character - 1));
                }
            }
            return sum;
        }

        public void SolvePuzzlePart1()
        {
            var chars = new List<char>();
            foreach (var item in input)
            {
                var buf = new HashSet<char>();
                var half = (int)item.Length / 2;
                var first = item.ToCharArray(0, half);
                var second = item.ToCharArray(half, half);
                
                foreach(var ch in first)
                {
                    if (second.Contains(ch))
                    {
                        buf.Add(ch);
                    }
                }
                foreach (var ch in buf)
                {
                    chars.Add(ch);
                }
            }

            int sum = CalculateChars(chars);
            Console.WriteLine("Part 1 solution: " + sum);
        }

        public void SolvePuzzlePart2()
        {
            var chars = new List<char>();

            for (int i = 0; i < input.Length; i += 3)
            {
                var first = input[i].ToCharArray();
                var second = input[i + 1].ToCharArray();
                var third = input[i + 2].ToCharArray();

                for (int j = 0; j < first.Length; j++)
                {
                    if (second.Contains(first[j]))
                    {
                        if (third.Contains(first[j]))
                        {
                            chars.Add(first[j]);
                            break;
                        }
                    }
                }
            }
            int sum = CalculateChars(chars);
            Console.WriteLine("Part 2 solution: " + sum);
        }

        public void SolvePuzzles()
        {
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}
