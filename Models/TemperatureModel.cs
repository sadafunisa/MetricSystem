using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "Fahrenheit value is required for conversion")]
        public double? FahrenheitValue { get; set; }

        public double? CelsiusValue { get; set; }

        public void ConvertToCelsius()
        {
            if (FahrenheitValue.HasValue)
            {
                CelsiusValue = (FahrenheitValue.Value - 32) * 5 / 9;
            }
        }
    }
}