namespace IbrahKit_CLI.Exceptions
{
    /// <summary>
    /// Thrown during the Command.Parse method 
    /// </summary>
    public class ArgumentParsingException : Exception
    {
        public ArgumentParsingException()
        {
        }

        public ArgumentParsingException(string? message) : base(message)
        {
        }
    }
}
