namespace IbrahKit_CLI.Commands
{
    internal class HelpContext : Context
    {
        private string commandName = string.Empty;

        public void SetCommandName(string value) { commandName = value; }

        public string GetCommandName() => commandName;
    }
}
