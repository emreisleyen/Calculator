using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    class Summation : IProcess
    {
        public char OperationSign { get; } = '+';
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }
}
