using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.Core;

public partial class Csproj : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(_model.CodeDir, "src/Core");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var domainDir = Path.Combine(dir, "Domain");
        if (!Directory.Exists(domainDir))
            Directory.CreateDirectory(domainDir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "Core.csproj");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}