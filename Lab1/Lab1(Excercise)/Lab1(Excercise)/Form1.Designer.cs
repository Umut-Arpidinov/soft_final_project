namespace Lab1_Excercise_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.ResultOfOperation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(67, 114);
            this.firstNumber.Multiline = true;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(558, 59);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Второе число";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(67, 278);
            this.secondNumber.Multiline = true;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(558, 59);
            this.secondNumber.TabIndex = 3;
            this.secondNumber.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(67, 384);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 94);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(223, 384);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 94);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(388, 384);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(78, 94);
            this.multiply.TabIndex = 6;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.button3_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(547, 384);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(78, 94);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.button4_Click);
            // 
            // ResultOfOperation
            // 
            this.ResultOfOperation.Location = new System.Drawing.Point(67, 555);
            this.ResultOfOperation.Multiline = true;
            this.ResultOfOperation.Name = "ResultOfOperation";
            this.ResultOfOperation.Size = new System.Drawing.Size(558, 59);
            this.ResultOfOperation.TabIndex = 8;
            this.ResultOfOperation.Tag = "result";
            this.ResultOfOperation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.ResultOfOperation);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.TextBox ResultOfOperation;
    }
}

