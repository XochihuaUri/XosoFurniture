using System;
using XosoFurniture_App.Models;

namespace XosoFurniture_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("1", "Product 1", 100);
            Product product2 = new Product("2", "Product 2", 300);
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(product1);
            shoppingCart.AddProduct(product2);

            Client client1 = new Client("idclient", "Pepe Trueno", shoppingCart);

            Cashier cashier = new Cashier(client1, "employee James");

            client1.GoToPayToCashier(client1.ShoppingCart);
        }
    }
}
