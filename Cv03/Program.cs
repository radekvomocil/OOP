using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = new double[,] { { 2, 4, 2 }, { 4, 9, 8 }, { 3, 1, 0 } };
            double[,] mat2 = new double[,] { { 1, 5, 5 }, { 3, 4, 5 }, { 5, 6, 5 } };

            Matrix matrix1 = new Matrix(mat1);
            Matrix matrix2 = new Matrix(mat2);

            Console.WriteLine("Count:");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine("Difference:");
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine("Multiplication:");
            Console.WriteLine(matrix1 * matrix2);
            Console.WriteLine("Equal:");
            Console.WriteLine(matrix1 == matrix2);
            Console.WriteLine("");

            Console.WriteLine("Not equal:");
            Console.WriteLine(matrix1 != matrix2);
            Console.WriteLine("");

            Console.WriteLine("Determinant of 1. matrix:");
            Console.WriteLine(matrix1.Determinant());
            Console.WriteLine("Determinant of 2. matrix:");
            Console.WriteLine(matrix2.Determinant());
            Console.ReadLine();
        }
    }
}
