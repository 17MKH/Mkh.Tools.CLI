using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web.src.locales.zh_cn
{
    public partial class Index : ITemplateHandler
    {
        public void Save(GenerateModel model)
        {
            var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web/src/locales/zh-cn");
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var content = TransformText();
            var filePath = Path.Combine(dir, "index.js");
            File.WriteAllText(filePath, content, Encoding.UTF8);
        }
    }
}
