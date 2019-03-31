using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    class OperationButton:Button
    {
        public IProcess Process { get; set; }
        public Action<IProcess> BtnClick;

        public OperationButton()
        {
            Click += CalculatorButton_Click;
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            BtnClick(Process);
        }
    }
}
