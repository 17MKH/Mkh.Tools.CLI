using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.Web._modules;

public partial class ModuleJson : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, $"src/Web/_modules/{_model.Module.No + 6220}_{_model.Module.Code}");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "_module.json");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}