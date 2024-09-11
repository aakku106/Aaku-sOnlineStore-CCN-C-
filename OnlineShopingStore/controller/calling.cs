using OnlineShopingStore.db;
using OnlineShopingStore.model;
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
                        productListii();
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
                        showReview();
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

        public void productListii()
        {
            foreach (var product in productList.products)
            {
                //var review = product_review.product_reviews.FirstOrDefault(x => x.Id == product.Id);
                var review = (from p in product_review.product_reviews
                              where p.Id == product.Id
                              select p).FirstOrDefault();
                Console.WriteLine(
                    $"Id: {product.Id} " +
                    $"Name: {product.Name}" +
                    $" Price: {product.Price}" +
                    $" Brand: {product.Brand}" +
                    $" Quantity: {product.Quantity}" +
                    $" Rating: {(review != null ? review.Prod_Rating.ToString() : "No Rating")}"
                );
            }
        }

        public void addProduct()
        {
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product description");
            string description = Console.ReadLine();
            Console.WriteLine("Enter product price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product brand");
            object brand = Console.ReadLine();
            Console.WriteLine("Enter quantity of product ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            productList.products.Add(new model.product()
            {
                Id = productList.products.Count + 1,
                Name = name,
                Description = description,
                Price = price,
                Brand = brand,
                Quantity = quantity
            });


            Console.WriteLine("Product added");
        }
        public void removeProduct()
        {
            Console.WriteLine("Enter product id to remove");
            int id = Convert.ToInt32(Console.ReadLine());
            productList.products.RemoveAll(x => x.Id == id);

            Console.WriteLine("Product removed");
        }
        public void updateProduct()
        {
            //Console.WriteLine("Product updated");
        }
        public void showReview()
        {

            foreach (var review in product_review.product_reviews)
            {
                Console.WriteLine(
                    $" Review by->" + userList.users.Find(x => x.Id == review.userId).Name+
                    $" Product Name: {productList.products.Find(x => x.Id == review.Id).Name}"+
                    $"Id: {review.Id} " +
                    $"Rating: {review.Prod_Rating}" +
                    $" Review: {review.Prod_Review}" +
                    $" Review Date: {review.Prod_Review_Date}"
                    );
            }

        }
        public void addReview()
        {

            Console.WriteLine("Enter product id to add review");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product rating");
            double rating = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter product review");
            string review = Console.ReadLine();
            Console.WriteLine("Enter review date");
            string reviewDate = Console.ReadLine();
            
            product_review.product_reviews.Add(new product_review()
            {
                Id = id,
                Prod_Rating = rating,
                Prod_Review = review,
                Prod_Review_Date = reviewDate
            });

            Console.WriteLine("Review added");
        }
        public void removeReview()
        {

            Console.WriteLine("Enter review id to remove");
            int id = Convert.ToInt32(Console.ReadLine());
            product_review.product_reviews.RemoveAll(x => x.Id == id);
            Console.WriteLine("Review removed");
        }
        public void updateReview()
        {
            Console.WriteLine("Review updated");
        }

        public int choicee()
        {
            Console.WriteLine($@"Enter your choice
            0. Show Products
            1. Add Product
            2. Remove Product
            3. Update Product
            4. Show Review
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