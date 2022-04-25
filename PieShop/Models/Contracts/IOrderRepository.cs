namespace PieShop.Models.Contracts
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
