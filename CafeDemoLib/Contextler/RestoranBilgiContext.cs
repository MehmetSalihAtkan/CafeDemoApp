using CafeDemoLib.Sınıflar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDemoLib.Contextler
{
    public class RestoranBilgiContext
    {
        private static string _path =
                 Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CafeDemo/RestoranBilgi.json";
        public static List<RestoranBilgi> RestoranBilgiler { get; set; } = new List<RestoranBilgi>();
        public static void Load()
        {
            if (File.Exists(_path))
            {
                try
                {
                    FileStream fileStream = new FileStream(_path, FileMode.Open);
                    StreamReader reader = new StreamReader(fileStream);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    RestoranBilgiler = JsonConvert.DeserializeObject<List<RestoranBilgi>>(dosyaIcerigi);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CafeDemo");
            }
        }
        public static void Save()
        {
            try
            {
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(RestoranBilgiler, Formatting.Indented));
                writer.Close();
                writer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
