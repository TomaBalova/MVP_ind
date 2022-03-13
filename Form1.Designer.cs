
namespace MVP_ind
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.MatrixB = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButSum = new System.Windows.Forms.Button();
            this.ButDiff = new System.Windows.Forms.Button();
            this.ButMult = new System.Windows.Forms.Button();
            this.RezMatrix = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер матриц";
            // 
            // MatrixA
            // 
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.Location = new System.Drawing.Point(26, 92);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.RowHeadersWidth = 51;
            this.MatrixA.RowTemplate.Height = 24;
            this.MatrixA.Size = new System.Drawing.Size(260, 211);
            this.MatrixA.TabIndex = 2;
            // 
            // MatrixB
            // 
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.Location = new System.Drawing.Point(380, 92);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.RowHeadersWidth = 51;
            this.MatrixB.RowTemplate.Height = 24;
            this.MatrixB.Size = new System.Drawing.Size(260, 211);
            this.MatrixB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Матрица А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Матрица В";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сумма всех элементов матрицы А:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Умножить матрицу на:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Умножить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Умножить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Умножить матрицу на:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 359);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Сумма всех элементов матрицы В:";
            // 
            // ButSum
            // 
            this.ButSum.Location = new System.Drawing.Point(290, 129);
            this.ButSum.Name = "ButSum";
            this.ButSum.Size = new System.Drawing.Size(84, 47);
            this.ButSum.TabIndex = 14;
            this.ButSum.Text = "Сложить";
            this.ButSum.UseVisualStyleBackColor = true;
            // 
            // ButDiff
            // 
            this.ButDiff.Location = new System.Drawing.Point(290, 174);
            this.ButDiff.Name = "ButDiff";
            this.ButDiff.Size = new System.Drawing.Size(84, 47);
            this.ButDiff.TabIndex = 15;
            this.ButDiff.Text = "Вычесть";
            this.ButDiff.UseVisualStyleBackColor = true;
            // 
            // ButMult
            // 
            this.ButMult.Location = new System.Drawing.Point(290, 218);
            this.ButMult.Name = "ButMult";
            this.ButMult.Size = new System.Drawing.Size(84, 47);
            this.ButMult.TabIndex = 16;
            this.ButMult.Text = "Умножить";
            this.ButMult.UseVisualStyleBackColor = true;
            // 
            // RezMatrix
            // 
            this.RezMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezMatrix.Location = new System.Drawing.Point(679, 92);
            this.RezMatrix.Name = "RezMatrix";
            this.RezMatrix.RowHeadersWidth = 51;
            this.RezMatrix.RowTemplate.Height = 24;
            this.RezMatrix.Size = new System.Drawing.Size(260, 211);
            this.RezMatrix.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Матрица результата";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 28);
            this.button3.TabIndex = 19;
            this.button3.Text = "Вычислить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 28);
            this.button4.TabIndex = 20;
            this.button4.Text = "Вычислить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 552);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RezMatrix);
            this.Controls.Add(this.ButMult);
            this.Controls.Add(this.ButDiff);
            this.Controls.Add(this.ButSum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatrixB);
            this.Controls.Add(this.MatrixA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RezMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.DataGridView MatrixB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButSum;
        private System.Windows.Forms.Button ButDiff;
        private System.Windows.Forms.Button ButMult;
        private System.Windows.Forms.DataGridView RezMatrix;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

