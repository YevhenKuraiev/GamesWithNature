using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public static class AlgorithmSevidge
    {
        public static List<double> ToSolve(double[,] matrix)
        {
            List<double> arrayMaxValue = FindMaxValue.InColumns(matrix);
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, i] = arrayMaxValue[counter] - matrix[j, i];
                    
                }
                counter++;
            }
            List<double> arrayResultMaxValue = FindMaxValue.InRows(matrix);
            arrayResultMaxValue.Add(arrayResultMaxValue.Min());
            double index = arrayResultMaxValue.IndexOf(arrayResultMaxValue.Min());
            arrayResultMaxValue.Add(++index);
            return arrayResultMaxValue;
        }
    }
}
