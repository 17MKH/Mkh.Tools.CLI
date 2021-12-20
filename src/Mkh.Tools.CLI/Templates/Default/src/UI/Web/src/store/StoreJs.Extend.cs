using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src.store;

public partial class StoreJs : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src/store");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "index.js");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}