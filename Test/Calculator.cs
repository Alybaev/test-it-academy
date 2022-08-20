using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Calculator
    {
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Subtract(int x, int y) =>
            x - y;
    }
}
