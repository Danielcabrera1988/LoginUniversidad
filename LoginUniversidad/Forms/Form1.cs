using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginUniversidad
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "USUARIO")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.LightGray;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "USUARIO";
                txtBoxUser.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "CONTRASEÑA")
            {
                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.LightGray;
                txtBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "")
            {
                txtBoxPass.Text = "CONTRASEÑA";
                txtBoxPass.ForeColor = Color.Gainsboro;
                txtBoxPass.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void linkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioNuevo FormUser = new UsuarioNuevo();
            FormUser.Show();
        }
    }
}
