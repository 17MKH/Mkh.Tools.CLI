using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src.options;

public partial class LocaleEn : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src/options");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "locale.en.ts");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}