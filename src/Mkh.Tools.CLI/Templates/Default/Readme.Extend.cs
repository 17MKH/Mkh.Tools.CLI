using System.Text;

namespace Mkh.Tools.CLI.Templates.Default;

public partial class Readme : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
            
        var content = TransformText();
        var dir = Path.Combine(model.CodeDir);
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        var filePath = Path.Combine(dir, "README.md");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}