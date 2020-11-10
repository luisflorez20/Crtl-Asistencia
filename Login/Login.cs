using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        Form_RegistroUsuario logeo;


        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                     
               if ((txtusuario.Text == "Administrador") && (txtcontra.Text == "Admin"))

               {
                    this.Hide();
                    logeo = new Form_RegistroUsuario();
                    logeo.ShowDialog();

                }
                else
                    MessageBox.Show("Error al ingresar datos");


        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea cancelar?", @"Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             //   Application.Exit();

            {
                this.Hide();
                frmentrada entrada = new frmentrada();
                entrada.Show();
            }
            else
                txtusuario.Focus();

        }


        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if ((txtusuario.Text == "Administrador") && (txtcontra.Text == "Admin"))

                {
                    this.Hide();
                    logeo = new Form_RegistroUsuario();
                    logeo.ShowDialog();
                    
                }
                else
                    MessageBox.Show("Error al ingresar datos");
                
            }
          
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }        

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
