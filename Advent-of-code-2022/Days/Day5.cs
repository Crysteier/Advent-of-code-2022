using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day5 : BaseDay, IDay
    {
        private List<List<int>> commands = new List<List<int>>();
        private Dictionary<int, List<char>> puzzle = new Dictionary<int, List<char>>();

        public Day5(string inputPath) : base(inputPath) { }

        public void SolvePuzzlePart1()
        {
            foreach (var command in commands)
            {
                var buf = new List<char>();
                var line = puzzle[command[1]];
                var len = (line.Count - command[0]);
                for (int i = line.Count - 1; i >= len; i--)
                {
                    buf.Add(line[i]);
                }
                puzzle[command[1]].RemoveRange(line.Count - command[0], command[0]);
                foreach (var ch in buf)
                {
                    puzzle[command[2]].Add(ch);
                }
            }
            var result = "";
            foreach (var item in puzzle)
            {
                result += item.Value.Last();
            }

            Console.WriteLine("Part 1 solution: " + result);
        }

        public void SolvePuzzlePart2()
        {
            foreach (var command in commands)
            {
                var buf = new List<char>();
                var line = puzzle[command[1]];
                var len = (line.Count - command[0]);
                for (int i = line.Count - 1; i >= len; i--)
                {
                    buf.Add(line[i]);
                }
                buf.Reverse();

                puzzle[command[1]].RemoveRange(line.Count - command[0], command[0]);
                foreach (var ch in buf)
                {
                    puzzle[command[2]].Add(ch);
                }
            }
            var result = "";
            foreach (var item in puzzle)
            {
                result += item.Value.Last();
            }

            Console.WriteLine("Part 2 solution: " + result);
        }

        public void SolvePuzzles()
        {
            var length = input[0].Length;
            int num = 1;
            for (int j = 1; j < length; j += 4)
            {
                var puzz = new List<char>();

                for (int i = 7; i >= 0; i--)
                {
                    if (!input[i][j].Equals(' '))
                    {
                        puzz.Add(input[i][j]);
                    }
                }
                puzzle.Add(num, puzz);
                num++;
            }

            for (int i = 10; i < input.Length; i++)
            {
                var buf = input[i].Split(' ');
                var nums = new List<int>();
                for (int j = 1; j < buf.Length; j += 2)
                {
                    nums.Add(int.Parse(buf[j]));
                }
                commands.Add(nums);
            }
            //I am too lazy to make this work properly so you need to have one commented out otherwise it will not work
            //fucking dictionaries not working properly
            //SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}
