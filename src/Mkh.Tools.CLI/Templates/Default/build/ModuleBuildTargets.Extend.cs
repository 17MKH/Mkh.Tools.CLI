using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.build;

public partial class ModuleBuildTargets : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, "build");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();

        var filePath = Path.Combine(dir, "module.build.targets");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}