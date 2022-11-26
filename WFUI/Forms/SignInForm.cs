using BLL;

namespace WFUI
{
    public partial class SignInForm : Form
    {
        private IUserServices _userServices { get; set; }
        private MainForm _mainForm { get; set; }
        private CommentsForm _commentsForm { get; set; }
        private TextPromptForm _textPromptForm { get; set; }
        private SignUpForm _signUpForm { get; set; }
        
        public SignInForm(
            IUserServices userServices,
            MainForm mainForm,
            CommentsForm commentsForm,
            TextPromptForm textPromptForm,
            SignUpForm signUpForm)
        {
            InitializeComponent();
            _userServices = userServices;
            _mainForm = mainForm;
            _commentsForm = commentsForm;
            _textPromptForm = textPromptForm;
            _signUpForm = signUpForm;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (_userServices.CheckPassword(loginTextBox.Text, passwordTextBox.Text))
            {
                Hide();
                _mainForm.LoadLoginPassword(loginTextBox.Text, passwordTextBox.Text);
                _mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid login or password!");
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            _signUpForm.ShowDialog();
        }
    }
}