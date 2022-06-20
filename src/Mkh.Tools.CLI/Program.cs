using System.CommandLine;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Mkh.Tools.CLI;
using Mkh.Tools.CLI.Resources;
using Mkh.Tools.CLI.Spectre;
using Mkh.Tools.CLI.Templates.Default;
using Spectre.Console;

var currentCultureName = CultureInfo.CurrentCulture.Name.ToLower();

//多语言资源文件
var rm = new ResourceManager("Mkh.Tools.CLI.Resources.Language" + (currentCultureName.StartsWith("zh") ? "" : ".enUS"), Assembly.GetExecutingAssembly());
ResourceManagerHelper.ResourceManager = rm;

//根命令
var rootCommand = new RootCommand(rm.GetString("Description")!);

//创建模块命令
var newCommand = new Command("new", rm.GetString("NewCommandDescription"));
newCommand.SetHandler(() =>
{
    AnsiConsoleHelper.WriteBanner($"[yellow]{rm.GetString("CreateModule")}[/]");

    var model = new GenerateModel
    {
        Module = new Mkh.Tools.CLI.Module
        {
            Name = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputModuleName")),
            Code = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputModuleCode")),
            No = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<int>("PleaseInputModuleNo").PromptStyle(AnsiConsoleHelper.ThemeColorRgb).Validate(no =>
            {
                return no switch
                {
                    < 0 => ValidationResult.Error($"[red]{rm.GetString("ModuleNoCantLessThan")}[/]"),
                    >= 55000 => ValidationResult.Error($"[red]{rm.GetString("ModuleNoCantGreaterThan")}[/]"),
                    _ => ValidationResult.Success(),
                };
            })),
            Icon = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputModuleIcon").AllowEmpty()),
            Remarks = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputModuleRemarks").AllowEmpty())
        },
        Company = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputCompany").AllowEmpty()),
        Copyright = AnsiConsole.Prompt(AnsiConsoleHelper.CreateTextPrompt<string>("PleaseInputCopyright").AllowEmpty()),
        TemplateType = TemplateType.Default,
        JwtKey = new StringHelper().GenerateRandom(16)
    };



    IGenerateEngine generateEngine;
    switch (model.TemplateType)
    {
        default:
            generateEngine = new DefaultCodeGenerateEngine();
            break;
    }

    model.CodeDir = Path.Combine(Directory.GetCurrentDirectory(), $"Mkh.Mod.{model.Module.Code}");

    if (generateEngine.Build(model))
    {
        AnsiConsoleHelper.WriteLine($"[yellow]{rm.GetString("CreateModuleSuccess")}[/]");

        AnsiConsole.MarkupLine("[{0}]{1}[/]", AnsiConsoleHelper.ThemeColorRgb, rm.GetString("ChangeTheWord")!);
    }
});

//创建皮肤命令
var newSkinCommand = new Command("skin", rm.GetString("NewSkinCommandDescription"));
newSkinCommand.SetHandler(() =>
{
    AnsiConsoleHelper.WriteLine("[yellow]敬请期待~[/]");
});

newCommand.AddCommand(newSkinCommand);
rootCommand.AddCommand(newCommand);

return rootCommand.InvokeAsync(args).Result;
