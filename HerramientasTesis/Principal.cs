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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        conectar co = new conectar();

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA");
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void codigo(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                if (co.busqueda(tex_codigo.Text))
                {
                    //si no xiste
                    lab_nomProducto.Text = co.bdnom_producto.ToString();
                    lab_marcaProducto.Text = co.bdmarca.ToString();
                    lab_categoriaProducto.Text = co.bdcategoria.ToString();
                    lab_descripcionProducto.Text = co.bddescripcion.ToString();
                    lab_stock.Text = co.bdstock.ToString();
                    lab_precio.Text = co.bdprecio.ToString();
                }
                else
                {
                    MessageBox.Show("Quiere Agregarlo");
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            co.leerproductos(dataGridView1);
        }

        private void btn_enviarSimulacro_Click(object sender, EventArgs e)
        {
            lab_simuNombreProducto.Text = lab_nomProducto.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float total = float.Parse(lab_precio.Text) * float.Parse(tex_unidad.Text);
            string mensaje = ""+lab_simuNombreProducto.Text+" / "+tex_unidad.Text+" * "+lab_precio.Text+" = "+total.ToString();
            listBox1.Items.Add(mensaje);
            
        }

        private void btn_limpirDatos_Click(object sender, EventArgs e)
        {
            lab_nomProducto.Text = "- - - - - - - -";
            tex_codigo.Text = "";
            lab_marcaProducto.Text = "- - - - -";
            lab_categoriaProducto.Text = "- - - - -";
            lab_descripcionProducto.Text = "- - - - -" +
                "- - - - - " +
                "- - - - - ";
            lab_stock.Text = "- - - - -";
            lab_precio.Text = "- - - - -";
            tex_unidad.Text = "";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarProducto ap = new AgregarProducto();
            ap.Show();
        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ActualizarProdcuto ap = new ActualizarProdcuto();
            ap.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
            EliminarProdcuto ep = new EliminarProdcuto();
            ep.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelControl pc = new PanelControl();
            pc.Show();
        }
    }
}
