using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFProject.Models;

namespace WPFProject.File
{
    public class Json
    {
        public static void JSONSerializationAdmin(ObservableCollection<Admin> admins)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter("DatabaseAdmin.json"))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, admins);
                }
            }
        }
        public static void JSONSerializationUser(ObservableCollection<User> users)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter("DatabaseUser.json"))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, users);
                }
            }
        }
        public static void JSONSerializationFilm(ObservableCollection<Film> films)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter("DatabaseFilm.json"))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, films);
                }
            }
        }
        public static void JSONDeSerializationAdmin(ObservableCollection<Admin> admins)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader("DatabaseAdmin.json"))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    admins = serializer.Deserialize<ObservableCollection<Admin>>(jsonTextReader);
                }
            }
        }
        public static void JSONDeSerializationUser(ObservableCollection<User> users)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader("DatabaseUser.json"))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    users = serializer.Deserialize<ObservableCollection<User>>(jsonTextReader);
                }
            }
        }
        public static void JSONDeSerializationFilm(ObservableCollection<Film> films)
        {
            var serializer = new JsonSerializer();

            using (StreamReader streamReader = new StreamReader("DatabaseFilm.json"))
            {
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    films = serializer.Deserialize<ObservableCollection<Film>>(jsonTextReader);
                }
            }
        }
    }
}
