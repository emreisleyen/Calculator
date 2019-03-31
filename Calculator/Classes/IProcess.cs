
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
   public interface IProcess
    {
        int Operation(int a, int b);
        char OperationSign { get;  }
    }

}
