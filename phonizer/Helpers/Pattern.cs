using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonizer.Helpers
{
    public static class Pattern
    {
        public static string FormatPhone(string phonePattern)
        {
            var index = phonePattern.IndexOf("\n", StringComparison.Ordinal);
            if (phonePattern.Length > 0 && index > 0)
            {
                phonePattern = phonePattern.Substring(0, index);
            }

            phonePattern = phonePattern.Replace("+7", "8");
            phonePattern = phonePattern.Remove(0, 1);

            return phonePattern;
        }

        public static string FormatSetting(IEnumerable<string> settingLines, string settingName)
        {
            return settingLines.LastOrDefault(l => l.StartsWith(settingName))
                ?.Replace(settingName, string.Empty).Trim(' ').TrimStart('=').TrimStart(' ');
        }
    }
}