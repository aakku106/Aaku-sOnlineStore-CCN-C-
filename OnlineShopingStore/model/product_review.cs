using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.model
{
    public class product_review
    {
        public int Id { get; set; }
        public double Prod_Rating { get; set; }
        public string Prod_Review { get; set; }
        public string Prod_Review_Date { get; set; }

        public static List<product_review> product_reviews = new List<product_review>()
        {
            new product_review()
            {
                Id = 1,
                Prod_Rating = 4.5,
                Prod_Review = "Good",
                Prod_Review_Date = "12/12/2020"
            },
            new product_review()
            {
                Id = 2,
                Prod_Rating = 3.5,
                Prod_Review = "Average",
                Prod_Review_Date = "12/12/2020"
            },
            new product_review()
            {
                Id = 3,
                Prod_Rating = 5.0,
                Prod_Review = "Excellent",
                Prod_Review_Date = "12/12/2020"
            },
            new product_review()
            {
                Id = 4,
                Prod_Rating = 2.5,
                Prod_Review = "Bad",
                Prod_Review_Date = "12/12/2020"
            }

        };


    }
}
