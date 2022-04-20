using System.Reflection;
using Mkh.Tools.CLI.NPM;
using Mkh.Tools.CLI.NuGet;
using Spectre.Console;

namespace Mkh.Tools.CLI;

public class GenerateEngineAbstract : IGenerateEngine
{
    public string Name { get; }

    protected GenerateEngineAbstract(string name)
    {
        Name = name;
    }

    public virtual bool Build(GenerateModel model)
    {
        if (Directory.Exists(model.CodeDir))
        {
            AnsiConsole.MarkupLine("[red]代码目录 [yellow]{0[/] 已存在，请手动移除后再创建。[/]",model.CodeDir);
            return false;
        }

        model.NuGetPackageVersions = new NuGetHelper().GetVersions();
        model.NPMPackageVersions = new NPMHelper().GetVersions();

        if (!Directory.Exists(model.CodeDir))
            Directory.CreateDirectory(model.CodeDir);

        var handlerTypeList = Assembly.GetExecutingAssembly().GetTypes().Where(t =>
            typeof(ITemplateHandler) != t && typeof(ITemplateHandler).IsAssignableFrom(t)).ToList();

        foreach (var type in handlerTypeList)
        {
            var instance = (ITemplateHandler)Activator.CreateInstance(type);
            instance!.Save(model);
        }

        return true;
    }
}