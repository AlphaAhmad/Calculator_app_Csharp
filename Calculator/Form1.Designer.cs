namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintScreen = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Mode = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.decemal = new System.Windows.Forms.Button();
            this.Sine = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cot = new System.Windows.Forms.Button();
            this.Cosec = new System.Windows.Forms.Button();
            this.Sec = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Label();
            this.SinH = new System.Windows.Forms.Label();
            this.CosH = new System.Windows.Forms.Label();
            this.TanH = new System.Windows.Forms.Label();
            this.CotH = new System.Windows.Forms.Label();
            this.SecH = new System.Windows.Forms.Label();
            this.CosecH = new System.Windows.Forms.Label();
            this.Shft = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintScreen
            // 
            this.PrintScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PrintScreen.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintScreen.Location = new System.Drawing.Point(12, 12);
            this.PrintScreen.Multiline = true;
            this.PrintScreen.Name = "PrintScreen";
            this.PrintScreen.ReadOnly = true;
            this.PrintScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PrintScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrintScreen.Size = new System.Drawing.Size(407, 48);
            this.PrintScreen.TabIndex = 0;
            this.PrintScreen.Text = "0";
            this.PrintScreen.TextChanged += new System.EventHandler(this.PrintScreen_TextChanged);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(33, 338);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(56, 48);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(112, 335);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(56, 48);
            this.Two.TabIndex = 2;
            this.Two.Text = " 2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(197, 335);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(58, 46);
            this.Three.TabIndex = 3;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(33, 282);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(56, 48);
            this.Four.TabIndex = 4;
            this.Four.Text = " 4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(112, 282);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(56, 48);
            this.Five.TabIndex = 5;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(197, 282);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(56, 48);
            this.six.TabIndex = 6;
            this.six.Text = " 6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(112, 389);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(56, 48);
            this.zero.TabIndex = 7;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(33, 228);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(56, 48);
            this.seven.TabIndex = 8;
            this.seven.Text = " 7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(112, 228);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(56, 48);
            this.eight.TabIndex = 9;
            this.eight.Text = " 8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(197, 230);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(56, 46);
            this.nine.TabIndex = 10;
            this.nine.Text = " 9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Mode
            // 
            this.Mode.Location = new System.Drawing.Point(33, 392);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(58, 46);
            this.Mode.TabIndex = 11;
            this.Mode.Text = "Mode %";
            this.Mode.UseVisualStyleBackColor = true;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(275, 390);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(138, 46);
            this.Factorial.TabIndex = 12;
            this.Factorial.Text = "Factorial (!)";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(275, 335);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(58, 46);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(275, 284);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(58, 46);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(275, 228);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(58, 46);
            this.Divide.TabIndex = 15;
            this.Divide.Text = "÷\r\n";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Product.Location = new System.Drawing.Point(197, 387);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(58, 46);
            this.Product.TabIndex = 16;
            this.Product.Text = "x";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equal.Location = new System.Drawing.Point(355, 338);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(58, 46);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // CLR
            // 
            this.CLR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CLR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CLR.ForeColor = System.Drawing.Color.Black;
            this.CLR.Location = new System.Drawing.Point(359, 102);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(58, 46);
            this.CLR.TabIndex = 18;
            this.CLR.Text = "AC";
            this.CLR.UseVisualStyleBackColor = false;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // decemal
            // 
            this.decemal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decemal.Location = new System.Drawing.Point(355, 284);
            this.decemal.Name = "decemal";
            this.decemal.Size = new System.Drawing.Size(56, 48);
            this.decemal.TabIndex = 19;
            this.decemal.Text = " .";
            this.decemal.UseVisualStyleBackColor = true;
            this.decemal.Click += new System.EventHandler(this.decemal_Click);
            // 
            // Sine
            // 
            this.Sine.Location = new System.Drawing.Point(33, 165);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(56, 46);
            this.Sine.TabIndex = 20;
            this.Sine.Text = " sin x";
            this.Sine.UseVisualStyleBackColor = true;
            this.Sine.Click += new System.EventHandler(this.Sine_Click);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cos.Location = new System.Drawing.Point(112, 164);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(58, 46);
            this.Cos.TabIndex = 21;
            this.Cos.Text = "cos x";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Tan
            // 
            this.Tan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tan.Location = new System.Drawing.Point(195, 165);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(58, 46);
            this.Tan.TabIndex = 22;
            this.Tan.Text = "tan x";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Cot
            // 
            this.Cot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cot.Location = new System.Drawing.Point(275, 165);
            this.Cot.Name = "Cot";
            this.Cot.Size = new System.Drawing.Size(58, 46);
            this.Cot.TabIndex = 23;
            this.Cot.Text = "cot x";
            this.Cot.UseVisualStyleBackColor = true;
            this.Cot.Click += new System.EventHandler(this.Cot_Click);
            // 
            // Cosec
            // 
            this.Cosec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cosec.Location = new System.Drawing.Point(355, 228);
            this.Cosec.Name = "Cosec";
            this.Cosec.Size = new System.Drawing.Size(62, 46);
            this.Cosec.TabIndex = 24;
            this.Cosec.Text = "cosec x";
            this.Cosec.UseVisualStyleBackColor = true;
            this.Cosec.Click += new System.EventHandler(this.Cosec_Click);
            // 
            // Sec
            // 
            this.Sec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sec.Location = new System.Drawing.Point(355, 165);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(62, 46);
            this.Sec.TabIndex = 25;
            this.Sec.Text = "sec x";
            this.Sec.UseVisualStyleBackColor = true;
            this.Sec.Click += new System.EventHandler(this.Sec_Click);
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Power.Location = new System.Drawing.Point(114, 102);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(56, 46);
            this.Power.TabIndex = 26;
            this.Power.Text = " ^";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log.Location = new System.Drawing.Point(195, 102);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(56, 46);
            this.Log.TabIndex = 27;
            this.Log.Text = " Log x";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Ln
            // 
            this.Ln.AutoSize = true;
            this.Ln.Location = new System.Drawing.Point(197, 84);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(26, 15);
            this.Ln.TabIndex = 28;
            this.Ln.Text = "ln x";
            this.Ln.Click += new System.EventHandler(this.Ln_Click);
            // 
            // SinH
            // 
            this.SinH.AutoSize = true;
            this.SinH.Location = new System.Drawing.Point(33, 151);
            this.SinH.Name = "SinH";
            this.SinH.Size = new System.Drawing.Size(38, 15);
            this.SinH.TabIndex = 29;
            this.SinH.Text = "sinh x";
            // 
            // CosH
            // 
            this.CosH.AutoSize = true;
            this.CosH.Location = new System.Drawing.Point(114, 151);
            this.CosH.Name = "CosH";
            this.CosH.Size = new System.Drawing.Size(41, 15);
            this.CosH.TabIndex = 30;
            this.CosH.Text = "cosh x";
            // 
            // TanH
            // 
            this.TanH.AutoSize = true;
            this.TanH.Location = new System.Drawing.Point(195, 151);
            this.TanH.Name = "TanH";
            this.TanH.Size = new System.Drawing.Size(40, 15);
            this.TanH.TabIndex = 31;
            this.TanH.Text = "tanh x";
            // 
            // CotH
            // 
            this.CotH.AutoSize = true;
            this.CotH.Location = new System.Drawing.Point(275, 151);
            this.CotH.Name = "CotH";
            this.CotH.Size = new System.Drawing.Size(40, 15);
            this.CotH.TabIndex = 32;
            this.CotH.Text = "coth x";
            // 
            // SecH
            // 
            this.SecH.AutoSize = true;
            this.SecH.Location = new System.Drawing.Point(355, 151);
            this.SecH.Name = "SecH";
            this.SecH.Size = new System.Drawing.Size(40, 15);
            this.SecH.TabIndex = 33;
            this.SecH.Text = "sech x";
            // 
            // CosecH
            // 
            this.CosecH.AutoSize = true;
            this.CosecH.Location = new System.Drawing.Point(355, 214);
            this.CosecH.Name = "CosecH";
            this.CosecH.Size = new System.Drawing.Size(53, 15);
            this.CosecH.TabIndex = 34;
            this.CosecH.Text = "cosech x";
            // 
            // Shft
            // 
            this.Shft.BackColor = System.Drawing.Color.Orange;
            this.Shft.Location = new System.Drawing.Point(36, 102);
            this.Shft.Name = "Shft";
            this.Shft.Size = new System.Drawing.Size(53, 46);
            this.Shft.TabIndex = 36;
            this.Shft.Text = "Shift";
            this.Shft.UseVisualStyleBackColor = false;
            this.Shft.Click += new System.EventHandler(this.Shft_Click);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Backspace.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Backspace.ForeColor = System.Drawing.Color.Black;
            this.Backspace.Location = new System.Drawing.Point(275, 102);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(58, 46);
            this.Backspace.TabIndex = 37;
            this.Backspace.Text = "DEL";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(429, 451);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Shft);
            this.Controls.Add(this.CosecH);
            this.Controls.Add(this.SecH);
            this.Controls.Add(this.CotH);
            this.Controls.Add(this.TanH);
            this.Controls.Add(this.CosH);
            this.Controls.Add(this.SinH);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Cosec);
            this.Controls.Add(this.Cot);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.decemal);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.PrintScreen);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PrintScreen;
        private Button one;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button six;
        private Button zero;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button Mode;
        private Button Factorial;
        private Button Plus;
        private Button Minus;
        private Button Divide;
        private Button Product;
        private Button Equal;
        private Button CLR;
        private Button decemal;
        private Button Sine;
        private Button Cos;
        private Button Tan;
        private Button Cot;
        private Button Cosec;
        private Button Sec;
        private Button Power;
        private Button Log;
        private Label Ln;
        private Label SinH;
        private Label CosH;
        private Label TanH;
        private Label CotH;
        private Label SecH;
        private Label CosecH;
        private Button Shft;
        private Button Backspace;
    }
}