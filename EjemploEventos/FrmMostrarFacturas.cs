using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploEventos
{
    public partial class FrmMostrarFacturas : Form
    {
        FrmAgregarFacturas frmAgregarFacturas = null;

        public FrmMostrarFacturas()
        {
            InitializeComponent();
            //frmAgregarFacturas.facturaAgregada += new EventHandler(factura_Agregada);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAgregarFacturas = new FrmAgregarFacturas();
            frmAgregarFacturas.facturaAgregada += new EventHandler(factura_Agregada);
            frmAgregarFacturas.Show();
        }
        private void factura_Agregada(object sender, EventArgs e)
        {
            MessageBox.Show("Factura Enviada");
        }
    }
}
