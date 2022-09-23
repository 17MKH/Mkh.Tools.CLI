using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src.locales.lang.zh_cn;

public partial class Routes : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src/locales/lang/zh-cn");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "routes.ts");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}