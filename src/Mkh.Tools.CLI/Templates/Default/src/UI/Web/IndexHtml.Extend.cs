using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web;

public partial class IndexHtml : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, $"src/UI/{_model.Module.Code.ToLower()}-web");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "index.html");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}