using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ambulance.Services;

namespace Ambulance.Views
{
    public partial class Authorization : MaterialForm
    {
        IAuthServices _authService = new AuthServices();
        public Authorization()
        {
            InitializeComponent();
        }
        private void authButton_Click(object sender, EventArgs e)
        {

           if (_authService.Authorize(loginTextBox.Text.ToString(), passwordTextBox.Text.ToString()) == true)
            {
                DialogResult = DialogResult.OK;   
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = (char)0;
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}