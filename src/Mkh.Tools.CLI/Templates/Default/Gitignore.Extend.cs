using System.Text;

namespace Mkh.Tools.CLI.Templates.Default;

public partial class Gitignore : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var content = TransformText();
        var filePath = Path.Combine(model.CodeDir, ".gitignore");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}