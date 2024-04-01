namespace MB.API.Models
{
    public class ModelValidationException : Exception
    {
        public ModelValidationException(string message) : base(message)
        {
        }

        public ModelValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
