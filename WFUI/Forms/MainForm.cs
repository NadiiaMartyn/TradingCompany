using BLL;
using DTO;

namespace WFUI
{
    public partial class MainForm : Form
    {
        private CommentsForm _commentForm { get; set; }
        private TextPromptForm _textPromptForm { get; set; }
        private IUserServices _userServices { get; set; }
        private IOrderServices _orderServices { get; set; }
        private ICommentServices _commentServices { get; set; }
        private UserDTO _user { get; set; }
        private string _clearPassword { get; set; }
        private List<OrderDTO> _orders { get; set; }
        private List<OrderDTO> _ordersFiltered { get; set; }

        public MainForm(
            IUserServices userServices,
            IOrderServices orderServices, 
            ICommentServices commentServices,
            CommentsForm commentsForm,
            TextPromptForm textPromptForm)
        {
            InitializeComponent();
            //
            _userServices = userServices;
            _orderServices = orderServices;
            _commentServices = commentServices;
            //
            _commentForm = commentsForm;
            _textPromptForm = textPromptForm;
        }

        public void LoadLoginPassword(string userLogin, string userPassword)
        {
            _user = _userServices.Get(userLogin);
            _clearPassword = userPassword;
            //Profile
            RefreshProfile();
            //Orders
            RefreshOrders();
            foreach (DataGridViewColumn col in ordersDataGridView.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void RefreshProfile()
        {
            displayNameLabel.Text = "Display Name : " + _user.DispName;
            loginLabel.Text = "Login : " + _user.Login;
            passwordLabel.Text = "Password : " + PasswordBlur(_clearPassword, 2);
        }

        private string PasswordBlur(string password, int show)
        {
            return new string('*', password.Length - show) + password.Substring(password.Length - show);
        }

        private void RefreshOrders()
        {
            _orders = _orderServices.GetOrderHistory(_user.Id);
            _ordersFiltered = _orderServices.GetOrderHistory(_user.Id);
            RefreshOrderDataGrid();
        }

        private void RefreshUser()
        {
            _user = _userServices.Get(_user.Id);
            RefreshProfile();
        }

        private void RefreshOrderDataGrid() => ordersDataGridView.DataSource = _ordersFiltered
            .Select(orderDTO => new
            {
                OrderID = orderDTO.Id,
                ProductName = orderDTO.ProductName,
                OrderTime = orderDTO.InsertTime
            }).ToList();

        private void SearchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            _ordersFiltered = _orders
                .Where(orderDTO => orderDTO.ProductName
                .Contains(searchToolStripTextBox.Text))
                .ToList();

            RefreshOrderDataGrid();
        }

        private void SortDescToolStripButton_Click(object sender, EventArgs e)
        {
            _ordersFiltered = _ordersFiltered.OrderBy(orderDTO => orderDTO.Id).ToList();
            RefreshOrderDataGrid();
        }

        private void sortAscToolStripButton_Click(object sender, EventArgs e)
        {
            _ordersFiltered = _ordersFiltered.OrderByDescending(orderDTO => orderDTO.Id).ToList();
            RefreshOrderDataGrid();
        }

        private void RepeatOrderToolStripButton_Click(object sender, EventArgs e)
        {
            _orderServices.PlaceOrder(_user.Id, (int)ordersDataGridView.SelectedRows[0].Cells[0].Value);
            RefreshOrders();
        }

        private void ShowCommentsToolStripButton_Click(object sender, EventArgs e)
        {
            _commentForm.LoadUser(_user);
            _commentForm.LoadOrderID((int)ordersDataGridView.SelectedRows[0].Cells[0].Value);
            _commentForm.ShowDialog();
        }

        private void CommentToolStripButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Comment", "Comment");
            if (_textPromptForm.ShowDialog() == DialogResult.OK)
                _commentServices.AddComment((int)ordersDataGridView.SelectedRows[0].Cells[0].Value, _textPromptForm._res);
        }

        private void changeDisplayNameButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Display Name", "Change");
            if (_textPromptForm.ShowDialog() == DialogResult.OK)
                _userServices.UpdateDispName(_user.Login, _textPromptForm._res);
            RefreshUser();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Password", "Change");
            if (_textPromptForm.ShowDialog() == DialogResult.OK)
            {
                _userServices.UpdatePassword(_user.Login, _textPromptForm._res);
                _clearPassword = _textPromptForm._res;
            }
            RefreshUser();
        }
    }
}
