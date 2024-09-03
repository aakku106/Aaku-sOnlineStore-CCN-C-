using OnlineShopingStore.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.db
{
    public class productList
    {
        public static List<product> products = new List<product>()
        {
            new product()
            {

                Id = 1,
                Name = "Apple",
                Description = " ",
                Price = 100,
                Brand = 1,
                Quantity = 100,
            },
            new product()
            {
                Id = 2,
                Name = "Banana",
                Description = " ",
                Price = 50,
                Brand = 2,
                Quantity = 100,
            },
            new product()
            {
                Id = 3,
                Name = "Orange",
                Description = " ",
                Price = 60,
                Brand = 3,
                Quantity = 100,
            },
            new product()
            {
                Id = 4,
                Name = "Mango",
                Description = " ",
                Price = 80,
                Brand = 4,
                Quantity = 100,
            },
            new product()
            {
                Id = 5,
                Name = "Grapes",
                Description = " ",
                Price = 70,
                Brand = 5,
                Quantity = 100,
            },
            new product()
            {
                Id = 6,
                Name = "Pineapple",
                Description = " ",
                Price = 90,
                Brand = 6,
                Quantity = 100,
            },
            new product()
            {
                Id = 7,
                Name = "Strawberry",
                Description = " ",
                Price = 120,
                Brand = 7,
                Quantity = 100,
            },
            new product()
            {
                Id = 8,
                Name = "Iphone",
                Description = " ",
                Price = 1000,
                Brand = "Apple",
                Quantity = 50,
            },
            new product()
            {
                Id = 9,
                Name = "Samsung S24",
                Description = " ",
                Price = 1200,
                Brand = "Samsung",
                Quantity = 30,
            },



        };
    }
}