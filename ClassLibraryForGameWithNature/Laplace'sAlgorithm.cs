using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryForGameWithNature
{
    public class Laplace_sAlgorithm
    {
        public static List<double> ToSolve(double[,] matrix)
        {
            double p = (double)1 / matrix.GetLength(1);
            List<double> result = new List<double>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double temp = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i, j] * p;
                }
                result.Add(temp);
            }
            int index = result.IndexOf(result.Max());
            result.Add(result.Max());
            result.Add(++index);

            return result;
        }
    }
}
