namespace WFUI
{
    public partial class TextPromptForm : Form
    {
        public string _res { get; set; }

        public TextPromptForm()
        {
            InitializeComponent();
        }

        public void Configure(string promptText, string buttonText)
        {
            Text = promptText;
            promptButton.Text = buttonText;
            promptTextBox.Clear();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            _res = promptTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
