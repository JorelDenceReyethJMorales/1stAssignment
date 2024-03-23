using System.ComponentModel.Design;

namespace _1stAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";
            string password = "Admin1234";
            int Attempts = 3;

            while (Attempts >= 1)
            {
                Console.Write("Username : ");
                string x = Console.ReadLine();

                Console.Write("Password : ");
                string y = Console.ReadLine();

                if (x == username && y == password) break;
                else 
                {
                    Attempts--;
                    Console.WriteLine("Incorrect Credentials"); 
                    Console.WriteLine();
                    
                    if (Attempts >= 1)
                    {
                        Console.WriteLine(Attempts + " more try");
                        Console.WriteLine();
                    } 
                }
            } 
                if (Attempts >= 1) 
                {
                    Console.WriteLine("Login Successfully");
                }
                else 
                {
                    Console.WriteLine("Maximum Attempt");
                } 
        }
    }
}
