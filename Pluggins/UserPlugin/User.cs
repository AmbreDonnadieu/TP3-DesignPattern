using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PluginBase;

namespace UserPlugin
{
    class User : ICommand
    {
        public string Name {get =>"UserPlugin";}
        public string Description { get => "Get all user from a jsonfile into a list of user";}
        private string _Nom {get;set;}
        private string _Prenom{get;set;}
        private string _Email{get;set;}

        public User()
        {
            _Nom = "Nom";
            _Prenom = "Prenom";
            _Email = _Nom+"."+_Prenom+"@email.com"; 
        }

        public int Execute()
        {
            List<JObject> final = new List<JObject>();
            string pathAllJson = "./Users";
            string[] pathAllFile = Directory.GetFiles(pathAllJson,"*.json");
            foreach(string s in pathAllFile)
            {
                StreamReader file = File.OpenText(s);
                JsonTextReader reader = new JsonTextReader(file);
                final.Add(JToken.ReadFrom(reader) as JObject);
            }
            return 0;
        }
    }
}