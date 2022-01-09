using System.Text.Json;
using McMaster.Extensions.CommandLineUtils;
using Mkh.Tools.CLI.NPM;
using Mkh.Tools.CLI.NuGet;
using Mkh.Tools.CLI.Templates.Default;

namespace Mkh.Tools.CLI.Commands
{
    /// <summary>
    /// 创建模块命令
    /// </summary>
    [Command("new", Description = "create a new module")]
    public class NewCommand
    {
        private void OnExecute()
        {
            var model = new GenerateModel
            {
                Module = new Module
                {
                    Name = PromptHelper.GetStringWithRequired("请输入模块名称："),
                    Code = PromptHelper.GetStringWithRequired("请输入模块编码："),
                    No = PromptHelper.GetIntWithRequired("请输入模块编号(0-55000)：", 1, 55000),
                    Icon = Prompt.GetString("请输入模块图标：") ?? "",
                    Remarks = Prompt.GetString("请输入模块备注：") ?? ""
                },
                Company = Prompt.GetString("请输入公司单位：") ?? "",
                Copyright = Prompt.GetString("请输入版权声明：") ?? "",
                NexusRepositoryUrl = Prompt.GetString("请输入Nexus私服地址：") ?? "",
                TemplateType = TemplateType.Default,
                NuGetPackageVersions = new NuGetHelper().GetVersions(),
                NPMPackageVersions = new NPMHelper().GetVersions()
            };

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
}
