using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPatrones2025.Singleton
{
    public class ConfigurationManager
    {
        public Dictionary<string,string> keyValuePairs = new Dictionary<string, string>();


        public void Set(string key, string value)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                keyValuePairs[key] = value;
            }
            else
            {
                keyValuePairs.Add(key, value);
            }
        }

        public string get(string key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                return keyValuePairs[key];
            }
            else
            {
                return null;
            }
        }








    }
}
