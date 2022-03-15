using System.ComponentModel.DataAnnotations;
using CreatingCustomValidationAttributes.CustomValidationAttributes;

namespace CreatingCustomValidationAttributes.Data.Models;

public class CurrencyConversionModel {
    [Required(ErrorMessage = "This field is required")]
    [StringLength(maximumLength: 15, MinimumLength = 1, ErrorMessage = "Cannot be longer than 15 characters")]
    [CurrencyCode("USD", "EUR", "RUB", "GBP")]
    public string ConvertFrom { get; set; }


    [Required(ErrorMessage = "This field is required")]
    [StringLength(maximumLength: 15, MinimumLength = 1, ErrorMessage = "Cannot be longer than 15 characters")]
    [CurrencyCode("USD", "EUR", "RUB", "GBP")]
    public string ConvertTo { get; set; }

    public override string ToString() {
        return new string($"Convert From: {ConvertFrom}; Convert To: {ConvertTo}");
    }
}
