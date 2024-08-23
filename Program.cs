using System;
using System.Threading.Tasks;

namespace dotnet_core_hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogMsg();
            string username = "admin"; // Hardcoded username
            string password = "password123"; // Hardcoded password

            if (username == "admin" && password == "password123")
            {
                Console.WriteLine("Welcome Admin!");
            }

        }

        private async static Task LogMsg()
        {
            Console.WriteLine("Hello Nitin Jain. How are you? !!!!!!Anirban!!!!");
        }
    }
}
