using Mkh.Tools.CLI.NPM;
using Mkh.Tools.CLI.NuGet;

namespace Mkh.Tools.CLI;

/// <summary>
/// 生成模型
/// </summary>
public class GenerateModel
{
    /// <summary>
    /// 代码目录
    /// </summary>
    public string CodeDir { get; set; }

    /// <summary>
    /// 模块信息
    /// </summary>
    public Module Module { get; set; }

    /// <summary>
    /// 公司单位
    /// </summary>
    public string Company { get; set; }

    /// <summary>
    /// 版权声明
    /// </summary>
    public string Copyright { get; set; }

    /// <summary>
    /// 模板类型
    /// </summary>
    public TemplateType TemplateType { get; set; }

    /// <summary>
    /// NuGet包最新版本号
    /// </summary>
    public NuGetPackageVersions NuGetPackageVersions { get; set; }

    /// <summary>
    /// NPM包最新版本号
    /// </summary>
    public NPMPackageVersions NPMPackageVersions { get; set; }
}

public class Module
{
    /// <summary>
    /// 编号
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 编码
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remarks { get; set; }
}