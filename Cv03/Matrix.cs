using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie3
{
    public class Matrix
    {
        double[,] matrix;
        public Matrix(double[,] matrix) {
            this.matrix = matrix;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            try { 
                var mtrx = new Matrix(
                    new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        mtrx.matrix[i,j]=a.matrix[i, j] + b.matrix[i, j];
                    }
                }
                return mtrx;
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
            //return a;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            try { 
                var mtx = new Matrix(
                       new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
                for (int i = 0; i < a.matrix.GetLength(1); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(0); j++)
                    {
                        mtx.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
                return mtx;
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
            //return a;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            try
            {
                var mtx = new Matrix(
                    new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
                var c = mtx.matrix;
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.matrix.GetLength(1); k++) // OR k<b.GetLength(0)
                            c[i, j] = c[i, j] + a.matrix[i, k] * b.matrix[k, j];
                    }
                }
                mtx.matrix = c;
                return mtx;
            }
            catch (Exception)
            {
                throw new InvalidOperationException();
            }
           // return a;
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            try
            {
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        if (a.matrix[i, j] != b.matrix[i, j]) return false;
                    }
                }
            }
            catch {
                return false;
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            try
            {
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        if (a.matrix[i, j] == b.matrix[i, j]) return false;
                    }
                }
            }
            catch {
                return false;
            }
            return true;
        }
        public static Matrix operator -(Matrix a)
        {
            var mtx = new Matrix(
                    new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
            for (int i = 0; i < a.matrix.GetLength(1); i++) {
                for (int j = 0; j < a.matrix.GetLength(0); j++)
                {
                    mtx.matrix[i, j] = a.matrix[i, j];
                }
            }
            return mtx;
        }

        public double Determinant()
        {

            
                if (matrix.GetLength(0) == matrix.GetLength(1) &&
                    matrix.GetLength(1) == 2)
                {
                    return matrix[0, 0];
                }
                else if (matrix.GetLength(0) == matrix.GetLength(1) &&
                        matrix.GetLength(1) == 2)
                {
                    return matrix[0, 0] * (matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

                }
                else if (matrix.GetLength(0) == matrix.GetLength(1) &&
                        matrix.GetLength(1) == 3)
                {
                    var determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                                      matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                                      matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

                    return determinant;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        
        public override string ToString() {
            string output="";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(j!= matrix.GetLength(0)) output += $"{matrix[i,j]} ";
                }
                output += Environment.NewLine;
            }
            return output;
        }
    }
}
