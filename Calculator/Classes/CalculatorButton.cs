using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Classes
{
    public class CalculatorButton : Button
    {
        public Action<int> BtnClick;
        public int Number { get; set; }

        public CalculatorButton()
        {
            Click += CalculatorButton_Click;
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            BtnClick(this.Number);
        }


    }
}
