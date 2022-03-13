using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_ind
{
    public partial class Form1 : Form, IView
    {
        Presenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new Presenter(this);
        }

        public int razmer {
            set
            {
                textBox1.Text = value.ToString();
            }
            get
            {
                return Convert.ToInt32(textBox1.Text);
            }
        }
        double[,] matrixA, matrixB;
        public double[,] inputMatrixA {
            get {
                matrixA = new double[MatrixA.Rows.Count, MatrixA.Columns.Count];
                Random random = new Random();
                for (int i = 0; i < MatrixA.Rows.Count; i++)
                {
                    for (int j = 0; j < MatrixA.Columns.Count; j++)
                    {
                        matrixA[i, j] = random.Next(3);
                    }
                    Console.WriteLine();
                }
                return matrixA;
            }
        }
        public double[,] inputMatrixB {
            get
            {
                matrixB = new double[MatrixB.Rows.Count, MatrixB.Columns.Count];
                Random random = new Random();
                for (int i = 0; i < MatrixB.Rows.Count; i++)
                {
                    for (int j = 0; j < MatrixB.Columns.Count; j++)
                    {
                        matrixB[i, j] = random.Next(3);
                    }
                    Console.WriteLine();
                }
                return matrixB;
            }
        }
        /*double[,] inputMatrixRez { get; set; }
        double multA { get; set; }
        double multB { get; set; }*/
        public double sumA {
            get
            {
                return Convert.ToDouble(label4.Text);
            }
            set
            {
                label4.Text = Convert.ToString(value);
            }
        }

        public double sumB
        {
            get
            {
                return Convert.ToDouble(label7.Text);
            }
            set
            {
                label7.Text = Convert.ToString(value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            _presenter.RefreshViewSumElA();
            for (int i = 0; i < MatrixA.Rows.Count; i++)
            {
                for (int j = 0; j < MatrixA.Columns.Count; j++)
                {
                    MatrixA[i, j].Value =  matrixA[i, j];
                }
                Console.WriteLine();
            }
            label2.Text += "  " + razmer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _presenter.RefreshViewSumElB();
            for (int i = 0; i < MatrixB.Rows.Count; i++)
            {
                for (int j = 0; j < MatrixB.Columns.Count; j++)
                {
                    MatrixB[i, j].Value = matrixB[i, j];
                }
                Console.WriteLine();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MatrixA.RowCount = Convert.ToInt32(textBox1.Text);
            MatrixA.ColumnCount = Convert.ToInt32(textBox1.Text);
            MatrixB.RowCount = Convert.ToInt32(textBox1.Text);
            MatrixB.ColumnCount = Convert.ToInt32(textBox1.Text);
        }
    }
}
