using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Mkh.Tools.CLI.NPM;

/// <summary>
/// NPM帮助类
/// </summary>
public class NPMHelper
{
    private const string QueryUrl = "https://www.npmjs.com/package/{0}";
    private readonly Dictionary<string, PropertyInfo> _infos = new();
    private readonly HttpClient _client;
    private NPMPackageVersions _versions;
    private DateTime _lastSearchTime = DateTime.Now;

    public NPMHelper()
    {
        ServicePointManager.ServerCertificateValidationCallback += (_, _, _, _) => true;

        _client = new HttpClient();
        var properties = typeof(NPMPackageVersions).GetProperties();
        foreach (var propertyInfo in properties)
        {
            var name = $"mkh-{propertyInfo.Name.ToLower().Replace("_", "-")}";
            _infos.Add(name, propertyInfo);
        }
    }

    /// <summary>
    /// 获取最新包版本信息
    /// </summary>
    /// <returns></returns>
    public NPMPackageVersions GetVersions()
    {
        //加个缓存机制，2小时
        if (_lastSearchTime.AddHours(2) > DateTime.Now && _versions != null)
            return _versions;

        Console.WriteLine("正在获取最新的NPM依赖包版本号，请稍后...");

        _versions = new NPMPackageVersions();
        var tasks = new Dictionary<PropertyInfo, Task<string>>();
        foreach (var info in _infos)
        {
            tasks.Add(info.Value, GetVersion(info.Key));
        }

        Task.WaitAll(tasks.Values.ToArray());

        foreach (var task in tasks)
        {
            task.Key.SetValue(_versions, task.Value.Result);
        }

        return _versions;
    }

    /// <summary>
    /// 查询指定包ID的最新版本号
    /// </summary>
    /// <param name="packageId"></param>
    /// <returns></returns>
    private async Task<string> GetVersion(string packageId)
    {
        var url = string.Format(QueryUrl, packageId);
        var jsonStr = await _client.GetStringAsync(url);
        if (!string.IsNullOrWhiteSpace(jsonStr))
        {
            var reg = new Regex("Latest version: ([^,]+),");

            var version = reg.Match(jsonStr).Groups[1].Value;

            Console.WriteLine($"获取到NPM包{packageId}版本号为：{version}");

            return version;
        }

        return "";
    }
}