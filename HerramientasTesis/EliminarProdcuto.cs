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
    public partial class EliminarProdcuto : Form
    {
        public EliminarProdcuto()
        {
            InitializeComponent();
        }
        conectar co = new conectar();
        private void EliminarProdcuto_Load(object sender, EventArgs e)
        {

        }

        private void eliminar(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                if (co.busqueda(tex_codigo.Text))
                {
                    //si no xiste
                    text_nombreProducto.Text = co.bdnom_producto.ToString();
                    comboBox1.Text = co.bdmarca.ToString();
                    comboBox2.Text = co.bdcategoria.ToString();
                    text_descrip.Text = co.bddescripcion.ToString();
                    text_stock.Text = co.bdstock.ToString();
                    text_precio.Text = co.bdprecio.ToString();
                    //imagen
                }
                else
                {
                    MessageBox.Show("Quiere Agregarlo");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelControl pc = new PanelControl();
            pc.Show();
        }
    }
}
