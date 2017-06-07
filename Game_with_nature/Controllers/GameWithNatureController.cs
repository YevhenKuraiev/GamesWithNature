using ClassLibraryForGameWithNature;
using Game_with_nature.Models;
using Lab5_Games.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Game_with_nature.Controllers
{
    public class GameWithNatureController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormationMatrix(InputDataModel input)
        {
            if (ModelState.IsValid)
            {
                return View(input);
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Solution(InputDataModel input, List<double> elemMatrix, List<double> probability)
        {
            double numberProbability = 0;
            for (int i = 0; i < probability.Count; i++)
            {
                numberProbability += probability[i];
            }
            if (ModelState.IsValid && numberProbability == 1)
            {
                double[,] matrix = ListToDoubleArray(input, elemMatrix);
                ResultModel result = new ResultModel();
                result.resultAlgorithmValda = AlgorithmWald.ToSolve(matrix);
                result.resultMaximeCriterion = MaximeCriterion.ToSolve(matrix);
                result.resultLaplacesAlgorithm = Laplace_sAlgorithm.ToSolve(matrix);
                result.resultBayesAlgorithm = BayesAlgorithm.ToSolve(matrix, probability);
                result.resultAlgorithmHurwitz = AlgorithmHurwitz.ToSolve(input.y, matrix);
                result.resultAlgorithmSevidge = AlgorithmSevidge.ToSolve(matrix);
                return View(result);
            }
            return View("Error");
        }

        [HttpPost]
        public ActionResult SolutionOnVariant()
        {
            OnVariant variant = new OnVariant();
            ResultModel result = new ResultModel();
            result.resultAlgorithmValda = AlgorithmWald.ToSolve(variant.matrix);
            result.resultMaximeCriterion = MaximeCriterion.ToSolve(variant.matrix);
            result.resultLaplacesAlgorithm = Laplace_sAlgorithm.ToSolve(variant.matrix);
            result.resultBayesAlgorithm = BayesAlgorithm.ToSolve(variant.matrix, variant.probabilities);
            result.resultAlgorithmHurwitz = AlgorithmHurwitz.ToSolve(variant.y, variant.matrix);
            result.resultAlgorithmSevidge = AlgorithmSevidge.ToSolve(variant.matrix);

            return View("Solution", result);
        }


        private static double[,] ListToDoubleArray(InputDataModel input, List<double> elemMatrix)
        {
            double[,] matrix = new double[input.numberRows, input.numberColumns];
            int r = 0, c = 0;
            for (int i = 0; i < elemMatrix.Count(); i++)
            {
                if (c == input.numberColumns)
                {
                    r++;
                    c = 0;
                }
                matrix[r,c] = elemMatrix[i];
                c++;
            }
            return matrix;
        }
    }
}