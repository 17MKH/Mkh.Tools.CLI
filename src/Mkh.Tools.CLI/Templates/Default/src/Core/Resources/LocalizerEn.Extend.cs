using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.Core.Resources;

public partial class LocalizerEn : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;
        var dir = Path.Combine(_model.CodeDir, "src/Core/Resources");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();

        var filePath = Path.Combine(dir, $"Infrastructure.{_model.Module.Code.FirstCharToUpper()}Localizer.en.resx");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}