using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2022.Days
{
    public class Day8 : BaseDay, IDay
    {
        public Day8(string inputPath) : base(inputPath) { }
        public bool checkUp(int x, int y)
        {
            for (int i = x - 1; i >= 0; i--)
            {
                if (input[x][y] <= input[i][y])
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkDown(int x, int y)
        {
            for (int i = x + 1; i < input.Length; i++)
            {
                if (input[x][y] <= input[i][y])
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkleft(int x, int y)
        {
            for (int i = y - 1; i >= 0; i--)
            {
                if (input[x][y] <= input[x][i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkRight(int x, int y)
        {
            for (int i = y + 1; i < input.Length; i++)
            {
                if (input[x][y] <= input[x][i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckIfTreeVisible(int x, int y)
        {
            if (checkDown(x, y) || checkleft(x, y) || checkRight(x, y) || checkUp(x, y))
            {
                return true;
            }
            return false;
        }

        public void SolvePuzzlePart1()
        {
            //hehe if I can hardcode I will hardcode this
            int gridTrees = 4 * input.Length - 4;
            int visibleTreesCount = 0;
            for (int i = 1; i < input[0].Length - 1; i++)
            {
                for (int j = 1; j < input.Length - 1; j++)
                {
                    if (CheckIfTreeVisible(i, j))
                    {
                        visibleTreesCount++;
                    }
                }
            }
            Console.WriteLine("Part 1 solution: " + (gridTrees + visibleTreesCount));
        }

        public void SolvePuzzlePart2()
        {
            int max = 0;
            for (int i = 1; i < input[0].Length - 1; i++)
            {
                for (int j = 1; j < input.Length - 1; j++)
                {
                    int visibleTrees = CheckIfTreeVisiblePart2(i, j);
                    if (max < visibleTrees)
                    {
                        max = visibleTrees;
                    }
                }
            }
            Console.WriteLine("Part 2 solution: " + max);
        }

        private int CheckIfTreeVisiblePart2(int x, int y)
        {
            
            int up = 0;
            int down = 0;
            int left = 0;
            int right = 0;
            //up
            for (int i = x - 1; i >= 0; i--)
            {
                if (input[x][y] <= input[i][y])
                {
                    up++;
                    break;
                }
                up++;
            }

            //down
            for (int i = x + 1; i < input.Length; i++)
            {
                if (input[x][y] <= input[i][y])
                {
                    down++;
                    break;
                }
                down++;
            }

            //left
            for (int i = y - 1; i >= 0; i--)
            {
                if (input[x][y] <= input[x][i])
                {
                    left++;
                    break;
                }
                left++;
            }

            //right
            for (int i = y + 1; i < input.Length; i++)
            {
                if (input[x][y] <= input[x][i])
                {
                    right++;
                    break;
                }
                right++;
            }

            return (up * down * left * right);
        }

        public void SolvePuzzles()
        {
            SolvePuzzlePart1();
            SolvePuzzlePart2();
        }
    }
}
