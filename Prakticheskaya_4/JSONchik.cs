using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prakticheskaya_4
{
    internal class JSONchik
    {
        public static void mySerialize<T>(T notebook)
        {
            string PathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json";
            string json = JsonConvert.SerializeObject(notebook);
            File.WriteAllText(PathToDesktop, json);
        }
        public static T myDeserialize<T>()
        {
            string PathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json";
            string json = File.ReadAllText(PathToDesktop);
            T notebookdeser = JsonConvert.DeserializeObject<T>(json);
            return notebookdeser;
        }
    }
}
