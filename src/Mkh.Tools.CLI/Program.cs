using Mkh.Tools.CLI.NPM;
using Mkh.Tools.CLI.NuGet;
using Mkh.Tools.CLI.Templates.Default;

namespace Mkh.Tools.CLI;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            var cmd = args[0];
            switch (cmd)
            {
                case "new":
                    CreateModule();
                    return;
                case "-v":
                    WriteVersion();
                    return;
                case "-h":
                    WriteUsage();
                    return;
            }
        }

        CreateModule();
    }

    /// <summary>
    /// 输出用法
    /// </summary>
    static void WriteUsage()
    {
        Console.WriteLine("用法说明:");
        Console.WriteLine("mkh new       : 创建模块");
        Console.WriteLine("mkh -h        : 查看帮助");
        Console.WriteLine("mkh -v        : 查看版本号");
    }

    /// <summary>
    /// 输出版本号
    /// </summary>
    static void WriteVersion()
    {
        Console.WriteLine("当前版本号：" + typeof(Program).Assembly.GetName().Version);
    }

    /// <summary>
    /// 创建模块
    /// </summary>
    static void CreateModule()
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"您正在使用17MKH CLI({typeof(Program).Assembly.GetName().Version})创建模块!");

        var model = new GenerateModel
        {
            Module = new Module()
        };

        var b = true;
        while (b)
        {
            Console.Write("请输入模块名称：");
            Console.ForegroundColor = ConsoleColor.Red;
            model.Module.Name = Console.ReadLine();

            b = string.IsNullOrWhiteSpace(model.Module.Name);
        }

        b = true;
        while (b)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("请输入模块编码：");
            Console.ForegroundColor = ConsoleColor.Red;
            model.Module.Code = Console.ReadLine();

            b = string.IsNullOrWhiteSpace(model.Module.Code);
        }

        b = true;
        while (b)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("请输入模块编号(0-55000)：");
            Console.ForegroundColor = ConsoleColor.Red;
            model.Module.No = int.Parse(Console.ReadLine() ?? "0");

            b = model.Module.No < 0 || model.Module.No > 55000;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("请输入模块图标：");
        Console.ForegroundColor = ConsoleColor.Red;
        model.Module.Icon = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("请输入模块备注：");
        Console.ForegroundColor = ConsoleColor.Red;
        model.Module.Remarks = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("请输入公司单位：");
        Console.ForegroundColor = ConsoleColor.Red;
        model.Company = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("请输入版权声明：");
        Console.ForegroundColor = ConsoleColor.Red;
        model.Copyright = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("请输入Nexus私服地址：");
        Console.ForegroundColor = ConsoleColor.Red;
        model.NexusRepositoryUrl = Console.ReadLine();

        model.TemplateType = TemplateType.Default;

        model.NuGetPackageVersions = new NuGetHelper().GetVersions();
        model.NPMPackageVersions = new NPMHelper().GetVersions();

        IGenerateEngine generateEngine;
        switch (model.TemplateType)
        {
            default:
                generateEngine = new DefaultCodeGenerateEngine();
                break;
        }

        model.CodeDir = Path.Combine(Directory.GetCurrentDirectory(), $"Mkh.Mod.{model.Module.Code}");

        generateEngine.Build(model);

        Console.WriteLine("正在生成代码，请耐心等待...");

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("模块创建成功");
    }
}