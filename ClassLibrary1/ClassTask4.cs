using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ClassTask4
    {

        public static int[] SwitchSmallestAndLargestNumber(int[,] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] > -1)
                    {
                        count++;
                    }
                }
            }

            int[] mas = new int[count];
            int x = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    if (numbers[i, j] > -1)
                    {
                        mas[x] = numbers[i, j];
                        x++;
                    }
                }
            }
            return mas;
        }
    }
}
