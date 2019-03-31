namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxOperations = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbOperations = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCEverything = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperations = new System.Windows.Forms.Label();
            this.oBSum = new Calculator.Classes.OperationButton();
            this.oBSubtract = new Calculator.Classes.OperationButton();
            this.oBMultiply = new Calculator.Classes.OperationButton();
            this.oBDivide = new Calculator.Classes.OperationButton();
            this.cB0 = new Calculator.Classes.CalculatorButton();
            this.cB9 = new Calculator.Classes.CalculatorButton();
            this.cB8 = new Calculator.Classes.CalculatorButton();
            this.cB7 = new Calculator.Classes.CalculatorButton();
            this.cB6 = new Calculator.Classes.CalculatorButton();
            this.cB5 = new Calculator.Classes.CalculatorButton();
            this.cB4 = new Calculator.Classes.CalculatorButton();
            this.cB3 = new Calculator.Classes.CalculatorButton();
            this.cB2 = new Calculator.Classes.CalculatorButton();
            this.cB1 = new Calculator.Classes.CalculatorButton();
            this.SuspendLayout();
            // 
            // txtbxOperations
            // 
            this.txtbxOperations.Location = new System.Drawing.Point(41, 34);
            this.txtbxOperations.Name = "txtbxOperations";
            this.txtbxOperations.Size = new System.Drawing.Size(333, 20);
            this.txtbxOperations.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(40, 35);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbOperations
            // 
            this.lbOperations.FormattingEnabled = true;
            this.lbOperations.Location = new System.Drawing.Point(287, 131);
            this.lbOperations.Name = "lbOperations";
            this.lbOperations.Size = new System.Drawing.Size(130, 160);
            this.lbOperations.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 30);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCEverything
            // 
            this.btnCEverything.Location = new System.Drawing.Point(133, 95);
            this.btnCEverything.Name = "btnCEverything";
            this.btnCEverything.Size = new System.Drawing.Size(86, 30);
            this.btnCEverything.TabIndex = 19;
            this.btnCEverything.Text = "CE";
            this.btnCEverything.UseVisualStyleBackColor = true;
            this.btnCEverything.Click += new System.EventHandler(this.btnCEverything_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(374, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 20;
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Location = new System.Drawing.Point(21, 13);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(0, 13);
            this.lblOperations.TabIndex = 21;
            // 
            // oBSum
            // 
            this.oBSum.Location = new System.Drawing.Point(179, 254);
            this.oBSum.Name = "oBSum";
            this.oBSum.Process = null;
            this.oBSum.Size = new System.Drawing.Size(37, 35);
            this.oBSum.TabIndex = 15;
            this.oBSum.Text = "+";
            this.oBSum.UseVisualStyleBackColor = true;
            // 
            // oBSubtract
            // 
            this.oBSubtract.Location = new System.Drawing.Point(179, 213);
            this.oBSubtract.Name = "oBSubtract";
            this.oBSubtract.Process = null;
            this.oBSubtract.Size = new System.Drawing.Size(37, 35);
            this.oBSubtract.TabIndex = 14;
            this.oBSubtract.Text = "-";
            this.oBSubtract.UseVisualStyleBackColor = true;
            // 
            // oBMultiply
            // 
            this.oBMultiply.Location = new System.Drawing.Point(179, 172);
            this.oBMultiply.Name = "oBMultiply";
            this.oBMultiply.Process = null;
            this.oBMultiply.Size = new System.Drawing.Size(37, 35);
            this.oBMultiply.TabIndex = 13;
            this.oBMultiply.Text = "*";
            this.oBMultiply.UseVisualStyleBackColor = true;
            // 
            // oBDivide
            // 
            this.oBDivide.Location = new System.Drawing.Point(179, 131);
            this.oBDivide.Name = "oBDivide";
            this.oBDivide.Process = null;
            this.oBDivide.Size = new System.Drawing.Size(37, 35);
            this.oBDivide.TabIndex = 12;
            this.oBDivide.Text = "/";
            this.oBDivide.UseVisualStyleBackColor = true;
            // 
            // cB0
            // 
            this.cB0.Location = new System.Drawing.Point(87, 254);
            this.cB0.Name = "cB0";
            this.cB0.Number = 0;
            this.cB0.Size = new System.Drawing.Size(40, 35);
            this.cB0.TabIndex = 11;
            this.cB0.Text = "0";
            this.cB0.UseVisualStyleBackColor = true;
            // 
            // cB9
            // 
            this.cB9.Location = new System.Drawing.Point(133, 213);
            this.cB9.Name = "cB9";
            this.cB9.Number = 9;
            this.cB9.Size = new System.Drawing.Size(40, 35);
            this.cB9.TabIndex = 10;
            this.cB9.Text = "9";
            this.cB9.UseVisualStyleBackColor = true;
            // 
            // cB8
            // 
            this.cB8.Location = new System.Drawing.Point(87, 213);
            this.cB8.Name = "cB8";
            this.cB8.Number = 8;
            this.cB8.Size = new System.Drawing.Size(40, 35);
            this.cB8.TabIndex = 9;
            this.cB8.Text = "8";
            this.cB8.UseVisualStyleBackColor = true;
            // 
            // cB7
            // 
            this.cB7.Location = new System.Drawing.Point(41, 213);
            this.cB7.Name = "cB7";
            this.cB7.Number = 7;
            this.cB7.Size = new System.Drawing.Size(40, 35);
            this.cB7.TabIndex = 8;
            this.cB7.Text = "7";
            this.cB7.UseVisualStyleBackColor = true;
            // 
            // cB6
            // 
            this.cB6.Location = new System.Drawing.Point(133, 172);
            this.cB6.Name = "cB6";
            this.cB6.Number = 6;
            this.cB6.Size = new System.Drawing.Size(40, 35);
            this.cB6.TabIndex = 7;
            this.cB6.Text = "6";
            this.cB6.UseVisualStyleBackColor = true;
            // 
            // cB5
            // 
            this.cB5.Location = new System.Drawing.Point(87, 172);
            this.cB5.Name = "cB5";
            this.cB5.Number = 5;
            this.cB5.Size = new System.Drawing.Size(40, 35);
            this.cB5.TabIndex = 6;
            this.cB5.Text = "5";
            this.cB5.UseVisualStyleBackColor = true;
            // 
            // cB4
            // 
            this.cB4.Location = new System.Drawing.Point(41, 172);
            this.cB4.Name = "cB4";
            this.cB4.Number = 4;
            this.cB4.Size = new System.Drawing.Size(40, 35);
            this.cB4.TabIndex = 5;
            this.cB4.Text = "4";
            this.cB4.UseVisualStyleBackColor = true;
            // 
            // cB3
            // 
            this.cB3.Location = new System.Drawing.Point(133, 131);
            this.cB3.Name = "cB3";
            this.cB3.Number = 3;
            this.cB3.Size = new System.Drawing.Size(40, 35);
            this.cB3.TabIndex = 4;
            this.cB3.Text = "3";
            this.cB3.UseVisualStyleBackColor = true;
            // 
            // cB2
            // 
            this.cB2.Location = new System.Drawing.Point(87, 131);
            this.cB2.Name = "cB2";
            this.cB2.Number = 2;
            this.cB2.Size = new System.Drawing.Size(40, 35);
            this.cB2.TabIndex = 3;
            this.cB2.Text = "2";
            this.cB2.UseVisualStyleBackColor = true;
            // 
            // cB1
            // 
            this.cB1.Location = new System.Drawing.Point(41, 131);
            this.cB1.Name = "cB1";
            this.cB1.Number = 1;
            this.cB1.Size = new System.Drawing.Size(40, 35);
            this.cB1.TabIndex = 2;
            this.cB1.Text = "1";
            this.cB1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 373);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCEverything);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbOperations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oBSum);
            this.Controls.Add(this.oBSubtract);
            this.Controls.Add(this.oBMultiply);
            this.Controls.Add(this.oBDivide);
            this.Controls.Add(this.cB0);
            this.Controls.Add(this.cB9);
            this.Controls.Add(this.cB8);
            this.Controls.Add(this.cB7);
            this.Controls.Add(this.cB6);
            this.Controls.Add(this.cB5);
            this.Controls.Add(this.cB4);
            this.Controls.Add(this.cB3);
            this.Controls.Add(this.cB2);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbxOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxOperations;
        private System.Windows.Forms.Button btnCalculate;
        private Classes.CalculatorButton cB1;
        private Classes.CalculatorButton cB2;
        private Classes.CalculatorButton cB3;
        private Classes.CalculatorButton cB4;
        private Classes.CalculatorButton cB5;
        private Classes.CalculatorButton cB6;
        private Classes.CalculatorButton cB7;
        private Classes.CalculatorButton cB8;
        private Classes.CalculatorButton cB9;
        private Classes.CalculatorButton cB0;
        private Classes.OperationButton oBDivide;
        private Classes.OperationButton oBMultiply;
        private Classes.OperationButton oBSubtract;
        private Classes.OperationButton oBSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbOperations;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCEverything;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOperations;
    }
}

