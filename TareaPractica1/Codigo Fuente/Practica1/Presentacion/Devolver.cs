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
    public partial class Devolver : Form
    {
        public Devolver()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!txtcarnet.Text.Equals("") && !txtcodlibro.Text.Equals(""))
            {
                WebService.WebS ws = new WebService.WebS();
                int carnet = Int32.Parse(txtcarnet.Text);
                int codlibro = Int32.Parse(txtcodlibro.Text);

                String response = ws.DevolverLibro(carnet, 2, codlibro);
                if (!response.Equals("ERROR"))
                {
                    MessageBox.Show("Devolucion aceptada!");
                    txtcarnet.Text = ""; txtcodlibro.Text = "";
                }
                else
                {
                    MessageBox.Show("Error en la devolucion. Intenta nuevamente");
                }               
            }
            else
            {
                MessageBox.Show("La devolucion no se acepto, todos los campos deben ser ingresados");
            }    
        }
    }
}
