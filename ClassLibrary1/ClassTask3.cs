using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ClassTask3
    {
        public static int FindNumberCloseToAverage(int[,] numbers)
        {
            int m = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                m = m + numbers[0, i];
            }
            m = m / numbers.Length;
            int answer = numbers[0, 0];

            int difference = Math.Abs(numbers[0, 0] - m);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (difference > Math.Abs(numbers[0, i] - m))
                {
                    difference = Math.Abs(numbers[0, i] - m);
                    answer = numbers[0, i];
                }
            }
            return answer;
        }
    }
}
