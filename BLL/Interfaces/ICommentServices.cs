using DTO;

namespace BLL
{
    public interface ICommentServices
    {
        void AddComment(int orderId, string commentText);
        List<CommentDTO> GetCommentsOfUser(int id);
    }
}