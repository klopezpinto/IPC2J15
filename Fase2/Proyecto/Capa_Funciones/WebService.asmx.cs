using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Capa_Funciones
{
    [WebService(Namespace = "http://localhost/WebService", Name = "WebService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string LoginEmpleado(int codigo)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter CMD = new SqlDataAdapter("SELECT Dep_cod_departamento FROM Empleado WHERE cod_empleado = " + codigo + ";", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string pass = TablaTipo.Rows[0]["Dep_cod_departamento"].ToString();

            return "OK";
        }

        [WebMethod]
        public string LoginCliente(String usuario, String pass)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente WHERE usuario = '" + usuario + "' AND pass = '" + pass + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                return "OK";
            }
            else
            {
                return "ERROR";
            }
        }

        [WebMethod]
        public string EditarDatosCliente(String user, String nombre, String apellido, String direccion, int telefono, int credito)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Cliente SET nombre = '" + nombre + "' , apellido = '" + apellido + "' , direccion = '" + direccion + "' , telefono = " + telefono + " , tarjeta_credito = " + credito + "WHERE usuario = '" + user + "';", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string NuevoCliente (int dpi, String usuario, String pass, String nombre, String apellido, String nit, String direccion, int telefono, int credito, int sucursal)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT into Cliente values (" + dpi + ",'" + usuario + "', '" + pass + "', '" + nombre + "', '" + apellido + "'," + nit + ", '" + direccion + "'," + telefono + "," + credito + "," + sucursal + ")", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }
    }
}
