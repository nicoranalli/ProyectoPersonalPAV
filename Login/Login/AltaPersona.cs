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
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmboBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            cmboBoxCarreras.Items.Add("Ingenierìa en Sistemas de Informaciòn");
            cmboBoxCarreras.Items.Add("Ingenierìa Industrial");
            cmboBoxCarreras.Items.Add("Ingenierìa Quìmica");
            cmboBoxCarreras.Items.Add("Ingenierìa Civíl");
        }

        private void grilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
