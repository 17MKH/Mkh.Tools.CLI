using System.Resources;
using Mkh.Tools.CLI.Resources;
using Spectre.Console;

namespace Mkh.Tools.CLI.Spectre
{
    internal class AnsiConsoleHelper
    {
        public static readonly Color ThemeColor = new(103, 194, 58);
        public static readonly string ThemeColorRgb = "rgb(103,194,58)";
        /// <summary>
        /// 打印Banner
        /// </summary>
        public static void WriteBanner(string title = "")
        {
            WriteLine();

            AnsiConsole.Write(
                new FigletText("17MKH")
                    .LeftAligned()
                    .Color(ThemeColor));

            AnsiConsole.MarkupLine($"{ResourceManagerHelper.ResourceManager.GetString("Welcome")}", ThemeColorRgb);

            AnsiConsole.WriteLine();

            WriteLine(title);
        }

        public static void WriteLine(string title = "")
        {
            var rule = new Rule
            {
                Style = Style.Parse($"{ThemeColorRgb}"),
                Alignment = Justify.Left
            };
            if (title.NotNull())
            {
                rule.Title = title;
            }
            AnsiConsole.Write(rule);
        }

        public static TextPrompt<T> CreateTextPrompt<T>(string prompt)
        {
            return new TextPrompt<T>($"{ResourceManagerHelper.ResourceManager.GetString(prompt)}：").PromptStyle(AnsiConsoleHelper.ThemeColorRgb);
        }
    }
}
