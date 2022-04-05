using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Entidades;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos(txtNombre.Text, txtPassword.Text))
            {
                if (ExisteUsuario(txtNombre.Text, txtPassword.Text))
                {
                    Usuario usu = new Usuario(txtNombre.Text, txtPassword.Text);
                    Principal ventana = new Principal(usu);
                    ventana.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Faltan ingresar datos");
                txtNombre.Focus();
            }
            
        }


        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPassword.Text = "";
        }

        private bool ValidarCampos(string nombreUsuario, string password)
        {
            if (nombreUsuario.Equals("") && password.Equals(""))
            {
                return false;
            }
            return true;
        }
        private bool ExisteUsuario(string nombreUsuario, string password)
        {
            if (nombreUsuario.Equals("Nicolas")  && password.Equals("1234"))
            {
                return true;
            }
            return false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


    }
}
