using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public static class MaximeCriterion
    {
        public static List<double> ToSolve(double[,] matrix)
        {
            List<double> arrayMinValue = FindMaxValue.InRows(matrix);
            arrayMinValue.Add(arrayMinValue.Max());
            int index = arrayMinValue.IndexOf(arrayMinValue.Max());
            arrayMinValue.Add(++index);
            return arrayMinValue;
        }
    }
}
