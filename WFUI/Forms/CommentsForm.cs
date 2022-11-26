using BLL;
using DTO;
using System.Data;

namespace WFUI
{
    public partial class CommentsForm : Form
    {
        ICommentServices _commentServices { get; set; }
        UserDTO _user { get; set; }
        int _orderID { get; set; }

        public CommentsForm()
        {
            InitializeComponent();
        }
        public void Configure(UserDTO user, int orderId)
        {
            LoadUser(user);
            LoadOrderID(orderId);
            //
            foreach (var comment in _commentServices.GetCommentsOfUser(_user.Id).Where(c => c.OrderId == orderId))
            {
                TextBox textBox = new TextBox();
                commentsFlowLayoutPanel.Controls.Add(textBox);
                textBox.Width = textBox.Parent.Width;
                textBox.Text = comment.Text;
                textBox.Multiline = true;
                textBox.ScrollBars = ScrollBars.Both;
                textBox.WordWrap = true;
                textBox.ReadOnly = true;
            }
        }
        public void LoadUser(UserDTO user) => _user = user;

        public void LoadOrderID(int orderID) => _orderID = orderID;
    }
}
