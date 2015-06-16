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
    public partial class AgregarLibro : Form
    {
        public AgregarLibro()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!txtisbn.Text.Equals("") && !txtnombre.Text.Equals("") && !txtpaginas.Text.Equals("") && !txtexistencias.Text.Equals("") && !txttema.Text.Equals("") && !txtautor.Text.Equals(""))
            {
                WebService.WebS ws = new WebService.WebS();
                int isbn = Int32.Parse(txtisbn.Text);
                string nombre = txtnombre.Text;
                int noexi = Int32.Parse(txtexistencias.Text);
                int nopag = Int32.Parse(txtpaginas.Text);
                string autor = txtautor.Text;
                string tema = txttema.Text;

                String response = ws.AgregarLibro(isbn, nombre, noexi, nopag, autor, tema);
                if (response.Equals("Agregado!"))
                {
                    MessageBox.Show("Nuevo libro agregado correctamente!");
                    txtisbn.Text = ""; txtexistencias.Text = ""; txtpaginas.Text = "";
                    txtnombre.Text = ""; txtautor.Text = ""; txttema.Text = "";
                }
                else
                {
                    MessageBox.Show("No se puede agregar un nuevo libro, revise los datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar un nuevo libro, todos los campos deben ser ingresados");
            }            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
        }
    }
}
