using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebS
    /// </summary>
    [WebService(Namespace = "http://localhost/WebService", Name = "WebServicePrueba")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebS
    {
        [WebMethod]
        public string getTipo(string tipo)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter CMD = new SqlDataAdapter("select *from Tipo where idTipo='" + tipo + "'", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "DATOS");

            DataTable TablaTipo = DS.Tables[0];
            string des = TablaTipo.Rows[0]["tdes"].ToString();

            return "El tipo es " + des;
        }

        [WebMethod]
        public string AgregarUsuario(int carnet, string nombre, int dpi, string direccion, int telefono)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Cliente values (" + carnet + ",'" + nombre + "'," + dpi + ",'" + direccion + "'," + telefono + ", 0)", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "Agregado!";
        }

        [WebMethod]
        public string AgregarLibro(int isbn, string nombre, int noexi, int nopag, string autor, string tema)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Libro values (" + isbn + ",'" + nombre + "'," + noexi + "," + nopag + ",'" + autor + "','" + tema + "'," + noexi + ", 0, 0)", con);
            CMD.ExecuteNonQuery();
            con.Close();

            return "Agregado!";
        }

        [WebMethod]
        public string PrestarLibro(int carnet, int tipo, int libro)
        {
            int tam;
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();
            SqlCommand N = new SqlCommand("SELECT Prestamo FROM Cliente WHERE carnet = " + carnet + ";");
            N.Connection = con;
            tam = (int)N.ExecuteScalar();

            if (tam >= 5)
            {
                return "ERRORES";
            }
            else
            {
                return "Agregado!";
            }
        }

        [WebMethod]
        public string PLibro(int carnet, int tipo, int libro)
        {
            int amt;
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

                SqlCommand M = new SqlCommand("SELECT Disponibles FROM Libro WHERE idLibro = " + libro + ";");
                M.Connection = con;
                amt = (int)M.ExecuteScalar();

                if (amt <= 0)
                {
                    return "ERROR";
                }
                else
                {
                    SqlCommand CMD = new SqlCommand("insert into Transaccion values (" + carnet + "," + tipo + "," + libro + ")", con);
                    SqlCommand MCD = new SqlCommand("UPDATE Libro SET Disponibles = Disponibles - 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                    SqlCommand DMC = new SqlCommand("UPDATE Libro SET Prestados = Prestados + 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                    SqlCommand MIO = new SqlCommand("UPDATE Cliente SET Prestamo = Prestamo + 1 FROM Transaccion WHERE carnet = " + carnet + ";", con);
                    CMD.ExecuteNonQuery();
                    MCD.ExecuteNonQuery();
                    DMC.ExecuteNonQuery();
                    MIO.ExecuteNonQuery();
                    con.Close();

                    return "Agregado!";
                }
        }

        [WebMethod]
        public string DevolverLibro(int carnet, int tipo, int libro)
        {
            int amt; int atm; int devre;
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand M = new SqlCommand("SELECT Disponibles FROM Libro WHERE idLibro = " + libro + ";");
            SqlCommand N = new SqlCommand("SELECT Existencias FROM Libro WHERE idLibro = " + libro + ";");
            M.Connection = con;
            N.Connection = con;
            amt = (int)M.ExecuteScalar();
            atm = (int)N.ExecuteScalar();
            if (amt >= atm)
            {
                return "ERROR";
            }
            else
            {
                SqlCommand CMD = new SqlCommand("insert into Transaccion values (" + carnet + "," + tipo + "," + libro + ")", con);
                SqlCommand MCD = new SqlCommand("UPDATE Libro SET Disponibles = Disponibles + 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                SqlCommand DMC = new SqlCommand("UPDATE Libro SET Prestados = Prestados - 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                SqlCommand MIO = new SqlCommand("UPDATE Cliente SET Prestamo = Prestamo - 1 FROM Transaccion WHERE carnet = " + carnet + ";", con);
                CMD.ExecuteNonQuery();
                MCD.ExecuteNonQuery();
                DMC.ExecuteNonQuery();
                MIO.ExecuteNonQuery();

                SqlCommand re = new SqlCommand("SELECT Reservados FROM Libro WHERE idLibro = " + libro + ";");
                re.Connection = con;
                devre = (int)re.ExecuteScalar();
                if (devre == 0){
                }
                else
                {
                SqlCommand qw = new SqlCommand("UPDATE Libro SET Reservados = Reservados - 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                SqlCommand bb = new SqlCommand("insert into Transaccion values (" + carnet + "," + "1" + "," + libro + ")", con);
                SqlCommand wq = new SqlCommand("UPDATE Libro SET Prestados = Prestados + 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                SqlCommand aa = new SqlCommand("UPDATE Libro SET Disponibles = Disponibles - 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
                qw.ExecuteNonQuery();
                wq.ExecuteNonQuery();
                aa.ExecuteNonQuery();
                bb.ExecuteNonQuery();
                }
                con.Close();

                return "Agregado!";
            }
        }

        [WebMethod]
        public string ReservarLibro(int carnet, int tipo, int libro)
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlCommand CMD = new SqlCommand("insert into Transaccion values (" + carnet + "," + tipo + "," + libro + ")", con);
            SqlCommand MCD = new SqlCommand("UPDATE Libro SET Reservados = Reservados + 1 FROM Transaccion WHERE idLibro = " + libro + ";", con);
            SqlCommand MY = new SqlCommand("UPDATE Cliente SET Prestamo = Prestamo + 1 FROM Transaccion WHERE carnet = " + carnet + ";", con);
            CMD.ExecuteNonQuery();
            MCD.ExecuteNonQuery();
            MY.ExecuteNonQuery();
            con.Close();

            return "Libro Reservado!";
        }

        [WebMethod]
        public string CargarLibros()
        {
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);
            con.Open();

            SqlDataAdapter CMD = new SqlDataAdapter("select Nombre, Autor, Existencias, Disponibles, Prestados, Reservados from Libro;", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "Libro");

            return "Listo!";
        }
    }
}

