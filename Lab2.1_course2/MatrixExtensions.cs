using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1_course2
{
    static class MatrixExtensions
    {
        public static double RowsCount(this int[,] matrix) //к-ть рядків
        {
            return matrix.GetLength(0);
        }

        public static double ColumnsCount(this int[,] matrix) //к-ть стовпців
        {
            return matrix.GetLength(1);
        }
    }
}
