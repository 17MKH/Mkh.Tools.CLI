﻿using System.Text;

namespace Mkh.Tools.CLI.Templates.Default;

public partial class Dockerfile : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir);
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "Dockerfile");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}