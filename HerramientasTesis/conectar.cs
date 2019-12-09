using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace HerramientasTesis
{
    class conectar
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public string bdcodigo,bdmarca,bdcategoria,bdnom_producto,bddescripcion,bdprecio;
        public int bdstock;
        public conectar()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=herramientas;Integrated Security=True");
                cn.Open();
                 //MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se conecto con la base de datos:" + ex.ToString());
            }
        }


        /*public void leerproductos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("exec leerproducto", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUEDE COMPLETAR LA TRANSACCION" + ex.ToString());
            }
        }*/

        public bool busqueda(string cod)
        {
            
            int contador = 0;
            try
            {
                cn.Open();
                //cmd = new SqlCommand("exec busqueda " + cod + "", cn);
                cmd = new SqlCommand("select * from producto where codigo = '" + cod + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())   // ciclo que recorra todos los registros de la consulta. poveda
                {
                    bdcodigo = dr["codigo"].ToString();
                    bdmarca = dr["marca"].ToString();
                    bdcategoria = dr["categoria"].ToString();
                    bdnom_producto = dr["nom_producto"].ToString();
                    bddescripcion = dr["descripcion"].ToString();
                    bdstock = int.Parse(dr["stock"].ToString());
                    bdprecio = dr["precio"].ToString();
                    //imagen
                    contador++;    
                }
                cn.Close();dr.Close(); // cerrar el data reader
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO CONSULTAR:" + ex.ToString());
            }
            return false; // retornamos la variable contador poveda
       }

        public void AgregarProducto(string nombreProducto, string marcaProducto, string categoriaProducto, string descriProdcuto, float stock, int precio, string imagen){

          }

        public void EliminarProducto(string codigo) {
            try
            {
                //cmd = new SqlCommand("exec busqueda " + cod + "", cn);
                cmd = new SqlCommand("delete from producto where codigo = '" + codigo + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close(); // cerrar el data reader
            }
            catch (Exception error) { MessageBox.Show("no se puedo eliminar " + error); }
            
        }

        public void leerproductos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from producto", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUEDE COMPLETAR LA TRANSACCION" + ex.ToString());
            }
        }

    }
}
