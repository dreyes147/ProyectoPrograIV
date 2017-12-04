using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograIV.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void instituciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.mInstitucion vPantalla = new Forms.mInstitucion();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.mCliente vPantalla = new Forms.mCliente();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mCreditos vPantalla = new mCreditos();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void estructuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.mEstructura vPantalla = new Forms.mEstructura();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void plantillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.mPlanilla vPantalla = new Forms.mPlanilla();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.mAplicacionPagos vPantalla = new Forms.mAplicacionPagos();
                vPantalla.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
