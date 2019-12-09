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
    public partial class ActualizarProdcuto : Form
    {
        public ActualizarProdcuto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelControl pc = new PanelControl();
            pc.Show();
        }
    }
}
