using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassTask1
    {
        public bool SolutionTask1(int number) 
        {
            int x = number % 10; 
            number = number / 10; 
            int y = number % 10; 
            number = number / 10; 
            int sum = x + y + number;
            int count = 0;
            while (sum > 0)
            {
                count++;
                sum = sum / 10;
            }
            if (count == 2)
            {
                return true;
            }
            else return false;
        }
    }
}