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
        public string Address { get; set; }
        public int Price { get; set; }

        public int id;
        //public string product_id;
        public double prod_Rating;
        public string address;
        public int price;
    }
}
