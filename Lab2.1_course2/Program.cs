using System;

namespace Lab2._1_course2
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrix = GetMatrixFromConsole();

            MyMatrix matrix1 = new MyMatrix(matrix);
            MyMatrix matrix2 = new MyMatrix(matrix);

            Console.WriteLine(matrix1 * matrix2);

            MyMatrix matrixOperations = new MyMatrix(matrix);
            Console.WriteLine(matrixOperations);
            Console.WriteLine();
            matrixOperations.TransponeMe();
            Console.WriteLine(matrixOperations);

        }

        static double[,] GetMatrixFromConsole()
        {
            Console.Write("Кiлькiсть рядкiв матрицi ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв матрицi ");
            var m = int.Parse(Console.ReadLine());

            var matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }
    }
}
