using System.IO;
using Phonizer.Content;
using Phonizer.Helpers;
using Phonizer.Models;

namespace Phonizer.Services
{
    public static class SettingsService
    {
        public static void SaveSettings(DbSettings woCommerceDbSettings, DbSettings localDbSettings)
        {
            using (var fileStream = new FileStream(Configs.SettingsFileName, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine($"{Configs.LA}={localDbSettings.Address}");
                    streamWriter.WriteLine($"{Configs.LN}={localDbSettings.Name}");
                    streamWriter.WriteLine($"{Configs.WCA}={woCommerceDbSettings.Address}");
                    streamWriter.WriteLine($"{Configs.WCN}={woCommerceDbSettings.Name}");
                    streamWriter.WriteLine($"{Configs.WCL}={woCommerceDbSettings.Login}");
                    streamWriter.WriteLine($"{Configs.WCP}={woCommerceDbSettings.Password}");
                }
            }
        }

        public static DbSettings LoaLocalDbSettings()
        {
            var localDbSettings = new DbSettings();

            var lines = File.ReadAllLines(Configs.SettingsFileName);

            localDbSettings.Address = Pattern.FormatSetting(lines, Configs.LA);
            localDbSettings.Name = Pattern.FormatSetting(lines, Configs.LN);

            return localDbSettings;
        }

        public static DbSettings LoadWoCommerceDbSettings()
        {
            var woCommerceDbSettings = new DbSettings();

            var lines = File.ReadAllLines(Configs.SettingsFileName);

            woCommerceDbSettings.Address = Pattern.FormatSetting(lines, Configs.WCA);
            woCommerceDbSettings.Name = Pattern.FormatSetting(lines, Configs.WCN);
            woCommerceDbSettings.Login = Pattern.FormatSetting(lines, Configs.WCL);
            woCommerceDbSettings.Password = Pattern.FormatSetting(lines, Configs.WCP);          

            return woCommerceDbSettings;
        }
    }
}