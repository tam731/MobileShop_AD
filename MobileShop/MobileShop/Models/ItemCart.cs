using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MobileShop.Models
{
    public class ItemCart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public decimal Total { get; set; }
        public string Image { get; set; }

        public ItemCart(int id, int quantity)
        {
            using (MobileManagementEntities1 db = new MobileManagementEntities1())
            {
                this.Id = id;
                Product product = db.Products.Single(n => n.ProductID == id);
                this.ProductName = product.ProductName;
                this.Image = product.Image;
                this.Price = product.Price;
                this.Quantity = quantity;
                this.Total = Price * Quantity;
            }

        }
        public ItemCart()
        {

        }
    }
}