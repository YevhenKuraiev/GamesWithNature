using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_with_nature.Models
{
    public class OnVariant
    {
        public double[,] matrix = new double[,] {{-1, 1, 1, 4 }, {-1, -2, 2, 3 }, {3, -1, 3, 2 }};

        public List<double> probabilities = new List<double>() { 0.2, 0.4, 0.1, 0.3 };

        public double y = 0.3;
    }
}