using System.ComponentModel.DataAnnotations;

namespace SmartphonesApi.Platform.Application.Smartphone.Commands
{
    public class AddSmartphoneCommand : IValidatableObject
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Storage { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Brand))
                yield return new ValidationResult(nameof(Brand), new[] { nameof(Name) });
        }
    }
}
