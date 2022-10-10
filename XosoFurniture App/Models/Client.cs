using System;
using System.Collections.Generic;
using System.Text;

namespace XosoFurniture_App.Models
{
    public class Client
    {
        private ShoppingCart shoppingCart;
        private string clientId;
        private string clientName;
        public String ClientId { get{return clientId;} }
        public String ClientName { get{return clientName; } set{ clientName = value;} }
        public ShoppingCart ShoppingCart{get{ return shoppingCart;}}



        public delegate void ClientDelegate(ShoppingCart shoppingCart);
        //private ClientDelegate clientDelegateBuy;
        //public ClientDelegate ClientDelegateBuy{set{ clientDelegateBuy = value; } get{ return clientDelegateBuy;}}

        private event ClientDelegate clientEvent;
        public event ClientDelegate ClientEvent{add{ clientEvent += value;} remove{ clientEvent -= value;}}


        public Client(string clientId, string clientName, ShoppingCart shoppingCart)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.shoppingCart = shoppingCart;
            //ClientDelegate del1 = new ClientDelegate(UnloadHandler);
            //clientDelegateBuy = del1;
            ClientEvent += UnloadHandler;
        }

        public float PayShoppingCart()
        {
            return shoppingCart.GetTotal();
        }

        public void GoToPayToCashier(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Going to the cashier to pay");
            //clientDelegateBuy(shoppingCart);
            clientEvent(shoppingCart);
        }

        public void UnloadHandler(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Unloading the shopping cart with " + shoppingCart.Products.Count + " items");
        }
    }

}
