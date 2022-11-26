using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CommentRepository : BaseRepository, ICommentRepository
    {
        public CommentRepository() : base(Helper.CnnVal())
        {
        }
        public void AddComment(int orderId, string commentText)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"INSERT INTO comments (order_id, text) VALUES (@order_id, @text);", connection);
                command.Parameters.Add(new SqlParameter("@order_id", orderId));
                command.Parameters.Add(new SqlParameter("@text", commentText));
                command.ExecuteNonQuery();
            }
        }

        public List<CommentDTO> GetCommentsOfUser(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"SELECT
	                                                comments.ID AS id
                                                   ,comments.order_id AS order_id
                                                   ,comments.text AS text
                                                   ,comments.insert_time AS insert_time
                                                   ,comments.update_time AS update_time
                                                FROM comments
                                                JOIN orders_log
	                                                ON comments.order_id = orders_log.id
                                                JOIN users
                                                    ON orders_log.user_id = users.id
                                                WHERE users.id = @id;", connection);
                command.Parameters.Add(new SqlParameter("@id", id));
                List<CommentDTO> comments = new();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        comments.Add(new CommentDTO
                        {
                            Id = (int)reader["id"],
                            OrderId = (int)reader["order_id"],
                            Text = (string)reader["text"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        });
                }

                return comments;
            }
        }
    }
}