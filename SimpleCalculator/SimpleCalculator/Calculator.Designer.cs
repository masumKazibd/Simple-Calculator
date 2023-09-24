namespace SimpleCalculator
{
    partial class Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirst = new TextBox();
            txt2nd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 20);
            label1.Name = "label1";
            label1.Size = new Size(315, 42);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 125);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 1;
            label2.Text = "First Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 173);
            label3.Name = "label3";
            label3.Size = new Size(174, 22);
            label3.TabIndex = 1;
            label3.Text = "Second Number : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 316);
            label4.Name = "label4";
            label4.Size = new Size(78, 22);
            label4.TabIndex = 1;
            label4.Text = "Result : ";
            // 
            // txtFirst
            // 
            txtFirst.BackColor = SystemColors.MenuBar;
            txtFirst.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirst.Location = new Point(201, 121);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(270, 31);
            txtFirst.TabIndex = 0;
            // 
            // txt2nd
            // 
            txt2nd.BackColor = SystemColors.Menu;
            txt2nd.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt2nd.Location = new Point(201, 169);
            txt2nd.Name = "txt2nd";
            txt2nd.Size = new Size(270, 31);
            txt2nd.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(204, 240);
            button1.Name = "button1";
            button1.Size = new Size(63, 30);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(273, 240);
            button2.Name = "button2";
            button2.Size = new Size(63, 30);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(342, 240);
            button3.Name = "button3";
            button3.Size = new Size(63, 30);
            button3.TabIndex = 4;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(408, 240);
            button4.Name = "button4";
            button4.Size = new Size(63, 30);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(204, 316);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 22);
            labelResult.TabIndex = 1;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(516, 359);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt2nd);
            Controls.Add(txtFirst);
            Controls.Add(labelResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFirst;
        private TextBox txt2nd;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label labelResult;
    }
}