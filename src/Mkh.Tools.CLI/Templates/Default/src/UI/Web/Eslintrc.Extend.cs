﻿using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.UI.Web;

public partial class Eslintrc : ITemplateHandler
{
    public void Save(GenerateModel model)
    {
        var dir = Path.Combine(model.CodeDir, $"src/UI/{model.Module.Code.ToLower()}-web");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, ".eslintrc");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}