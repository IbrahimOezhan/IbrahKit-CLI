namespace IbrahKit_CLI.Exceptions
{
    public class CommandExecutionException : Exception
    {
        public CommandExecutionException()
        {
        }

        public CommandExecutionException(string? message) : base(message)
        {
        }
    }
}
