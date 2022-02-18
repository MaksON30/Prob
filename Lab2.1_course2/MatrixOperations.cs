using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1_course2
{
    partial class MyMatrix
    {
        private double[,] GetTransponedArray() 
        {
            double[,] transponedMatrix = new double [_matrix.GetLength(1), _matrix.GetLength(0)];
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                for (int j = 0; j < _matrix.GetLength(0); j++)
                {
                    transponedMatrix[i, j] = _matrix[j, i];
                }
            }
            return transponedMatrix;
        }

        public MyMatrix GetTransponedCopy()
        {
            var transMatrix = GetTransponedArray();

            MyMatrix transponsedCopyMatrix = new MyMatrix(transMatrix);
            return transponsedCopyMatrix;
        }

        public void TransponeMe()
        {
            _matrix = GetTransponedArray();
        }
    }

}

