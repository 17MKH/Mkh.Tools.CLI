using McMaster.Extensions.CommandLineUtils;

namespace Mkh.Tools.CLI
{
    public static class PromptHelper
    {
        public static string GetStringWithRequired(string prompt)
        {
            string str = null;
            var b = true;
            while (b)
            {
                str = Prompt.GetString(prompt, promptColor: ConsoleColor.Red);
                b = str.IsNull();
            }

            return str;
        }
        public static int GetIntWithRequired(string prompt, int min, int max)
        {
            int i = 0;
            var b = true;
            while (b)
            {
                i = Prompt.GetInt(prompt, promptColor: ConsoleColor.Red);
                b = i < min || i > max;
            }

            return i;
        }
    }
}
