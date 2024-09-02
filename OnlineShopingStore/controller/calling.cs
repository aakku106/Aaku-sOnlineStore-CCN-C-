using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.controller
{
    public class calling
    {

        public void welcomeMessage()
        {
            Console.WriteLine("Welcome to the CCN  Online Shopping Store Dattebyoo!!!");

            printOptions();


        }

         public void printOptions()
        {
            const string options = "1. Add Product\n2. Remove Product\n3. Update Product\n4. Search Product\n5. Add Review\n6. Remove Review\n7. Update Review\n8. Exit";
            Console.WriteLine(options);
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
        
    }
}
