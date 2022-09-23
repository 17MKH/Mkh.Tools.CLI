using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.build;

public partial class BaseConfigTs : ITemplateHandler
{
    private GenerateModel _model;
    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/build");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "base.config.ts");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}