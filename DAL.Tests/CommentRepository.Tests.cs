using DTO;
using Xunit;

namespace DAL.Tests
{
   public class CommentRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void AddComment_Test()
       {
           //Arrange
           CommentRepository commentRepository = new CommentRepository(_connectionString);
           CommentDTO expected = new CommentDTO
           {
               Id = 5,
               OrderId = 1,
               Text = "Nice Burger!"
           };
           commentRepository.AddComment(expected.OrderId, expected.Text);
           //Act
           var actual = commentRepository.GetCommentsOfUser(1)[0];
           //Assert
           Assert.Equal(actual.Text, expected.Text);
       }
   }
}
