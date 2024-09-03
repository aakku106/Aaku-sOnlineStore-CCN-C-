using OnlineShopingStore.db;
using OnlineShopingStore.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.controller
{
    public class login
    {
     

        public void Login() {

            Console.WriteLine("Welcome to Online Shopping Store");
            // ??
            Console.WriteLine("Are you new user<yes/not>");
            string checkNewUser =  Console.ReadLine();
            if(checkNewUser.ToUpper() == "YES" || checkNewUser.ToUpper()== "Y")
            {
                register();
            }
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
                       
            do
            {
                switch (choice)
                {

                    case 1:
                        logIn();

                        break;
                    case 2:
                        Console.WriteLine("Aarigatto dattebyoo!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");

                        break;
                }
            } while ( choice != 3);

        }

        public void calling()
        {
            calling c = new calling();
            c.welcomeMessage();
            //logIn();


            Console.ReadLine();
        }

        public void register()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            int rePassCounter = 0;
            string password = "";
            if (rePassCounter > 3)
            {
                Console.WriteLine("You have exceeded the maximum number of attempts");
                Environment.Exit(0);
            }
            else
            {
            a:
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                Console.WriteLine("Conform your password");
                string password1 = Console.ReadLine();
                if (password != password1)
                {
                    Console.WriteLine("Password not matched");
                    rePassCounter++;
                    goto a;
                }
            }
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();
            userList.users.Add(new user
            {
                Id = userList.users.Count + 1,
                Name = name,
                Email = email,
                Password = password,
                Address = address
            });
        }
        int countiNoTimeOfLoginno = 0;
        public void logIn()
        {
            int countemail = 0;
            if (countiNoTimeOfLoginno > 1)
            {
                Login();
            }
            Console.WriteLine("Enter your email");
            string email1 = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string passwordMatch = Console.ReadLine();

            var user = userList.users.Where(y => y.Email == email1 && y.Password == passwordMatch).FirstOrDefault();
            if (user != null)
            {
                Console.WriteLine("Login success");
                ++ countiNoTimeOfLoginno;
               
                calling();
            }
            else
            {
                Console.WriteLine("Login failed");
                countemail ++;
                if (countemail > 3)
                {
                    Console.WriteLine("You have exceeded the maximum number of attempts");
                    Environment.Exit(0);
                }
            }
        }


    }
}
