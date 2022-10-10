using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class Cashier
    {
        private Client client;
        private string employeeName;
        public Cashier(Client client, string employeeName)
        {
            this.client = client;
            this.employeeName = employeeName;
            client.ClientEvent += new Client.ClientDelegate(ReceivingProductsHandler);
            client.ClientEvent += new Client.ClientDelegate(PayingShoppingCartHandler);
        }

        public void ReceivingProductsHandler(ShoppingCart shoppingCart)
        {
            for (int i = 0; i < shoppingCart.Products.Count; i++)
            {
                Console.WriteLine("Receiving " + shoppingCart.Products[i].ProductName);
            }
            
        }

        public void PayingShoppingCartHandler(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Waiting a payment of: " + shoppingCart.GetTotal());
        }
    }
}
