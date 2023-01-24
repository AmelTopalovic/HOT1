using System.ComponentModel.DataAnnotations;

namespace DistanceConverter.Models
{


    public class DistanceConverterModel
    {
        public const double CM_PER_IN = 2.54;

        [Required(ErrorMessage = "You must enter inches to convert.")]
        [Range(1, 500, ErrorMessage = "Value must be between 1 and 500.")]
        public double? DistanceInInches { get; set; }

        public double? DistanceInCentimeters
        {
            get
            {
                return DistanceInInches * CM_PER_IN;

            }
        }
        
        public string? ConvertedString {
			get
			{
				return $"{DistanceInInches} inches is {DistanceInCentimeters:f2} centimeters.";
			}
            
		}
	}

}
