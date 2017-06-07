using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryForGameWithNature
{
    public static class FindMinValue
    {
        public static List<double> InRows(double[,] matrix)
        {
            List<double> minArray = new List<double>();
            //double[] minArray = new double[matrix.GetLength(0)];
            //int counter = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double min = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                    if (j == (matrix.GetLength(1) - 1))
                    {
                        //counter++;
                        //minArray[counter] = min;
                        minArray.Add(min);
                    }
                }
            }
            return minArray;
        }

        public static List<double> InColumns(double[,] matrix)
        {
            List<double> minArray = new List<double>();
            //double[] minArray = new double[matrix.GetLength(0)];
            //int counter = -1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double min = matrix[0, i];
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (min > matrix[j, i])
                    {
                        min = matrix[j, i];
                    }
                    if (j == (matrix.GetLength(0) - 1))
                    {
                        //counter++;
                        //minArray[counter] = min;
                        minArray.Add(min);
                    }
                }
            }
            return minArray;
        }
    }
}
