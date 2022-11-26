using BLL;
using DTO;

namespace ConsoleUI
{
   public class ConsoleUI
   {
       private UserServices userServices { get; set; }
       private OrderServices orderServices { get; set; }
       private CommentServices commentServices { get; set; }

       private bool exit { get; set; }
       private UserDTO _user { get; set; }
       private List<OrderDTO> orders { get; set; }
       private List<OrderDTO> ordersFiltered { get; set; }
       private List<CommentDTO> comments { get; set; }

       public ConsoleUI()
       {
           userServices = new UserServices();
           orderServices = new OrderServices();
           commentServices = new CommentServices();
           exit = false;
       }

       //===========================
       public void LogPage()
       {
           string login, password;
           do
           {
               Console.Clear();
               Console.Write("Login : ");
               login = Console.ReadLine();
               Console.Write("Password : ");
               password = Console.ReadLine();
           } while (!userServices.CheckPassword(login, password));

           _user = userServices.Get(login);
           RefreshOrdersList();
           RefreshCommentsList();
           CallMainPage();
       }
       private void Menu(string title, string[] options, Action[] actions)
       {
           int rowN = options.Length, pPos = 1;
           while (!exit)
           {
               Console.Clear();
               Console.WriteLine($"\t{title}");
               for (var i = 0; i < rowN; i++)
               {
                   Console.Write($"{i + 1}. ");
                   Console.Write("{0,-20}", options[i]);
                   if (i + 1 == pPos)
                       Console.Write("<");
                   Console.WriteLine();
               }

               switch (Console.ReadKey().Key)
               {
                   case ConsoleKey.UpArrow:
                       if (1 < pPos) pPos--;
                       break;
                   case ConsoleKey.DownArrow:
                       if (pPos < rowN) pPos++;
                       break;
                   case ConsoleKey.E:
                   case ConsoleKey.Enter:
                       Console.Clear();
                       actions[pPos - 1]();
                       break;
               }
           }

           exit = false;
       }
       private void CallCommentsPage()
       {
           Menu("Comments",
               new[] { "Add Comment", "All Comments", "Back" },
               new Action[] { AddComment, ShowComments, GoToExit });
       }
       //===========================Log -> Main
       private void CallMainPage()
       {
           Console.WriteLine("MAIN PAGE...");
           Menu("===MAIN MENU===",
               new[] { "Role Page", "Orders & Comments", "Exit" },
               new Action[] { CallRolePage, CallOrdersCommentsPage, GoToExit });
       }
       private void CallOrdersCommentsPage()
       {
           Menu("Orders & Comments",
               new[] { "Orders", "Comments", "Back" },
               new Action[] { CallOrdersPage, CallCommentsPage, GoToExit });
       }
       private void CallOrdersPage()
       {
           Menu("Orders",
               new[] { "Sort", "Search", "Result", "Repeat Order", "Back" },
               new Action[] { CallSortPage, SearchOrderPage, ShowOrdersResult, RepeatOrderPage, GoToExit });
       }
       //Role Page -> Profile Info/Settings
       private void CallProfileSettings()
       {
           Menu("Settings", new[] { "Change Password", "Change Display Name", "Back" },
               new Action[] { ChangeUserPassword, ChangeUserDisplayName, GoToExit });
       }

       //===========================Main -> Role/OrderHistory
       private void CallRolePage()
       {
           Menu("Role Page", new[] { "Profile Info", "Settings", "Logout", "Back" },
               new Action[] { ShowProfileInfo, CallProfileSettings, LogPage, GoToExit });
       }

       //===========================OrderHistory -> Sort / Search / Repeat Order / Show Result / Write Comment
       private void CallSortPage()
       {
           Menu("Sort",
               new[] { "Ascending", "Descending", "Back" },
               new Action[] { SortOrderHistoryASC, SortOrderHistoryDESC, GoToExit });
       } //Sort -> ASC / DESC

       //===========================
       private void ShowProfileInfo()
       {
           Console.WriteLine("{0,-25}{1,-20}{2,-20}", "Display Name", "Login", "Password");
           Console.WriteLine(new string('=', 65));
           Console.WriteLine("{0,-25}{1,-20}{2,-20}", _user.DispName, _user.Login, _user.Password);
           Console.ReadKey();
       }
       private void ShowOrdersResult()
       {
           Console.WriteLine("{0,-10}{1,-15}{2,-25}{3,-20}\n{4}", "Order ID", "Product", "Order Time", "Comments",
               new string('=', 58));
           foreach (var order in ordersFiltered)
           {
               Console.Write("{0,-10}{1,-15}{2,-25}", order.Id, order.ProductName, order.InsertTime);
               foreach (var comment in comments.Where(comment => comment.OrderId == order.Id)
                            .Select((val, i) => (val, i)))
               {
                   if (comment.i != 0)
                       Console.Write(new string(' ', 50));
                   Console.WriteLine($"{comment.val.Text}");
               }
               if (comments.Where(comment => comment.OrderId == order.Id).Count() == 0)
                   Console.WriteLine("...");
           }

           Console.ReadKey();
       }
       private void ShowComments()
       {
           Console.WriteLine("{0,-15}{1,-25}{2,-5}\n{3}", "Order ID", "Order Time", "Text",
               new string('=', 44));
           foreach (var comment in comments)
               Console.WriteLine("{0,-15}{1,-25}{2,-5}", comment.OrderId, comment.InsertTime,
                   comment.Text);
           Console.ReadKey();
       }
       private void AddComment()
       {
           Console.Write("Order id : ");
           var order_id = int.Parse(Console.ReadLine());
           if (orderServices.UserOrderCheck(_user.Id, order_id))
           {
               Console.Write("Comment : ");
               var comment_text = Console.ReadLine();
               commentServices.AddComment(order_id, comment_text);
           }

           RefreshCommentsList();
       }
       private void SearchOrderPage()
       {
           Console.WriteLine("\tSearch");
           Console.Write("Product name : ");
           var productName = Console.ReadLine();
           ordersFiltered = orders.FindAll(order => order.ProductName == productName);
       } 
       private void RepeatOrderPage()
       {
           Console.WriteLine("\tRepeat order");
           Console.Write("Order id : ");
           var order_id = int.Parse(Console.ReadLine());
           var order = orderServices.GetOrder(order_id);
           if (orderServices.UserOrderCheck(_user.Id, order_id)) 
               orderServices.PlaceOrder(_user.Id, order.ProductId);
           RefreshOrdersList();
       }
       private void ChangeUserDisplayName()
       {
           Console.WriteLine("\tChange Display Name");
           Console.Write("New name : ");
           var new_disp_name = Console.ReadLine();
           userServices.UpdateDispName(_user.Login, new_disp_name);
           RefreshCurrentUser();
       }
       private void ChangeUserPassword()
       {
           Console.WriteLine("\tChange Password");
           Console.Write("New password : ");
           var new_password = Console.ReadLine();
           userServices.UpdatePassword(_user.Login, new_password);
           RefreshCurrentUser();
       }

       private void SortOrderHistoryASC() => ordersFiltered = orders.OrderBy(order => order.ProductName).ToList();
       private void SortOrderHistoryDESC() => ordersFiltered = orders.OrderByDescending(order => order.ProductName).ToList();
       private void RefreshCommentsList() => comments = commentServices.GetCommentsOfUser(_user.Id);
       private void RefreshOrdersList()
       {
           orders = orderServices.GetOrderHistory(_user.Id);
           ordersFiltered = orderServices.GetOrderHistory(_user.Id);
       }
       private void RefreshCurrentUser() => _user = userServices.Get(_user.Id);
       private void GoToExit() => exit = true;
   }
}
//"Sort", "Search", "Repeat Order", "Write Comment", "Result","Comments", "Back"