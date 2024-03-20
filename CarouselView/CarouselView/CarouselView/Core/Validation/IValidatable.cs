using System.Collections.Generic;
using System.ComponentModel;

namespace CarouselView.Core.Validation
{
    public interface IValidatable<T> : INotifyPropertyChanged
    {
        IList<IValidationRule<T>> Validations { get; }

        IEnumerable<string> Errors { get; set; }

        bool Validate();

        bool IsValid { get; set; }
    }
}