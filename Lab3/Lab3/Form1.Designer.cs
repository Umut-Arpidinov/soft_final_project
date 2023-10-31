namespace Lab3
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
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.thirdNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getFirstResult = new System.Windows.Forms.Button();
            this.textFirstResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.getPercentagerResult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.percentageResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(64, 72);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(264, 31);
            this.firstNum.TabIndex = 0;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(419, 72);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(264, 31);
            this.secondNum.TabIndex = 1;
            this.secondNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // thirdNum
            // 
            this.thirdNum.Location = new System.Drawing.Point(795, 72);
            this.thirdNum.Name = "thirdNum";
            this.thirdNum.Size = new System.Drawing.Size(245, 31);
            this.thirdNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(689, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = ")";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(736, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(349, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            // 
            // getFirstResult
            // 
            this.getFirstResult.Location = new System.Drawing.Point(356, 150);
            this.getFirstResult.Name = "getFirstResult";
            this.getFirstResult.Size = new System.Drawing.Size(353, 51);
            this.getFirstResult.TabIndex = 7;
            this.getFirstResult.Text = "Get result";
            this.getFirstResult.UseVisualStyleBackColor = true;
            this.getFirstResult.Click += new System.EventHandler(this.getFirstResult_Click);
            // 
            // textFirstResult
            // 
            this.textFirstResult.Location = new System.Drawing.Point(397, 248);
            this.textFirstResult.Name = "textFirstResult";
            this.textFirstResult.Size = new System.Drawing.Size(264, 31);
            this.textFirstResult.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(233, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(277, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 298);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "take a percentage of the result obtained";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(40, 171);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 35);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "50";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 35);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 35);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // getPercentagerResult
            // 
            this.getPercentagerResult.Location = new System.Drawing.Point(356, 665);
            this.getPercentagerResult.Name = "getPercentagerResult";
            this.getPercentagerResult.Size = new System.Drawing.Size(353, 51);
            this.getPercentagerResult.TabIndex = 13;
            this.getPercentagerResult.Text = "Get result";
            this.getPercentagerResult.UseVisualStyleBackColor = true;
            this.getPercentagerResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(281, 801);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Result";
            // 
            // percentageResult
            // 
            this.percentageResult.Location = new System.Drawing.Point(432, 801);
            this.percentageResult.Name = "percentageResult";
            this.percentageResult.Size = new System.Drawing.Size(264, 31);
            this.percentageResult.TabIndex = 14;
            this.percentageResult.TextChanged += new System.EventHandler(this.percentageResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 996);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentageResult);
            this.Controls.Add(this.getPercentagerResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textFirstResult);
            this.Controls.Add(this.getFirstResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirdNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.TextBox thirdNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getFirstResult;
        private System.Windows.Forms.TextBox textFirstResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button getPercentagerResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox percentageResult;
    }
}

