using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsIntCs
{
    class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;

            }
            return sum;
        }
    }
}
