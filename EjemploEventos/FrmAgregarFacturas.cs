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
    public partial class FrmAgregarFacturas : Form
    {
        public event EventHandler facturaAgregada;

        public FrmAgregarFacturas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (facturaAgregada != null)
            {
                FacturaRepository.AddFactura(Int32.Parse(textBox1.Text), textBox2.Text.ToString(), textBox3.Text.ToString());
                facturaAgregada(sender, e);
                this.Close();
            }
            //FacturaRepository.AddFactura(Int32.Parse(textBox1.Text), textBox2.Text.ToString(), textBox3.Text.ToString());
            //var frmMonstrarFacturas = new FrmMostrarFacturas();
            //frmMonstrarFacturas.Refresh();
            //this.Close();
        }

        private void FrmAgregarFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
