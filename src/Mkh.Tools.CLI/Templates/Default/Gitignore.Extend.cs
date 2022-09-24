using System.Text;

namespace Mkh.Tools.CLI.Templates.Default;

public partial class Gitignore : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
        var content = TransformText();
        var filePath = Path.Combine(model.CodeDir, ".gitignore");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}