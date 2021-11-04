using ConsoleApp11.Enxception;
using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {


            string usernameStr;
            int password;

            do
            {
                Console.WriteLine("UserName daxil edin:");
                usernameStr = Console.ReadLine();

            } while (!int.TryParse(usernameStr, out password));



            UserName username1 = new UserName();
            try
            {
                username1.password = password;

                Console.WriteLine("Password  daxil edin: ");
                username1.Password = Console.ReadLine();
            }
            catch (InvalidUserNameException e)
            {
                Console.WriteLine(e.Message);
            }
            
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen bir xeta bas verdi!");
            }

        }
    }
}
