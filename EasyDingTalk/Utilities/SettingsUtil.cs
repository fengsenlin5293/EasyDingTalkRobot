using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.Runtime.InteropServices.JavaScript;

namespace EasyDingTalk.Utilities
{
    internal static class SettingsUtil
    {
        public static string CreateUrlFromJsonFile(string settingsJsonFilePath)
        {
            if (!File.Exists(settingsJsonFilePath))
            {
                throw new Exception($"file '{settingsJsonFilePath}' not exist.");
            }

            var settings = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(settingsJsonFilePath));
            var host = settings["host"].ToString();
            var access_token = settings["access_token"].ToString();
            var url = $"{host}?access_token={access_token}";
            return url;
        }

        public static dynamic GetSettingFromJsonFile(string settingsJsonFilePath)
        {
            if (!File.Exists(settingsJsonFilePath))
            {
                throw new Exception($"file '{settingsJsonFilePath}' not exist.");
            }
            dynamic json = new ExpandoObject();
            var settings = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(settingsJsonFilePath));
            json.host = settings["host"].ToString();
            json.access_token = settings["access_token"].ToString();
            json.secret = settings["secret"].ToString();
            return json;
        }

        public static string ResolvePath(string path)
        {
            var assemblyPath = Path.GetDirectoryName(typeof(SettingsUtil).Assembly.Location);

            return Path.Combine(assemblyPath, path);
        }
    }
}
