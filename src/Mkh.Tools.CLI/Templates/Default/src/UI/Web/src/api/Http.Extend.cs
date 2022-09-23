using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src.api;

public partial class Http : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src/api");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "http.ts");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}