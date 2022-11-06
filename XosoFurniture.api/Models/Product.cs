namespace XosoFurniture.api.Models
{
    public class Product
    {
        public int productStock { get; set; }
        public float productPrice { get; set; }
        public string productDescription { get; set; }
        public string productName { get; set; }
        public int productId { get; set; }

        public Product(int productId, string productName, float productPrice, int productStock, string productDescription)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productStock = productStock;
            this.productDescription = productDescription;
        }
        public Product()
        {

        }
    }
}
