using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.controller
{
    public class calling
    {
        int choice;

        public void welcomeMessage()
        {
            Console.WriteLine("Welcome to the CCN  Online Shopping Store Dattebyoo!!!");

            //choicee();
            processOptions();


        }


        public void processOptions()
        {
            
            do
            {
                choicee();
                switch (choice)
                {
                    case 0:
                        productList();
                        break;
                    case 1:
                        addProduct();
                        break;
                    case 2:
                        removeProduct();
                        break;
                    case 3:
                        updateProduct();
                        break;
                    case 4:
                        searchProduct();
                        break;
                    case 5:
                        addReview();
                        break;
                    case 6:
                        removeReview();
                        break;
                    case 7:
                        updateReview();
                        break;
                    case 8:
                        Console.WriteLine("Thank you for shopping with us");
                        Console.WriteLine("Do you want to continue shopping<yes/no>");
                        string choice = Console.ReadLine();
                        if (choice.ToUpper() == "YES" || choice.ToUpper() == "Y")
                        {
                            processOptions();
                        }
                        else
                        {
                            Console.WriteLine("Thank you for shopping with us");
                            login relogin = new login();
                            relogin.Login();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        
                        break;
                }
            } while (choice != 8);
        }

        public void productList()
        {
            Console.WriteLine("Product List");
        }

        public void addProduct()
        {
            Console.WriteLine("Product added");
        }
        public void removeProduct()
        {
            Console.WriteLine("Product removed");
        }
        public void updateProduct()
        {
            Console.WriteLine("Product updated");
        }
        public void searchProduct()
        {
            Console.WriteLine("Product searched");
        }
        public void addReview()
        {
            Console.WriteLine("Review added");
        }
        public void removeReview()
        {
            Console.WriteLine("Review removed");
        }
        public void updateReview()
        {
            Console.WriteLine("Review updated");
        }

        public int choicee()
        {
            Console.WriteLine($@"Enter your choice
            0. Print Options
            1. Add Product
            2. Remove Product
            3. Update Product
            4. Search Product
            5. Add Review
            6. Remove Review
            7. Update Review
            8. LogOut


");

             choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

    }
}
