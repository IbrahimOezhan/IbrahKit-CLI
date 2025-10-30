using IbrahKit_CLI.Exceptions;

namespace IbrahKit_CLI.Params
{
    /// <summary>
    /// An extension of param. Provides an additional check if there is another incomming value in the args array 
    /// </summary>
    public class Argument : Param
    {
        public Argument(Func<string[], string> function, string description, params string[] names) : base(function, description, names)
        {

        }

        public override string Pass<T, S>(string[] args, Context cont)
        {
            return Pass<S, T>(args, cont, 2);
        }

        public override string Process(string[] args)
        {
            if (args.Length == 1)
            {
                throw new ArgumentParsingException($"No value for {args[0]} parameter provided");
            }

            return base.Process(args);
        }
    }
}
