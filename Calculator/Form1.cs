using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        int? _number1;
        IProcess _tempProcess;
        public Form1()
        {
            InitializeComponent();
            cB0.BtnClick += WriteNumber;
            cB1.BtnClick += WriteNumber;
            cB2.BtnClick += WriteNumber;
            cB3.BtnClick += WriteNumber;
            cB4.BtnClick += WriteNumber;
            cB5.BtnClick += WriteNumber;
            cB6.BtnClick += WriteNumber;
            cB7.BtnClick += WriteNumber;
            cB8.BtnClick += WriteNumber;
            cB9.BtnClick += WriteNumber;
            oBMultiply.BtnClick += Process;
            oBMultiply.Process = new Multiplication();
            oBDivide.BtnClick += Process;
            oBDivide.Process = new Divide();
            oBSubtract.BtnClick += Process;
            oBSubtract.Process = new Subtraction();
            oBSum.BtnClick += Process;
            oBSum.Process = new Summation();
            
        }
        public void WriteNumber(int number)
        {
            txtbxOperations.Text += number.ToString();
        }

        public void Process(IProcess process)
        {
            if (string.IsNullOrWhiteSpace(txtbxOperations.Text) == false) 
            {
                
                if (_number1.HasValue == false)
                {
                    _number1 = Convert.ToInt32(txtbxOperations.Text);
                    lblOperations.Text += _number1.Value.ToString() + process.OperationSign ;


                }
                else
                {
                    int number2 = Convert.ToInt32(txtbxOperations.Text);
                    DoProcess dprcs = new DoProcess(_number1.Value, number2);
                    lblResult.Text = dprcs.ShowResult(_tempProcess).ToString();
                    _number1 = dprcs.ShowResult(_tempProcess);
                    lblOperations.Text +=   number2.ToString() + process.OperationSign ;

                }
                _tempProcess = process;

                txtbxOperations.Text = "";
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void EndCalculating()
        {
            lblOperations.Text = "";
            lblResult.Text = "";
            _tempProcess = null;
            _number1 = null;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_tempProcess!=null && string.IsNullOrWhiteSpace(txtbxOperations.Text) == false)
            {
                string processHistory = _number1.Value.ToString() + " " + _tempProcess.OperationSign + " " + txtbxOperations.Text + " = ";
                DoProcess dprcs = new DoProcess(_number1.Value, Convert.ToInt32(txtbxOperations.Text));
                txtbxOperations.Text = dprcs.ShowResult(_tempProcess).ToString();
                processHistory = processHistory + txtbxOperations.Text;
                lbOperations.Items.Add(processHistory);
                lblResult.Text = dprcs.ShowResult(_tempProcess).ToString();
            }
            EndCalculating();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxOperations.Clear();
        }

        private void btnCEverything_Click(object sender, EventArgs e)
        {
            txtbxOperations.Clear();
            _number1 = 0;
            _tempProcess = null;

        }
    }
}
