using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CreatingCustomValidationAttributes.CustomValidationAttributes;

public class CurrencyCodeAttribute : ValidationAttribute {
    private readonly string[] _allowedCurrencyCodes;
    public CurrencyCodeAttribute(params string[] allowedCurrencyCodes) {
        _allowedCurrencyCodes = allowedCurrencyCodes;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) {
        var code = value as string;
        if(code is null || !_allowedCurrencyCodes.Contains(value)){
            return new ValidationResult("Not a valid Currency");
        }

        return ValidationResult.Success;
    }
}
