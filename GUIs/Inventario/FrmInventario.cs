using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CieloShowroom.GUIs.Inventario
{
    public partial class FrmInventario : Form
    {
        private Frm_EntradaDeInventario frmEntradaInventario = new Frm_EntradaDeInventario();

        public FrmInventario()
        {
            InitializeComponent();
        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }

        private void RemoverControles()
        {
            foreach (Control control in panelResponse.Controls)
            {
                panelResponse.Controls.Remove(control);
            }
        }

        private void btnEntradaInventario_Click(object sender, EventArgs e)
        {
            RemoverControles();
            AbrirFormulario(frmEntradaInventario);
        }
        private void AbrirFormulario(UserControl uc)
        {
            if (panelResponse.Controls.OfType<UserControl>().FirstOrDefault() == null)
            {
                panelResponse.Controls.Add(uc);
            }
            
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void btnInventarioActual_Click(object sender, EventArgs e)
        {
            RemoverControles();
        }
    }
}
