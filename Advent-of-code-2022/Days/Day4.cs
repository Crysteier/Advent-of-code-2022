using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day4 : BaseDay, IDay
    {
        public Day4(string inputPath) : base(inputPath) { }

        public void SolvePuzzlePart1()
        {
            char[] delimeters = { ',', '-' };
            int sum = 0;
            foreach (var item in input)
            {
                var sections = item.Split(delimeters);
                if ((int.Parse(sections[0]) >= int.Parse(sections[2])) && (int.Parse(sections[1]) <= int.Parse(sections[3])))
                {
                    sum++;
                }
                else if (int.Parse(sections[0]) <= int.Parse(sections[2]) && int.Parse(sections[1]) >= int.Parse(sections[3]))
                {
                    sum++;
                }
            }

            Console.WriteLine("Puzzle 1 solution: " + sum);
        }

        public void SolvePuzzlePart2()
        {
            char[] delimeters = { ',', '-' };
            int sum = 0;
            foreach (var item in input)
            {
                var sections = item.Split(delimeters);
                var numeroUno = int.Parse(sections[0]);
                var numeroDos = int.Parse(sections[1]);
                var numeroTres = int.Parse(sections[2]);
                var numeroQuatro = int.Parse(sections[3]);
                if ((Enumerable.Range(numeroUno, Math.Abs(numeroDos - numeroUno + 1)).Contains(numeroTres)) || (Enumerable.Range(numeroUno, Math.Abs(numeroDos - numeroUno + 1)).Contains(numeroQuatro)))
                {
                    sum++;
                }
                else if (Enumerable.Range(numeroTres, Math.Abs(numeroQuatro - numeroTres + 1)).Contains(numeroUno) || (Enumerable.Range(numeroTres, Math.Abs(numeroQuatro - numeroTres + 1)).Contains(numeroDos)))
                {
                    sum++;
                }
            }

            Console.WriteLine("Puzzle 2 solution: " + sum);
        }

        public void SolvePuzzles()
        {
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}
