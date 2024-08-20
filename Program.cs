using System;
using System.Threading.Tasks;

namespace dotnet_core_hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogMsg();
        }

        private async static Task LogMsg()
        {
            Console.WriteLine("Hello Nitin..!");
        }
    }
}
