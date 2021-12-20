using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.Core.Infrastructure;

public partial class ModuleServicesConfigurator : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, "src/Core/Infrastructure");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "ModuleServicesConfigurator.cs");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}