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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!txtcarnet.Text.Equals("") && !txtnombre.Text.Equals("") && !txtdpi.Text.Equals("") && !txtdireccion.Text.Equals("") && !txttelefono.Text.Equals(""))
            {
                WebService.WebS ws = new WebService.WebS();
                int carnet = Int32.Parse(txtcarnet.Text);
                string nombre = txtnombre.Text;
                int dpi = Int32.Parse(txtdpi.Text);
                string direccion = txtdireccion.Text;
                int telefono = Int32.Parse(txttelefono.Text);

                String response = ws.AgregarUsuario(carnet, nombre, dpi, direccion, telefono);
                if (response.Equals("Agregado!"))
                {
                    MessageBox.Show("Usuario agregado correctamente!");
                    txtcarnet.Text = ""; txtdireccion.Text = ""; txtdpi.Text = "";
                    txtnombre.Text = ""; txttelefono.Text = "";
                }
                else
                {
                    MessageBox.Show("La cuenta no pudo crearse, revise los datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("La cuenta no pudo crearse, todos los campos deben ser ingresados");
            }            
        }
    }
}
