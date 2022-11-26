using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace WFUI
{
    public partial class SignUpForm : Form
    {
        private IUserServices _userServices { get; set; }
        public SignUpForm(IUserServices userServices)
        {
            _userServices = userServices;
            InitializeComponent();
        }

        private void newRegisterButton_Click(object sender, EventArgs e)
        {
            if (_userServices.Get(newLoginTextBox.Text) == null)
            {
                _userServices.Add(new UserDTO()
                {
                    Login = newLoginTextBox.Text,
                    Password = PasswordHasher.Hash(newPasswordTextBox.Text),
                    DispName = newDispNameTextBox.Text
                });
                MessageBox.Show("User registered successfully!");
                newLoginTextBox.Clear();
                newPasswordTextBox.Clear();
                newDispNameTextBox.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("This user already registered");
            }
        }
    }
}
