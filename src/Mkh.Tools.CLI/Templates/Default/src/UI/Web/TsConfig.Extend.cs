using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web;

public partial class TsConfig : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "tsconfig.json");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}