namespace XosoFurniture.api.Models
{
    public class Product
    {
        private int productStock;
        private float productPrice;
        private string productDescription;
        private string productName;
        private int productId;

        public Product(int productId, string productName, float productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public int ProductId { get { return productId; } set { productId = value; } }
        public string ProductName { get { return productName; } set { productName = value; } }
        public string ProductDescription { get { return productDescription; } set { productDescription = value; } }
        public float ProductPrice { get { return productPrice; } set { productPrice = value; } }
        public int ProductStock { get { return productStock; } set { productStock = value; } }
    }
}
