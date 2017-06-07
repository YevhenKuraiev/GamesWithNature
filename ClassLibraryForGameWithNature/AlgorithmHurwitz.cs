using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public static class AlgorithmHurwitz
    {
        public static List<double> ToSolve(double y, double[,] matrix)
        {
            List<double> arrayMinValue = FindMinValue.InRows(matrix);
            List<double> arrayMaxValue = FindMaxValue.InRows(matrix);
            List<double> result = new List<double>();

            for (int i = 0; i < arrayMinValue.Count; i++)
            {
                double resultS = y * arrayMinValue[i] + (1 - y) * arrayMaxValue[i];
                result.Add(resultS);
            }

            double index = result.IndexOf(result.Max());
            result.Add(result.Max());
            result.Add(++index);
            return result;
        }
    }
}
