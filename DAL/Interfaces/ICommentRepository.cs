using DTO;

namespace DAL
{
    public interface ICommentRepository
    {
        public void AddComment(int orderId, string commentText);
        public List<CommentDTO> GetCommentsOfUser(int id);
    }
}