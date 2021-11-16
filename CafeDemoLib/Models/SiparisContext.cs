using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace CafeDemoLib.Models
{
    public static class SiparisContext
    {
        private static string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Siparisler/db.json";
        public static List<SiparisDetay> Siparisler { get; set; } = new List<SiparisDetay>();
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
                    Siparisler = JsonConvert.DeserializeObject<List<SiparisDetay>>(dosyaIcerigi);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
        public static void Save()
        {
            try
            {
                FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(JsonConvert.SerializeObject(Siparisler, Formatting.Indented));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
