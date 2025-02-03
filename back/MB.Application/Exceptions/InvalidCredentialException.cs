namespace MB.Application.Exceptions
{
    public class InvalidCredentialException : Exception
    {
        public InvalidCredentialException() : base() { }

        public InvalidCredentialException(string message) : base(message) { }

        public InvalidCredentialException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}