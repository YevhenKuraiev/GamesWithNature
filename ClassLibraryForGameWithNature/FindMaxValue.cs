using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryForGameWithNature
{
    public static class FindMaxValue
    {
        public static List<double> InRows(double[,] matrix)
        {
            List<double> maxArray = new List<double>();
            //double[] minArray = new double[matrix.GetLength(0)];
            //int counter = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double max = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                    if (j == (matrix.GetLength(1) - 1))
                    {
                        //counter++;
                        //minArray[counter] = max;
                        maxArray.Add(max);
                    }
                }
            }
            return maxArray;
        }

        public static List<double> InColumns(double[,] matrix)
        {
            List<double> maxArray = new List<double>();
            //double[] minArray = new double[matrix.GetLength(0)];
            //int counter = -1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double max = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (max < matrix[j, i])
                    {
                        max = matrix[j, i];
                    }
                    if (j == (matrix.GetLength(0) - 1))
                    {
                        //counter++;
                        //minArray[counter] = max;
                        maxArray.Add(max);
                    }
                }
            }
            return maxArray;
        }
    }
}
