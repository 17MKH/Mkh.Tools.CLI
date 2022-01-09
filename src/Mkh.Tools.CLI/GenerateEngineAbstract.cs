using System.Reflection;

namespace Mkh.Tools.CLI;

public class GenerateEngineAbstract : IGenerateEngine
{
    public string Name { get; }

    protected GenerateEngineAbstract(string name)
    {
        Name = name;
    }

    public virtual void Build(GenerateModel model)
    {
        if (Directory.Exists(model.CodeDir))
        {
            Console.WriteLine($"代码目录({model.CodeDir})已存在，请手动移除后再创建。");
            return;
        }

        if (!Directory.Exists(model.CodeDir))
            Directory.CreateDirectory(model.CodeDir);

        var handlerTypeList = Assembly.GetExecutingAssembly().GetTypes().Where(t =>
            typeof(ITemplateHandler) != t && typeof(ITemplateHandler).IsAssignableFrom(t)).ToList();

        foreach (var type in handlerTypeList)
        {
            var instance = (ITemplateHandler)Activator.CreateInstance(type);
            instance!.Save(model);
        }
    }
}