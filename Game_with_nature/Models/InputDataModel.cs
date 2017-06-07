using System.ComponentModel.DataAnnotations;

namespace Lab5_Games.Models
{
    public class InputDataModel
    {
        [Display(Name = "Количество строк")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Range(typeof(int), "2", "10")]
        public int numberRows { get; set; }

        [Display(Name = "Количество столбцов")]
        [Range(typeof(int), "2", "10")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public int numberColumns { get; set; }

        [Display(Name = "Введите значение y: ")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public double y { get; set; }

        [Display(Name = "вероятность ")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public double probability { get; set; }

        [Display(Name = "элемент матрицы ")]
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public double elemMatrix { get; set; }
    }
}
