namespace Mkh.Tools.CLI;

/// <summary>
/// 代码生成引擎接口
/// </summary>
public interface IGenerateEngine
{
    /// <summary>
    /// 生成
    /// </summary>
    /// <param name="model">生成信息</param>
    bool Build(GenerateModel model);
}