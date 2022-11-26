using DAL;
using DTO;

namespace BLL
{
    public class OrderServices : IOrderServices
    {
        private IOrderRepository _orderRepository { get; set; }
        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void PlaceOrder(int userId, int productId) => _orderRepository.CreateOrder(userId, productId);
        public OrderDTO GetOrder(int id) => _orderRepository.Get(id);
        public List<OrderDTO> GetOrderHistory(int userId) => _orderRepository.GetOrderHistory(userId);
        public bool UserOrderCheck(int userId, int orderId)
        {
            OrderDTO order;
            if ((order = _orderRepository.Get(orderId)) != null)
                if (order.UserId == userId)
                    return true;
            return false;
        }
    }
}