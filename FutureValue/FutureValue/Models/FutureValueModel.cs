using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter a monthly investment amount.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amount must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a yearly interest rate.")]
        [Range(0, 10, ErrorMessage = "Yearly investment rate must be between 0 and 10.")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter how many years.")]
        [Range(1, 50, ErrorMessage = "Years must be between 1 and 50.")]
        public int? Years { get; set; }
        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
    }
}
