using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public static class BayesAlgorithm
    {
        public static List<double> ToSolve(double[,] matrix, List<double> probabilities)
        {
            List<double> result = new List<double>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double temp = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   temp += matrix[i, j] * probabilities[j];
                }
                result.Add(Math.Round(temp, 1));
            }
            int index = result.IndexOf(result.Max());
            result.Add(result.Max());
            result.Add(++index);

            return result;
        }
    }
}
