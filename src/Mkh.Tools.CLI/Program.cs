using System.CommandLine;
using Spectre.Console;

//using McMaster.Extensions.CommandLineUtils;
//using Mkh.Tools.CLI.Commands;

//CommandLineApplication.Execute<MkhCommand>(args);

var rootCommand = new RootCommand
{
    Description = "17MKH CLI"
};

rootCommand.SetHandler(() =>
{
    AnsiConsole.Markup("[underline red]Hello[/] World!");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine(@" ***************************************************************************************************************");
    Console.WriteLine(@" *                                                                                                             *");
    Console.WriteLine(@" *                               $$\   $$$$$$$$\ $$\      $$\ $$\   $$\ $$\   $$\                              *");
    Console.WriteLine(@" *                             $$$$ |  \____$$  |$$$\    $$$ |$$ | $$  |$$ |  $$ |                             *");
    Console.WriteLine(@" *                             \_$$ |      $$  / $$$$\  $$$$ |$$ |$$  / $$ |  $$ |                             *");
    Console.WriteLine(@" *                               $$ |     $$  /  $$\$$\$$ $$ |$$$$$  /  $$$$$$$$ |                             *");
    Console.WriteLine(@" *                               $$ |    $$  /   $$ \$$$  $$ |$$  $$<   $$  __$$ |                             *");
    Console.WriteLine(@" *                               $$ |   $$  /    $$ |\$  /$$ |$$ |\$$\  $$ |  $$ |                             *");
    Console.WriteLine(@" *                             $$$$$$\ $$  /     $$ | \_/ $$ |$$ | \$$\ $$ |  $$ |                             *");
    Console.WriteLine(@" *                             \______|\__/      \__|     \__|\__|  \__|\__|  \__|                             *");
    Console.WriteLine(@" *                                                                                                             *");
    Console.WriteLine(@" *                                                                                                             *");
    Console.Write(@" *                                             ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(@"欢迎使用 17MKH CLI~");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@"                                             *");
    Console.WriteLine(@" *                                                                                                             *");
    Console.WriteLine(@" *                                                                                                             *");
    Console.WriteLine(@" ***************************************************************************************************************");
    Console.WriteLine();

});

// Parse the incoming args and invoke the handler
return rootCommand.Invoke(args);
