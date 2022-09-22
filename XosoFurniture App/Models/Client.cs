using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class Client
    {
        private String ClientId { get; set; }
        private String ClientName { get; set; }
        private String ClientAddres { get; set; }
        private string ClientPhone { get; set; }
        private string ClientEMail { get; set; }
        private string ClientCard { get; set; }
        private bool IsSubscribed { get; set; }
        private List<Product> ShoppingCart { get; set; }
        private List<Purchase> Purchases { get; set; }

        public void AddToShoppingCart(Product product)
        {
            ShoppingCart.Add(product);
        }

        public void BuyShoppingCart()
        {
            //check it out
            Purchases.Add(new Purchase
            {
                IdPurchased = 1,
                TimeOfPurchase = DateTime.Now,
                ShipmentCost = 200,
                ProductsPurchased = null

            });
            foreach (Product product in ShoppingCart)
            {
                Console.WriteLine(product.ProductName);
                Purchases.

                ShoppingCart.Remove(product);
            }
            
        }

        public struct Purchase
        {
            public List<Product> ProductsPurchased { get; set; }
            public DateTime TimeOfPurchase { get; set; }
            public int IdPurchased { get; set; }
            public double ShipmentCost { get; set; }

        }


    }

}
