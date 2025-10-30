namespace IbrahKit_CLI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CLI cli = new();
            cli.Run(args);
        }
    }
}
