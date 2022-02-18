using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1_course2
{
    partial class MyMatrix
    {
        public int Height 
        { 
            get 
            {
                return _matrix.GetLength(0);
            } 
        }
        public int Width 
        { 
            get 
            {
                return _matrix.GetLength(1);
            } 
        }

        public int getHeight()
        {
            return _matrix.GetLength(0);
        }

        public int getWeight()
        {
            return _matrix.GetLength(0);
        }


        public MyMatrix(MyMatrix myMatrix)
        {

            _matrix = new double[myMatrix._matrix.GetLength(0), myMatrix._matrix.GetLength(1)];
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = myMatrix._matrix[i, j];
                }
            }
        }
        public MyMatrix(double[,] matrix)
        {
            _matrix = matrix;
        }

        public MyMatrix(double[][] zArr) 
        {
            for (int i = 0; i < zArr.GetLength(0); i++)
            {
                var columnLength = zArr[i].Length;
                    if (columnLength != zArr.GetLength(0))
                    {
                    throw new Exception("array don`t rectangle"); 
                    }
            }
                for (int i = 0; i < zArr.Length; i++)
                {
                    for (int j = 0; j < _matrix.Length; j++)
                        _matrix[i, j] = zArr[i][j];
                }
            
        }

            public MyMatrix(string[] numberArray)
            {
                foreach (var item in numberArray)
                {
                    var numbers = item.Split();

                    foreach (var item2 in numbers)
                    {
                        var nuber = double.Parse(item2);
                    }
                }
            }
        

        public static MyMatrix operator * (MyMatrix matrix1, MyMatrix matrix2) 
        {
            if (matrix1._matrix.GetLength(0) == matrix2._matrix.GetLength(1))
            {
                double[,] matrix = new double[matrix1.getHeight(), matrix2.getWeight()];
                for (int i = 0; i < matrix1._matrix.Length; i++)
                {
                    for (int j = 0; j < matrix1._matrix.Length; j++)
                    {
                        for (int k = 0; k < matrix2._matrix.Length; k++)
                        {
                            matrix[i, j] += matrix1._matrix[i, k] * matrix2._matrix[k, j];
                        }
                    }
                }
                MyMatrix resaultMatrix = new MyMatrix(matrix);
                return resaultMatrix;
            }
            throw new ArgumentException();
        }

        public static MyMatrix operator + (MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1._matrix.GetLength(0) == matrix2._matrix.GetLength(0) && matrix1._matrix.GetLength(1) == matrix2._matrix.GetLength(1))
            {
                double[,] resault = new double[matrix1._matrix.GetLength(0) /*rows*/, matrix2._matrix.GetLength(1)/*columns*/];

                for (int i = 0; i < matrix1._matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2._matrix.GetLength(1); j++)
                    {
                        resault[i, j] = matrix1._matrix[i, j] + matrix2._matrix[i, j];
                    }

                }
                return new MyMatrix(resault);
            }
            throw new ArgumentException();

        }

        public double this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }
            set
            {
                _matrix[i, j] = value;
            }
        }

        public double getElement(int i, int j)
        {
            return _matrix[i, j];
        }

        public void setElement(int i, int j, double value)
        {
            _matrix[i, j] = value;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    
                    sb.Append($"{_matrix[i, j]}\t ");
                    
                }
                sb.Append("\n");
            }
           
            return sb.ToString();
        }
    }
}
