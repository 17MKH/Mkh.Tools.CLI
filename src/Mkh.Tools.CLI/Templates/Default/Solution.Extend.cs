using System.Text;

namespace Mkh.Tools.CLI.Templates.Default;

public partial class Solution : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var content = TransformText();
        var dir = Path.Combine(model.CodeDir);
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        var filePath = Path.Combine(dir, "Mkh.Mod." + model.Module.Code + ".sln");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}