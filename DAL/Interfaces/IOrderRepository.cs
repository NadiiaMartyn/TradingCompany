using DTO;

namespace DAL
{
    public interface IOrderRepository
    {
        public void CreateOrder(int userId, int productId);
        public OrderDTO Get(int id); 
        public List<OrderDTO> GetOrderHistory(int userId);
    }
}