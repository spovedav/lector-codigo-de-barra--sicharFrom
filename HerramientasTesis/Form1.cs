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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Acceso ace = new Acceso();
        
        private const int intentos = 2;

        private void llaveHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(90, 70);
        }

        private void llaveLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(83, 63);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           if (tex_usuario.Text == "")
            {
                MessageBox.Show("El campo NOMBRE no pude estar vacio");
                tex_usuario.Focus();
            }

            if (tex_clave.Text == "")
            {
                MessageBox.Show("El campo CLAVE no pude estar vacio");
                tex_clave.Focus();
            }

            /*if (tex_clave.Text == "" || tex_usuario.Text == "")
            {
                MessageBox.Show("No puede estar vacios los campos");
                tex_usuario.Focus();
            }*/
                if (tex_usuario.Text == "Admin" || tex_usuario.Text == "admin")
                {
                if (tex_clave.Text == "Admin" || tex_clave.Text == "ADMIN" || tex_clave.Text == "admin")
                {
                    PanelControl pc = new PanelControl();

                    this.Hide();
                    pc.label_usuario.Text = "ADMINISTRADOR";
                    pc.pictureBox2.BackgroundImage = Properties.Resources.admin;
                    pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pc.Show();

                }
                else MessageBox.Show("clave incorrecta");
                }else if (tex_usuario.Text == "cliente" || tex_usuario.Text == "Cliente")
                 {
                 if (tex_clave.Text == "123")
                    {
                    PanelControl pc = new PanelControl();
                    this.Hide();
                    pc.label_usuario.Text = "CLIENTES";
                    pc.pictureBox2.BackgroundImage = Properties.Resources.user;
                    //pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
                    pc.Show();
                }
                 }
            
        }
    }
}
