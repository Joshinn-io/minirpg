using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRPG.MiniRPG.Utility
{
    public static class Log
    {
        public static void Debug(string message, int level)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < level; i++)
            {
                stringBuilder.Append("-");
            }

            Console.WriteLine("Debug " + stringBuilder.ToString() + ">>> " + message); 
        }

        public static void Error(string message)
        {
            Console.WriteLine("======= ERROR: " + message);
        }

        public static void Info(string message, int level)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < level; i++)
            {
                stringBuilder.Append("-");
            }

            Console.WriteLine("Log " + stringBuilder.ToString() + "> " + message);
        }
    }
}
