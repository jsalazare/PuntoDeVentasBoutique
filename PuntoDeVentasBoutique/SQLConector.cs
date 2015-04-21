using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebasSQLServer
{
    public class SQLConector
    {
        private SqlConnection con;
        private SqlCommand comand;
        private static SQLConector util;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataSet ds;


        public static SQLConector getInstance(){
            if (util == null)
            {
                util = new SQLConector("Data Source=JAVIER-PC\\SQLEXPRESS; Initial Catalog=pruebas; User ID=sa;Password=163955");
            }
            return util;
        }

        private SQLConector(string sConection) {
            try
            {
                con = new SqlConnection(sConection);
                ds = new DataSet();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no posible conectar a BD " + ex.Message);
            }
        }

        public SqlConnection getConection() {
            return con;
        }

        public DataTable consultar(string sql,string tabla) {
            try 
	        {	        
		        con.Open();
                adapter  = new SqlDataAdapter(sql,con);
                if (!ds.Tables.Contains(tabla))
                {
                    adapter.Fill(ds, tabla);
                }
                con.Close();
            
	        }
	        catch (Exception ex)
	        {
		        MessageBox.Show("Error no se puede." + ex.Message + ex.StackTrace);
	        }
            return ds.Tables[tabla];
        }

        public bool modificar(string query) {
            bool res = true;
            try
            {
                con.Open();
                comand = con.CreateCommand();
                comand.CommandText = query;
                if (comand.ExecuteNonQuery() == -1)
                {
                    res = false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible modificacion: " + ex.Message + ex.StackTrace);
            }
            return res;
        }

        //public List<Cliente> getClientes() {
        //    int res = 0;
        //    List<Cliente> l = new List<Cliente>();
        //    comand = con.CreateCommand();
        //    comand.CommandText = "SELECT * FROM clientes;";
        //    try
        //    {
        //        res = comand.ExecuteNonQuery();
        //        Cliente c;
               
               
        //        reader = comand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            c = new Cliente();
        //            c.id = reader.GetInt32(0);
        //            c.nombre = reader.GetString(1);
        //            c.domicilio = reader.GetString(2);
        //            c.telefono = reader.GetString(3);
        //            c.email = reader.GetString(4);
        //            l.Add(c);
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error, Error: " + ex.Message + ex.StackTrace);
        //    }

        //    return l;
        //}

        //public bool ingresarCliente(Cliente c) {
        //    bool res = modificar(""); ;
            

        //    return res;
        //}

    }
}
