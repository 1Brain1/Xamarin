namespace CarouselView.Core.Validation
{
    public interface IValidationRule<in T>
    {
        string ValidationMessage { get; set; }

        bool Check(T value);
    }
}