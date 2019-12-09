using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HerramientasTesis
{
    class Acceso
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        //SqlDataAdapter da;
       
        public Acceso()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=herramientas;Integrated Security=True");
                cn.Open();
               // MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto con la base de datos:" + ex.ToString());
            }
        }
        //private string mensaje;
        private string usuari;
        private string clave;
        public static string NombCuenta = "";

        public bool Verificar(string usuario, string clave) {
            try
            {
                cmd = new SqlCommand("select * from usuarios where usuario = '" +usuario + "' and contra = '"+clave +"' ", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())   // ciclo que recorra todos los registros de la consulta. poveda
                {
                    usuari = dr["usuario"].ToString();
                   return true;
                }
                dr.Close(); // cerrar el data reader
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO INGRESAR:" + ex.ToString());
            }
            return false;
        }

        /*public void Verificar(string usuario)
        {
           
                bool resultado = false;
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from usuarios where usuario='" + usuari + "'and contra='" + clave + "'", cn);
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    NombCuenta = dr["usuario"].ToString();
                    resultado = true;
                    mensaje = "Inicio Correctamente \n \n               Bienvenido al Sistema tia \n \n TIA S.A";
                }

                else
                {
                    mensaje = "         Excedio el Limite de Intentos al Sistema \n \nEspere unos Minutos y Ingrese Su Logueo Otra Vez";
                }
                cn.Close();
                return resultado;
        }*/
    }
}
