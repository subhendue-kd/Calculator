namespace calculator
{
    partial class Form1
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
            txtTotal = new TextBox();
            bnt1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnadd = new Button();
            btnsub = new Button();
            btnmul = new Button();
            btndiv = new Button();
            btnequal = new Button();
            btnclear = new Button();
            btndecimal = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.BackColor = SystemColors.GradientInactiveCaption;
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(362, 70);
            txtTotal.TabIndex = 0;
            // 
            // bnt1
            // 
            bnt1.BackColor = SystemColors.MenuText;
            bnt1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            bnt1.ForeColor = SystemColors.GradientInactiveCaption;
            bnt1.Location = new Point(12, 113);
            bnt1.Name = "bnt1";
            bnt1.Size = new Size(65, 50);
            bnt1.TabIndex = 1;
            bnt1.Text = "1";
            bnt1.UseVisualStyleBackColor = false;
            bnt1.Click += bnt1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.MenuText;
            btn2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.GradientInactiveCaption;
            btn2.Location = new Point(83, 113);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 50);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.MenuText;
            btn3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.GradientInactiveCaption;
            btn3.Location = new Point(154, 113);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.MenuText;
            btn4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.GradientInactiveCaption;
            btn4.Location = new Point(12, 169);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 50);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.MenuText;
            btn5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.GradientInactiveCaption;
            btn5.Location = new Point(83, 169);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 50);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.MenuText;
            btn6.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.GradientInactiveCaption;
            btn6.Location = new Point(154, 169);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 50);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.MenuText;
            btn7.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.GradientInactiveCaption;
            btn7.Location = new Point(12, 225);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 50);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.MenuText;
            btn8.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.GradientInactiveCaption;
            btn8.Location = new Point(83, 225);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 50);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.MenuText;
            btn9.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.GradientInactiveCaption;
            btn9.Location = new Point(154, 225);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 50);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.MenuText;
            btn0.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.GradientInactiveCaption;
            btn0.Location = new Point(12, 281);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 50);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.MenuText;
            btnadd.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btnadd.ForeColor = SystemColors.GradientInactiveCaption;
            btnadd.Location = new Point(225, 113);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(65, 50);
            btnadd.TabIndex = 11;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnsub
            // 
            btnsub.BackColor = SystemColors.MenuText;
            btnsub.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btnsub.ForeColor = SystemColors.GradientInactiveCaption;
            btnsub.Location = new Point(225, 169);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(65, 50);
            btnsub.TabIndex = 10;
            btnsub.Text = "_";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += btnsub_Click;
            // 
            // btnmul
            // 
            btnmul.BackColor = SystemColors.MenuText;
            btnmul.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btnmul.ForeColor = SystemColors.GradientInactiveCaption;
            btnmul.Location = new Point(225, 225);
            btnmul.Name = "btnmul";
            btnmul.Size = new Size(65, 50);
            btnmul.TabIndex = 15;
            btnmul.Text = "*";
            btnmul.UseVisualStyleBackColor = false;
            btnmul.Click += btnmul_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = SystemColors.MenuText;
            btndiv.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btndiv.ForeColor = SystemColors.GradientInactiveCaption;
            btndiv.Location = new Point(225, 281);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(65, 50);
            btndiv.TabIndex = 14;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // btnequal
            // 
            btnequal.BackColor = SystemColors.MenuText;
            btnequal.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btnequal.ForeColor = SystemColors.GradientInactiveCaption;
            btnequal.Location = new Point(296, 169);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(65, 50);
            btnequal.TabIndex = 16;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = false;
            btnequal.Click += btnequal_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.MenuText;
            btnclear.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.GradientInactiveCaption;
            btnclear.Location = new Point(154, 281);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(65, 50);
            btnclear.TabIndex = 17;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btndecimal
            // 
            btndecimal.BackColor = SystemColors.MenuText;
            btndecimal.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btndecimal.ForeColor = SystemColors.GradientInactiveCaption;
            btndecimal.Location = new Point(83, 281);
            btndecimal.Name = "btndecimal";
            btndecimal.Size = new Size(65, 50);
            btndecimal.TabIndex = 18;
            btndecimal.Text = ".";
            btndecimal.UseVisualStyleBackColor = false;
            btndecimal.Click += btndecimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(425, 399);
            Controls.Add(btndecimal);
            Controls.Add(btnclear);
            Controls.Add(btnequal);
            Controls.Add(btnmul);
            Controls.Add(btndiv);
            Controls.Add(btn0);
            Controls.Add(btnadd);
            Controls.Add(btnsub);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(bnt1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button bnt1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnadd;
        private Button btnsub;
        private Button btnmul;
        private Button btndiv;
        private Button btnequal;
        private Button btnclear;
        private Button btndecimal;
    }
}
