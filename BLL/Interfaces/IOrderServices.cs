using DTO;

namespace BLL
{
    public interface IOrderServices
    {
        void PlaceOrder(int userId, int productId);
        OrderDTO GetOrder(int id);
        List<OrderDTO> GetOrderHistory(int userId);
        bool UserOrderCheck(int userId, int orderId);
    }
}