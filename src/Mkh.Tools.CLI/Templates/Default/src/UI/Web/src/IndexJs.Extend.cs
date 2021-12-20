using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src;

public partial class IndexJs : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "index.js");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}