using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CarouselView.Core.Validation
{
    public sealed class ValidatableObject<T> : IValidatable<T>
    {
        public IList<IValidationRule<T>> Validations { get; } = new List<IValidationRule<T>>();

        public IEnumerable<string> Errors { get; set; }

        public T Value { get; set; }

        public bool IsValid { get; set; }

        public bool IsSecondPartOfPair { get; set; }

        public bool Validate()
        {
            IsValid = !IsValid;

            Errors = Validations.Where(v => !v.Check(Value))
                .Select(v => v.ValidationMessage);

            IsValid = !Errors.Any();

            return IsValid;
        }

        public override string ToString()
        {
            return $"{Value}";
        }

#pragma warning disable 67
        public event PropertyChangedEventHandler PropertyChanged;
    }
}