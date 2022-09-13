using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.MiniRPG
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Player> Characters { get; set; }
        public Profile() {}

        public bool Save()
        {
            StreamWriter sw = new StreamWriter("Data/Profiles/" + Id + ".json");
            sw.Write(JsonConvert.SerializeObject(this));
            sw.Close();

            return true;
        }
    }
}
