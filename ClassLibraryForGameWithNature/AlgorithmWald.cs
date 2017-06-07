using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public class AlgorithmWald
    {
        public static List<double> ToSolve(double[,] matrix)
        {
            List<double> arrayMinValue = FindMinValue.InRows(matrix);
            int index = arrayMinValue.IndexOf(arrayMinValue.Max());
            arrayMinValue.Add(arrayMinValue.Max());
            arrayMinValue.Add(++index);
            return arrayMinValue;
        }
    }
}
