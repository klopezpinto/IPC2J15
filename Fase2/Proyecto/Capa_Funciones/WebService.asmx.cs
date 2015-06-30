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
        public string LoginEmpleado(int usuario, String pass)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE cod_usuario = '" + usuario + "' AND pass = '" + pass + "' AND Rol_cod_rol = 2;", con);
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
        public string LoginCliente(String usuario, String pass)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE usuario = '" + usuario + "' AND pass = '" + pass + "' AND Rol_cod_rol = 1;", con);
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
        public string VerDepartamento(int usuario)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter CMD = new SqlDataAdapter("SELECT A3.nombre FROM Empleado A1, Usuario A2, Departamento A3 WHERE A1.Usuario_cod_usuario = A2.cod_usuario AND A2.cod_usuario = '" + usuario + "' AND A3.cod_departamento = A1.Departamento_cod_departamento;", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string nombre = TablaTipo.Rows[0]["nombre"].ToString();

            return nombre;
        }

        [WebMethod]
        public string EditarDatosCliente(String user, String nombre, String apellido, String direccion, int telefono, int credito, int cod)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Usuario SET nombre = '" + nombre + "' , apellido = '" + apellido + "' , direccion = '" + direccion + "' , telefono = " + telefono + " WHERE usuario = '" + user + "';", con);
            SqlCommand MCD = new SqlCommand("UPDATE Cliente SET tarjeta_credito = " + credito + " WHERE Usuario_cod_usuario = " + cod + ";", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string NuevoCliente(int dpi, String usuario, String pass, String nombre, String apellido, String nit, String direccion, int telefono, int credito, int sucursal)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT into Usuario values (" + dpi + ",'" + usuario + "', '" + pass + "', '" + nombre + "', '" + apellido + "', '" + direccion + "'," + telefono + ",1)", con);
            SqlCommand MCD = new SqlCommand("INSERT into Cliente values (" + dpi + "," + nit + ", " + credito + ", NULL ," + dpi + ", " + sucursal + ")", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string CargarCSV(String Tabla, String path)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("BULK INSERT " + Tabla + " FROM '" + path + "' WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n')", con);
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
        public string AgregarImpuesto(String categoria, int porcentaje)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Impuesto values ('" + categoria + "'," + porcentaje + ");", con);
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
        public string ModificarPeso(int sucursal, int peso)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Sucursal SET costolibras = " + peso + " WHERE cod_sucursal = " + sucursal + ";", con);
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
        public string ModificarComision(int sucursal, int comision)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Sucursal SET comision = " + comision + " WHERE cod_sucursal = " + sucursal + ";", con);
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
        public string ModificarImpuesto(String categoria, int porcentaje)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Impuesto SET porcentaje = " + porcentaje + " WHERE categoria = '" + categoria + "';", con);
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
        public string EliminarImpuesto(String categoria)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Impuesto WHERE categoria = '" + categoria + "';", con);
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
        public string EliminarPeso(int sucursal)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Sucursal SET costolibras = 0 WHERE cod_sucursal = " + sucursal + ";", con);
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
        public string EliminarComision(int sucursal)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Sucursal SET comision = 0 WHERE cod_sucursal = " + sucursal + ";", con);
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
        public string NuevaSede(int codsede, String pais)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Sede values (" + codsede + ",'" + pais + "');", con);
            cmd.ExecuteNonQuery();
            con.Close();

            return "Agregado!";
        }

        [WebMethod]
        public string NuevaSucursal(int codsuc, String direccion, int telefono, int capmax, int comision, int peso, int codsede)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Sucursal values (" + codsuc + ",'" + direccion + "'," + telefono + "," + capmax + "," + comision + "," + peso + "," + codsede + ");", con);
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
        public string NuevoDepartamento(int coddep, String nombre, int director, int sucursal)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Departamento values (" + coddep + ",'" + nombre + "'," + director + "," + sucursal + ");", con);
            SqlCommand dir = new SqlCommand("UPDATE Empleado Set puesto = 'Director' WHERE cod_empleado = " + director + ";", con);
            SqlDataReader dr;
            dir.ExecuteNonQuery();
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
        public string Director(int director)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT puesto FROM Empleado WHERE cod_empleado = " + director + ";", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string puesto = TablaTipo.Rows[0]["puesto"].ToString();

            if (puesto.Equals("Empleado"))
            {
                return "OK";
            }
            else
            {
                return "ERROR.";
            }
        }

        [WebMethod]
        public string DepSuc(String nombre, int sucursal)
        {
            int tam;
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand N = new SqlCommand("SELECT COUNT (nombre) FROM Departamento WHERE nombre = '" + nombre + "' AND Sucursal_cod_sucursal = " + sucursal + ";", con);
            N.Connection = con;
            tam = (int)N.ExecuteScalar();

            if (tam > 0)
            {
                return "ERRORES";
            }
            else
            {
                return "Agregado!";
            }
        }

        [WebMethod]
        public string DirectorDep(int codigo_empleado)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT A1.puesto FROM Empleado A1, Usuario A2, Departamento A3 WHERE A1.Usuario_cod_usuario = A2.cod_usuario AND A2.cod_usuario =" + codigo_empleado + " AND A3.cod_departamento = A1.Departamento_cod_departamento;", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string puesto = TablaTipo.Rows[0]["puesto"].ToString();

            if (puesto.Equals("Empleado"))
            {
                return "OK";
            }
            else
            {
                return "ERROR.";
            }
        }

        [WebMethod]
        public string EditarDirector(int user, String contraseña, String direccion, int telefono)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Usuario SET pass = '" + contraseña + "' , direccion = '" + direccion + "' , telefono = " + telefono + " WHERE cod_usuario = " + user + ";", con);
            SqlDataReader dr;
            dr = CMD.ExecuteReader();
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
        public string NuevoEmpleado(int codigousuario, int codigoempleado, String nombre, String apellido, String direccion, int telefono, int sueldo, String sucursal, String departamento)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT INTO Usuario VALUES (" + codigousuario + ", 'empleado" + codigousuario + "', 1234, '" + nombre + "', '" + apellido + "', '" + direccion + "', " + telefono + ", 2);",con);
            SqlCommand MCD = new SqlCommand("INSERT INTO Empleado VALUES (" + codigoempleado + ", 'Empleado'," + sueldo + ", " + codigousuario + ", " + sucursal + ", " + departamento + ");", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string EditarDatosEmpleado(int user, int sueldo, String puesto, int sucursal, int departamento)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Empleado SET sueldo = " + sueldo + " , puesto = '" + puesto + "' , Sucursal_cod_sucursal = " + sucursal + " , Departamento_cod_departamento= " + departamento + " WHERE Usuario_cod_usuario = " + user + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string EliminarEmpleado(int codigousuario)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("DELETE FROM Empleado WHERE Usuario_cod_usuario = " + codigousuario + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string EliminarUsuario(int codigousuario)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand MCD = new SqlCommand("DELETE FROM Usuario WHERE cod_usuario = " + codigousuario + ";", con);
            MCD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string NuevoPaquete(int codpaq, int peso, int precio, String estado, int dpi, String codempleado, String categoria)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT into Paquete values (" + codpaq + "," + peso + "," + precio + ", '" + estado + "', " + dpi + "," + codempleado + ", '" + categoria + "')", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string AgregarPaqueteLote(int cod_lote, String fecha, int codpaq, int codsuc)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT into LotePaquete values (" + cod_lote + ",'" + fecha + "'," + codpaq + "," + codsuc + ")", con);
            SqlCommand MCD = new SqlCommand("UPDATE Paquete SET estado = 'Agregado a Lote " + cod_lote + "' WHERE cod_paquete =" + codpaq + ";", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string NuevoLote(int cod_lote, int codsuc)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("INSERT into Lote values (" + cod_lote + "," + codsuc + ")", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string EstadoPaqueteLote(int codlote)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Paquete SET estado = 'Enviado por Lote " + codlote + "' WHERE estado = 'Agregado a Lote " + codlote + "';", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string EstadoPaqueteLote1(int codlote)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Paquete SET estado = 'En Sucursal' WHERE estado = 'Enviado por Lote " + codlote + "';", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string PaquetePerdido(String codpaquete)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Paquete SET estado = 'Perdido' WHERE cod_paquete = " + codpaquete + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string LimpiarTabla(String tabla)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("TRUNCATE TABLE " + tabla + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string PaqueteEntregado(String codpaquete)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Paquete SET estado = 'Entregado' WHERE cod_paquete = " + codpaquete + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string PaqueteDevolucion(String codpaquete)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("UPDATE Paquete SET estado = 'Devuelto' WHERE cod_paquete = " + codpaquete + ";", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

        [WebMethod]
        public string BusquedaCasilla(String nombre, String apellido)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT A1.casilla FROM Cliente A1, Usuario A2 WHERE A2.nombre = '" + nombre + "' AND A2.apellido = '" + apellido + "' AND A2.cod_usuario = A1.Usuario_cod_usuario;", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string casilla = TablaTipo.Rows[0]["casilla"].ToString();

            if (casilla.Equals(""))
            {
                return "ERROR";
            }
            else
            {
                return casilla;
            }
        }

        [WebMethod]
        public string NumeroEmpleados(String codsuc)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT COUNT(Sucursal_cod_sucursal) Cuenta FROM Empleado WHERE Sucursal_cod_sucursal = " + codsuc + ";", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string noempleados = TablaTipo.Rows[0]["Cuenta"].ToString();

            return noempleados;
        }

        [WebMethod]
        public string MaxNumeroEmpleados(String codsuc)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT capacidad_max_empleados FROM Sucursal WHERE cod_sucursal = " + codsuc + ";", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string maxnoempleados = TablaTipo.Rows[0]["capacidad_max_empleados"].ToString();

            return maxnoempleados;
        }

        [WebMethod]
        public string Pais(int codusuario)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter N = new SqlDataAdapter("SELECT A3.pais FROM Usuario A1, Sucursal A2, Sede A3, Empleado A4 WHERE A1.cod_usuario = " + codusuario + " AND A1.cod_usuario = A4.Usuario_cod_usuario AND A4.Sucursal_cod_sucursal = A2.cod_sucursal AND A2.Sede_cod_sede = A3.cod_sede;", con);
            DataSet DS = new DataSet();
            N.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string pais = TablaTipo.Rows[0]["pais"].ToString();

            return pais;
        }
    }
}
