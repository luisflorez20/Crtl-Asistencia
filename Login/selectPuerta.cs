using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class selectPuerta : Form
    {
        public selectPuerta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_puertas.Items.Add("Puerta 01 Floresta");
            cmb_puertas.Items.Add("Puerta 02 Cabildo");
            cmb_puertas.Items.Add("Puerta 03 La Borda");
            cmb_puertas.Items.Add("Puerta 04 Olaechea");
            cmb_puertas.Items.Add("Puerta 04 Limoncillo");

        }

        private void selectPuerta_Load(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmentrada form = new frmentrada();
            form.Show();
        }
    }
}
