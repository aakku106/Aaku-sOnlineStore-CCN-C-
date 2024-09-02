using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopingStore.model
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public int id;
        public string name;
        public string desc;
        public int price;
        public int quantity;
        List<product_review> product_reviews = new List<product_review>();
    }
}
