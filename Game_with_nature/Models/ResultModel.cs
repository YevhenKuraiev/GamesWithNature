using System.Collections.Generic;

namespace Game_with_nature.Models
{
    public class ResultModel
    {
        public List<double> resultAlgorithmValda { get; set; }

        public List<double> resultAlgorithmHurwitz { get; set; }

        public List<double> resultAlgorithmSevidge { get; set; }

        public List<double> resultMaximeCriterion { get; set; }

        public List<double> resultBayesAlgorithm { get; set; }

        public List<double> resultLaplacesAlgorithm { get; set; }
    }
}