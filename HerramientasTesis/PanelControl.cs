using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerramientasTesis
{
    public partial class PanelControl : Form
    {
        public string usuario;
        public PanelControl()
        {
            InitializeComponent();
            label_usuario.Text = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal p = new Principal();
            p.lab_tipoUser.Text = label_usuario.Text;
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarProducto ap = new AgregarProducto();
            ap.Show();
        }

        private void btn_actualizarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizarProdcuto ap = new ActualizarProdcuto();
            ap.Show();
        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
            EliminarProdcuto ep = new EliminarProdcuto();
            ep.Show();
        }
    }
}
