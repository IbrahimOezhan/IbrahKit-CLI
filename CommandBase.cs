using IbrahKit_CLI.Params;
using System.Text;

namespace IbrahKit_CLI
{
    public abstract class CommandBase
    {
        public const string ARG_PROCESS_SUCCES = "";

        /// <summary>
        /// Executes the command
        /// </summary>
        /// <exception cref="CommandExecutionException">Throws if execution failed</exception>
        /// <returns>A string that gets printed to the console</returns>
        public abstract string Execute();

        /// <summary>
        /// Parses the incomming parameter
        /// </summary>
        /// <returns>Returns an empty value if succcessful else it returns a non empty value </returns>
        public abstract string Parse();

        /// <summary>
        /// Returns command data
        /// </summary>
        /// <returns>Returns name, description and a list of arguments that the command has</returns>
        public abstract (string name, string desc, List<Param> args) GetData();

        /// <summary>
        /// Uses reflection to get the types of all commands
        /// </summary>
        /// <returns>The types of all commands</returns>
        public static IEnumerable<Type> GetAllCommands()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(x => x.IsSubclassOf(typeof(CommandBase)) && !x.IsAbstract);
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("Command: " + GetData().name);
            sb.AppendLine($"\tDescription: {GetData().desc}");
            sb.AppendLine($"\t\tParameters:");

            foreach (var arg in GetData().args)
            {
                sb.AppendLine($"\t\t\t{arg.ToString()}, ");
            }

            sb.AppendLine();

            return sb.ToString();
        }
    }
}
