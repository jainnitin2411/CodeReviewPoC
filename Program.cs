using System;

using System.Threading.Tasks;

using System.Data.SqlClient;

namespace dotnet_core_hello_world

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter your username:");

            string username = Console.ReadLine();

            Console.WriteLine("Enter your password:");

            string password = Console.ReadLine();

            // Vulnerable SQL Query

            string connectionString = "your_connection_string_here No anirban";

            string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {

                    Console.WriteLine("Login successful!");

                }

                else

                {

                    Console.WriteLine("Invalid username or password.");

                }

                reader.Close();

            }

            LogMsg();

        }

        private async static Task LogMsg()

        {

            Console.WriteLine("Hello Nitin Jain. How are you? What");

        }

    }

}

