using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class LibrosMPrestados : Form
    {
        SqlConnection con = new SqlConnection("Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;");

        public LibrosMPrestados()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
        }

        private void cargarlibros()
        {
            con.Open();
            SqlDataAdapter CMD = new SqlDataAdapter("SELECT A1.Nombre Nombre, COUNT(A2.Libro_idLibro) 'No. de veces Prestado' FROM Libro A1, Transaccion A2 WHERE A2.Tipo_idTipo = 1 AND A1.idLibro = A2.Libro_idLibro GROUP BY A1.Nombre ORDER BY COUNT(A2.Libro_idLibro) DESC;", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "Libro");
            dgvlibros.DataSource = DS;
            dgvlibros.DataMember = "Libro";
            con.Close();
        }

        private void LibrosMPrestados_Load(object sender, EventArgs e)
        {
            cargarlibros();
        }
    }
}
