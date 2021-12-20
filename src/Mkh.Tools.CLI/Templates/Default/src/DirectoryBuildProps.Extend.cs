using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src;

public partial class DirectoryBuildProps : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, "src");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "Directory.Build.props");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}