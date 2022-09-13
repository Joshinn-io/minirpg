using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.MiniRPG
{
    public class Game
    {
        public Game() 
        {
            Console.Clear();

            //Create a UIManager to display UI's
            //Display Main Menu with options.

            //Persistent data saving for profiles

            //Chunk based map formatting
            //Display area around with ASCII

            Profile profile = new Profile();
            profile.Characters = new List<Player>();
            profile.Password = "123";
            profile.Username = "Username";


            profile.Save();
        }
    }
}
