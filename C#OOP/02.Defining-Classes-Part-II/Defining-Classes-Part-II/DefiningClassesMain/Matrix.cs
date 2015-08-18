using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    // class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals)
    public class Matrix<T>
        where T : IComparable
    {
        //Fields
        private T[,] matrixValues;
        private int rows;
        private int columns;
        //Constructor
        public Matrix(int rows, int columns)
        {
            this.matrixValues = new T[rows, columns];
            this.rows = rows;
            this.columns = columns;
        }
        //Properties
        public int Rows
        {
            get { return this.rows; }
        }
        public int Columns
        {
            get { return this.columns; }
        }
        //Indexer
        // to access the inner matrix cells
        public T this[int row, int col]
        {
            get
            {
                if (row >= this.rows || row < 0 || col >= this.columns || col < 0)
                {
                    throw new System.IndexOutOfRangeException("index out of range");
                }
                return this.matrixValues[row, col];
            }
            set
            {
                if (row >= this.rows || row < 0 || col >= this.columns || col < 0)
                {
                    throw new System.IndexOutOfRangeException("index out of range");
                }
                this.matrixValues[row, col] = value; 
            }
        }
        //Implement the operator + (addition of matrices of the same size)
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if ((matrix1.rows != matrix2.rows) || (matrix1.columns != matrix2.columns))
            {
                throw new System.InvalidOperationException("Addition is not possible: sizes of matrices are different");
            }
            Matrix<T> result = new Matrix<T>(matrix1.rows, matrix2.columns);
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    dynamic value1 = matrix1[i, j];
                    dynamic value2 = matrix2[i, j];
                    dynamic currentValue = value1 + value2;
                    result[i, j] = currentValue;
                }
            }
            return result;
        }
        //Implement the operator - ( subtraction of matrices of the same size)
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if ((matrix1.rows != matrix2.rows) || (matrix1.columns != matrix2.columns))
            {
                throw new System.InvalidOperationException("Subtraction is not possible: sizes of matrices are different");
            }
            Matrix<T> result = new Matrix<T>(matrix1.rows, matrix2.columns);
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    dynamic value1 = matrix1[i, j];
                    dynamic value2 = matrix2[i, j];
                    dynamic currentValue = value1 - value2;
                    result[i, j] = currentValue;
                }
            }
            return result;
        }
        //Implement the operator * for matrix multiplication
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.columns != matrix2.rows)
            {
                throw new System.InvalidOperationException("Multiplication is not possible: sizes of matrices are not suitable");
            }
            Matrix<T> result = new Matrix<T>(matrix1.rows, matrix2.columns);
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.columns; j++)
                {
                    for (int k = 0; k < matrix1.columns; k++)
                    {
                        dynamic value1 = matrix1[i, k];
                        dynamic value2 = matrix2[k, j];
                        dynamic currentValue = value1 * value2;
                        result[i, j] += currentValue;
                    }
                }
            }
            return result;
        }
        //Implement the true operator (check for non-zero elements)
        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.columns == 0)
            {
                return false;
            }
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    if (!matrix[i, j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Implement the false operator (check for non-zero elements)
        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.rows == 0 || matrix.columns == 0)
            {
                return true;
            }
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    if (!matrix[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // ToString()
        public override string ToString()
        {
            if (this.matrixValues == null || this.rows == 0 || this.columns == 0)
            {
                throw new NullReferenceException("Object is not initialized");
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    sb.Append(this.matrixValues[i, j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
