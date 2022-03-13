using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_ind
{
    class Model
    {
        private int r;
        private double[,] a;
        private double[,] b;
        private double[,] rez;
        private double mA;
        private double mB;

        public int razmerMat {
            get { return r; }
            set { if (value > 0) r = value; }
        }
        public double[,] matrixA {
            get {return a;}
            set {a = value;} 
        }
        public double[,] matrixB
        {
            get { return b; }
            set { b = value; }
        }
        public double[,] matrixRez
        {
            get { return rez; }
            set { rez = value; }
        }
        public double multyA
        {
            get { return mA; }
            set { mA = value; }
        }
        public double multyB
        {
            get { return mB; }
            set { mB = value; }
        }
        

        public double SumElA()
        {
            double s = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    s += matrixA[i, j];
                }
            }
            return s;
        }

        public double SumElB()
        {
            double s = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    s += matrixB[i, j];
                }
            }
            return s;
        }

        public double[,] UmnNumA()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    matrixA[i, j] = matrixA[i, j] * multyA;
                }
            }
            return matrixA;
        }

        public double[,] UmnNumB()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    matrixB[i, j] = matrixB[i, j] * multyB;
                }
            }
            return matrixB;
        }

        public double[,] SumMat()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    matrixRez[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return matrixRez;
        }

        public double[,] SubMat()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    matrixRez[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            return matrixRez;
        }

        public double[,] UmnMat()
        {
            for (int i = 0; i < r; i++)
                for (int j = 0; j < r; j++)
                    for (int k = 0; k < r; k++)
                        matrixRez[i, j] += matrixA[i, k] * matrixB[k, j];

            return matrixRez;
        }
    }
}
