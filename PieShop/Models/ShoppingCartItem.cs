namespace PieShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
