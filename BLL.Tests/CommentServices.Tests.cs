using Autofac.Extras.Moq;
using DAL;
using DTO;
using Moq;
using System.Collections.Generic;
using Tools;
using Xunit;

namespace BLL.Tests
{
    public class CommentServicesTests
    {
        [Fact]
        public void AddComment_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int orderId = 1;
                string text = "Text";
                mock.Mock<ICommentRepository>()
                    .Setup(x => x.AddComment(orderId, text));

                var service = mock.Create<CommentServices>();
                service.AddComment(orderId, text);

                mock.Mock<ICommentRepository>()
                    .Verify(x => x.AddComment(orderId, text), Times.Exactly(1));
            }
        }

        [Fact]
        public void GetCommentsOfUser_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int userId = 1;

                mock.Mock<ICommentRepository>()
                    .Setup(x => x.GetCommentsOfUser(userId))
                    .Returns(UserCommentsSample());

                var service = mock.Create<CommentServices>();
                var expected = UserCommentsSample();
                var actual = service.GetCommentsOfUser(userId);
                
                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
                for (int i = 0; i < actual.Count; i++)
                {
                    Assert.Equal(expected[i].Id, actual[i].Id);
                    Assert.Equal(expected[i].OrderId, actual[i].OrderId);
                    Assert.Equal(expected[i].Text, actual[i].Text);
                }
            }
        }

        private List<CommentDTO> UserCommentsSample()
        {
            return new List<CommentDTO>()
            {
                new CommentDTO()
                {
                    Id = 1,
                    OrderId = 1,
                    Text = "Text1"
                },
                new CommentDTO()
                {
                    Id = 2,
                    OrderId = 2,
                    Text = "Text2"
                }
            };
        }
    }
}