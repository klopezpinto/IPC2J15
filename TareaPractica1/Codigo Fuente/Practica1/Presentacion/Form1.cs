using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
            this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario frm = new AgregarUsuario();
            frm.Show();
            this.Hide();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarLibro frm = new AgregarLibro();
            frm.Show();
            this.Hide();
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolver frm = new Devolver();
            frm.Show();
            this.Hide();
        }

        private void prestarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Prestar frm = new Prestar();
            frm.Show();
            this.Hide();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros frm = new Libros();
            frm.Show();
            this.Hide();
        }

        private void librosMasPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrosMPrestados frm = new LibrosMPrestados();
            frm.Show();
            this.Hide();
        }
    }
}
