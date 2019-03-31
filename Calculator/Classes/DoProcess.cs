using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class DoProcess
    {
        private int _number1;
        private int _number2;
        public DoProcess(int number1, int number2 )
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int ShowResult(IProcess process)
        {
            return process.Operation(_number1, _number2);
        }

    }
}
