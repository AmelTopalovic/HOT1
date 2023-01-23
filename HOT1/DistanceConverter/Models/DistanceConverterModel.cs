using System.ComponentModel.DataAnnotations;

namespace DistanceConverter.Models
{

   
    public class DistanceConverterModel  
    {
        public const decimal CM_PER_IN = 2.54m;

        [Required(ErrorMessage = "You must enter inches to convert.")]
        [Range(1, 500.00, ErrorMessage = "Value must be between 1 and 500." )]
        public decimal? DistanceInInches { get; set; }

        public decimal? DistanceInCentimeter { get; set; }

        public string? CalcToCM()
        {
            decimal? calculatedCM = DistanceInInches * CM_PER_IN;
            return $"{DistanceInInches} inches is {calculatedCM} in centimeters";
        }
    }
}
