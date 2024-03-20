using System.Text.RegularExpressions;

namespace CarouselView.Core.Validation.Rules
{
    public class IsValidZipRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null) return false;

            var onlyNumbers = Regex.IsMatch(value.ToString(), "^[0-9]*$");
            return onlyNumbers && value.ToString().Length == 5;
        }
    }
}