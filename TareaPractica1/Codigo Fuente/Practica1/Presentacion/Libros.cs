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
    public partial class Libros : Form
    {
        SqlConnection con = new SqlConnection("Server=HPKELP\\SQLEXPRESSK; Initial Catalog=Biblioteca;Trusted_Connection=YES;");

        public Libros()
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
            SqlDataAdapter CMD = new SqlDataAdapter("select Nombre, Autor, Existencias, Disponibles, Prestados, Reservados from Libro;", con);
            DataSet DS = new DataSet();
            CMD.Fill(DS, "Libro");
            dgvlibros.DataSource = DS;
            dgvlibros.DataMember = "Libro";
            con.Close();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            cargarlibros();
        }
    }
}
