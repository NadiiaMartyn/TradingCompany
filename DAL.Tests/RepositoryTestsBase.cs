using System;
using System.Data.SqlClient;

namespace DAL.Tests
{
   public abstract class RepositoryTestsBase : IDisposable
   {
       protected string _connectionString { get; set; }

       protected RepositoryTestsBase()
       {
           _connectionString = "Server=DESKTOP-9GGT2EU;Database=3K1SPZ_Tests; Integrated Security=true";
           using (var connection = new SqlConnection(_connectionString))
           {
               connection.Open();
               SqlCommand command = new SqlCommand(@"
               SET IDENTITY_INSERT users ON;
               INSERT INTO users (id, login, password, disp_name) VALUES (1, 'mark2002007', '1111', 'MarKson');
               INSERT INTO users (id, login, password, disp_name) VALUES (2, 'gerik123', '123', 'German');
               SET IDENTITY_INSERT users OFF;
               SET IDENTITY_INSERT categories ON;
               INSERT INTO categories (id, name) VALUES (1,'Food'), (2,'Tech'), (3,'Clothes');
               SET IDENTITY_INSERT categories OFF;
               SET IDENTITY_INSERT products ON;
               INSERT INTO products (id, name, category_id) VALUES (1, 'Burger', 1), (2, 'Hotdog', 1), (3, 'Pizza', 1);
               INSERT INTO products (id, name, category_id) VALUES (4,'Laptop', 2), (5, 'Phone', 2), (6, 'Headphones', 2);
               INSERT INTO products (id, name, category_id) VALUES (7, 'Hat', 3), (8, 'Shirt', 3), (9, 'Trousers', 3);
               SET IDENTITY_INSERT products OFF;
               SET IDENTITY_INSERT orders_log ON;
               INSERT INTO orders_log (id, user_id, product_id) VALUES (1, 1, 1), (2, 1, 4), (3, 1, 7);
               INSERT INTO orders_log (id, user_id, product_id) VALUES (4, 2, 2), (5, 2, 5), (6, 2, 8);
               SET IDENTITY_INSERT orders_log OFF;
               SET IDENTITY_INSERT comments ON;
               INSERT INTO comments (id, order_id, text) VALUES (1, 1, 'Nice Burger!'), (2, 2, 'Cool Laptop!');
               INSERT INTO comments (id, order_id, text) VALUES (3, 4, 'Nice Hotdog!'), (4, 5, 'Cool Phone!');
               SET IDENTITY_INSERT comments OFF;
           ",connection);
               command.ExecuteNonQuery();
           }
       }
       public void Dispose()
       {
           using (var connection = new SqlConnection(_connectionString))
           {
               connection.Open();
               SqlCommand command = new SqlCommand(@"
                   DELETE FROM comments;
                   DELETE FROM orders_log;
                   DELETE FROM products;
                   DELETE FROM categories;
                   DELETE FROM users;
               ",connection);
               command.ExecuteNonQuery();
           }
       }
   }
}