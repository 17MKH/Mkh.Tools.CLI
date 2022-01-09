using McMaster.Extensions.CommandLineUtils;

namespace Mkh.Tools.CLI.Commands
{
    [Command("mkh", Description = "欢迎使用17MKH官方脚手架")]
    [Subcommand(typeof(NewCommand))]
    public class MkhCommand
    {
        private void OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
        }
    }
}
