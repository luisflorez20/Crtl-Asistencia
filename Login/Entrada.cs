using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Login
{
    public partial class frmentrada : Form
    {        
        public frmentrada()
        {
            InitializeComponent();
        }

        private void fechahora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            //SqlConnection cn = new SqlConnection("data source=ADL-LAP-18002\\SQLEXPRESS;initial catalog=CAMPOVERDE;persist security info=True;user id=sa;password=Donlui$@;MultipleActiveResultSets=True;");
            //SqlConnection cn = new SqlConnection("data source=ADL-LAP-18002\\SQLEXPRESS;initial catalog=ASISTENCIA;user id=sa;password=Donlui$@;MultipleActiveResultSets=True;App=EntityFramework");

            SqlConnection cn = new SqlConnection("data source=192.168.0.5;initial catalog=SFTI;user id=sa;password=DonLuis.rar;MultipleActiveResultSets=True;App=EntityFramework");

           


            
            SqlCommand cmd = new SqlCommand("marcas @1", cn);

            cmd.Parameters.AddWithValue("@1", txtDni.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)


            //string query = "INSERT INTO marcacion           (Name,Price) VALUES (@name,@price)";
            string query = "insert into marcacion(nidGarita, cIdcodigogeneral)values(3, '46715373');
            conexion.Open();
            SqlCommand comand = new SqlCommand(query, conexion);
            comand.Parameters.AddWithValue("@name", txtNameText);
            comand.Parameters.AddWithValue("@price", txtPrice.Text);
            comand.ExecuteNonQuery();
            MessageBox.Show("Product Inserted");



            {  
                
                label1.Text = dt.Rows[0]["cApPaterno"].ToString().Trim();
                label2.Text = dt.Rows[0]["cApMaterno"].ToString().Trim();
                label3.Text = dt.Rows[0]["cNombres"].ToString().Trim();
              
                // crear alerta 
            }

            

            else
            {
                txtDni.Text = "";
                txtDni.Focus();
                lblNombre.Text = "";
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";

                MessageBox.Show("Empleado no existe");

            }


            



            String date = DateTime.Now.ToString("ddMMyyyy");
            String time = DateTime.Now.ToString("HHmmss");                                   


            txtDni.Clear();

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }           

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            //se presiona la tecla enviar
            if (e.KeyCode == Keys.Enter)
            {
                btnenviar.PerformClick();
            }
        }
        
        private void Apaterno_Click(object sender, EventArgs e)
        {

        }
        
        private void Amaterno_Click(object sender, EventArgs e)
        {

        }

        private void Nombres_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmentrada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
 