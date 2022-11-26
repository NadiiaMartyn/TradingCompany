using DAL;
using DTO;

namespace BLL
{
    public class CommentServices : ICommentServices
    {
        private ICommentRepository _commentRepository { get; set; }
        public CommentServices(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void AddComment(int orderId, string commentText) => _commentRepository.AddComment(orderId, commentText);
        public List<CommentDTO> GetCommentsOfUser(int id) => _commentRepository.GetCommentsOfUser(id);
    }
}