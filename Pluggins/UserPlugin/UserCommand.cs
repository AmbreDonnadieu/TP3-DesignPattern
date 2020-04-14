using PluginBase;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UserPlugin
{
    public class UserCommand : ICommand
    {
        public string Name { get => "User"; }
        public string Description { get => "Displays User message."; }

        public int Execute()
        {
            Console.WriteLine("User !!!");

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