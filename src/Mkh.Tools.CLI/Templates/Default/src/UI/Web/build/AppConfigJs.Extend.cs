using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.build;

public partial class AppConfigJs : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/build");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "app.config.js");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}