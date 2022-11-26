using DTO;
using Xunit;

namespace DAL.Tests
{
   public class OrderRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void GetOrderHistory_Test()
       {
          //Arrange
          OrderRepository orderRepository = new OrderRepository(_connectionString);
          List<OrderDTO> expected = new List<OrderDTO>()
          {
              new OrderDTO
              {
                  UserId = 1,
                  ProductId = 1,
                  ProductName = "Burger"
              },
              new OrderDTO
              {
                  UserId = 1,
                  ProductId = 4,
                  ProductName = "Laptop"
              },
              new OrderDTO
              {
                  UserId = 1,
                  ProductId = 7,
                  ProductName = "Hat"
              }
          };
          //Act
          List<OrderDTO> actual = orderRepository.GetOrderHistory(1);
          //Assert
          Assert.Equal(actual.Count, expected.Count);
          for (int i = 0; i < actual.Count; i++)
          {
              Assert.Equal(actual[i].ProductId,    expected[i].ProductId);
              Assert.Equal(actual[i].ProductName, expected[i].ProductName);
              Assert.Equal(actual[i].UserId, expected[i].UserId);
          }
       }
       [Fact]
       public void Get_Test()
       {
           //Arrange
           OrderRepository orderRepository = new OrderRepository(_connectionString);
           OrderDTO expected = new OrderDTO
           {
               UserId = 1,
               ProductId = 1,
               ProductName = "Burger"
           };

           //Act
           OrderDTO actual = orderRepository.Get(1);
           //Assert
           Assert.Equal(actual.ProductId,    expected.ProductId);
           Assert.Equal(actual.ProductName, expected.ProductName);
           Assert.Equal(actual.UserId, expected.UserId);
       }
       [Fact]
       public void CreateOrder_Test()
       {
           //Arrange
           OrderRepository orderRepository = new OrderRepository(_connectionString);
           OrderDTO expected = new OrderDTO
           {
               UserId = 1,
               ProductId = 1,
               ProductName = "Burger"
           };
           orderRepository.CreateOrder(expected.UserId, expected.ProductId);
           //Act
           OrderDTO actual = orderRepository.Get(1);
           //Assert
           Assert.Equal(actual.ProductId,    expected.ProductId);
           Assert.Equal(actual.ProductName, expected.ProductName);
           Assert.Equal(actual.UserId, expected.UserId);
       }
        
   }
}
