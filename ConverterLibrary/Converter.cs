using Newtonsoft.Json;

namespace ConverterLibrary
{
    public class Converter
    {
        private static readonly string PathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Тест.json";
        public static void MySerialize<T>(T obj)
        {
            if (!File.Exists(PathToDesktop))
            {
                using (File.Create(PathToDesktop)) { }
            }
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(PathToDesktop, json);
        }

        public static T MyDeserialize<T>()
        {
            if (!File.Exists(PathToDesktop))
            {
                using (File.Create(PathToDesktop)) { }
            }
            string json = File.ReadAllText(PathToDesktop);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }
    }
}
