using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LoginUniversidad
{
    public partial class F1Login : Form
    {
        public F1Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static void moveForm(Form pForm)
        {
            ReleaseCapture();
            SendMessage(pForm.Handle, 0x122, 0xf012, 0);
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void F1Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                F1Login.moveForm(this);
            }
        }

    }
}
