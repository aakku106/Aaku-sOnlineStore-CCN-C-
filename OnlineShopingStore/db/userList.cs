using OnlineShopingStore.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.db
{
    public class userList
    {

        public static List<user> users = new List<user>()
        {
            new user()
            {
                Id = 1,
                Name = "aakku",
                Email = "weeee@ccn.com",
                Password = "1234",
                Address = "konoka7",
            },
            new user()
            {
                Id = 2,
                Name = "Doe",
                Email = "weeeeeeeeeeee@gmail.com",
                Password = "1234",
                Address = "konoka7",
            },
            new user()
            {
                Id = 3,
                Name = "Jane",
                Email = "weeee@yahoo.com",
                Password = "1234",
                Address = "konoka7",
            },
            new user()
            {
                Id = 4,
                Name = "boe",
                Email = "weeeeeee@iclode.com",
                Password = "1234",
                Address = "konoka7",

            }
        };
    } }
