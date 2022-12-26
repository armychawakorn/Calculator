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
            this.Display1 = new System.Windows.Forms.TextBox();
            this.Display_panel = new System.Windows.Forms.Panel();
            this.Display2 = new System.Windows.Forms.TextBox();
            this.Number_panel = new System.Windows.Forms.Panel();
            this.btnClearCE = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.rem = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.Display_panel.SuspendLayout();
            this.Number_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display1
            // 
            this.Display1.BackColor = System.Drawing.SystemColors.Menu;
            this.Display1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display1.Location = new System.Drawing.Point(18, 77);
            this.Display1.Name = "Display1";
            this.Display1.ReadOnly = true;
            this.Display1.Size = new System.Drawing.Size(427, 36);
            this.Display1.TabIndex = 0;
            this.Display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Event_Keypress);
            // 
            // Display_panel
            // 
            this.Display_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Display_panel.Controls.Add(this.Display2);
            this.Display_panel.Controls.Add(this.Display1);
            this.Display_panel.Location = new System.Drawing.Point(12, 28);
            this.Display_panel.Name = "Display_panel";
            this.Display_panel.Size = new System.Drawing.Size(458, 130);
            this.Display_panel.TabIndex = 1;
            // 
            // Display2
            // 
            this.Display2.BackColor = System.Drawing.SystemColors.Menu;
            this.Display2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Display2.Location = new System.Drawing.Point(18, 12);
            this.Display2.Name = "Display2";
            this.Display2.ReadOnly = true;
            this.Display2.Size = new System.Drawing.Size(427, 36);
            this.Display2.TabIndex = 1;
            this.Display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number_panel
            // 
            this.Number_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number_panel.Controls.Add(this.btnClearCE);
            this.Number_panel.Controls.Add(this.Equal);
            this.Number_panel.Controls.Add(this.devide);
            this.Number_panel.Controls.Add(this.add);
            this.Number_panel.Controls.Add(this.rem);
            this.Number_panel.Controls.Add(this.plus);
            this.Number_panel.Controls.Add(this.btnclear);
            this.Number_panel.Controls.Add(this.btndot);
            this.Number_panel.Controls.Add(this.btn0);
            this.Number_panel.Controls.Add(this.btn9);
            this.Number_panel.Controls.Add(this.btn8);
            this.Number_panel.Controls.Add(this.btn7);
            this.Number_panel.Controls.Add(this.btn6);
            this.Number_panel.Controls.Add(this.btn5);
            this.Number_panel.Controls.Add(this.btn4);
            this.Number_panel.Controls.Add(this.btn3);
            this.Number_panel.Controls.Add(this.btn2);
            this.Number_panel.Controls.Add(this.btn1);
            this.Number_panel.Location = new System.Drawing.Point(12, 148);
            this.Number_panel.Name = "Number_panel";
            this.Number_panel.Size = new System.Drawing.Size(458, 593);
            this.Number_panel.TabIndex = 2;
            // 
            // btnClearCE
            // 
            this.btnClearCE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClearCE.Location = new System.Drawing.Point(23, 453);
            this.btnClearCE.Name = "btnClearCE";
            this.btnClearCE.Size = new System.Drawing.Size(96, 96);
            this.btnClearCE.TabIndex = 17;
            this.btnClearCE.Text = "CE";
            this.btnClearCE.UseVisualStyleBackColor = false;
            this.btnClearCE.Click += new System.EventHandler(this.ClearController);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Equal.Location = new System.Drawing.Point(125, 456);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(300, 96);
            this.Equal.TabIndex = 16;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.OperationContoller);
            // 
            // devide
            // 
            this.devide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.devide.Location = new System.Drawing.Point(329, 354);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(96, 96);
            this.devide.TabIndex = 15;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = false;
            this.devide.Click += new System.EventHandler(this.OperationContoller);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.add.Location = new System.Drawing.Point(329, 45);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 96);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.OperationContoller);
            // 
            // rem
            // 
            this.rem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rem.Location = new System.Drawing.Point(329, 147);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(96, 96);
            this.rem.TabIndex = 13;
            this.rem.Text = "-";
            this.rem.UseVisualStyleBackColor = false;
            this.rem.Click += new System.EventHandler(this.OperationContoller);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plus.Location = new System.Drawing.Point(329, 249);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(96, 96);
            this.plus.TabIndex = 12;
            this.plus.Text = "*";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperationContoller);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclear.Location = new System.Drawing.Point(23, 351);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(96, 96);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.ClearController);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndot.Location = new System.Drawing.Point(227, 354);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(96, 96);
            this.btndot.TabIndex = 10;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = false;
            this.btndot.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.Location = new System.Drawing.Point(125, 354);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(96, 96);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.Location = new System.Drawing.Point(227, 45);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(96, 96);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.Location = new System.Drawing.Point(125, 45);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(96, 96);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.Location = new System.Drawing.Point(23, 45);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(96, 96);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.Location = new System.Drawing.Point(227, 147);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(96, 96);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.Location = new System.Drawing.Point(125, 147);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(96, 96);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.Location = new System.Drawing.Point(23, 147);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(96, 96);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.Location = new System.Drawing.Point(227, 249);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(96, 96);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.Location = new System.Drawing.Point(125, 249);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(96, 96);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.Location = new System.Drawing.Point(23, 249);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(96, 96);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumberController);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.Number_panel);
            this.Controls.Add(this.Display_panel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Display_panel.ResumeLayout(false);
            this.Display_panel.PerformLayout();
            this.Number_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Display1;
        private Panel Display_panel;
        private TextBox Display2;
        private Panel Number_panel;
        private Button Equal;
        private Button devide;
        private Button add;
        private Button rem;
        private Button plus;
        private Button btnclear;
        private Button btndot;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnClearCE;
    }
}