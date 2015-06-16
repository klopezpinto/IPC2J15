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
    public partial class Prestar : Form
    {
        public Prestar()
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

                String response = ws.PrestarLibro(carnet, 1, codlibro);
                if (!response.Equals("ERRORES"))
                {
                    String responses = ws.PLibro(carnet, 1, codlibro);
                    if (!responses.Equals("ERROR"))
                    {
                        MessageBox.Show("Prestamo autorizado!");
                        txtcarnet.Text = ""; txtcodlibro.Text = "";
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Quieres reservar el libro para cuando este disponible?", "RESERVACIÓN", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            ws.ReservarLibro(carnet, 3, codlibro);
                            MessageBox.Show("Reservacion autorizada!");
                            txtcarnet.Text = ""; txtcodlibro.Text = "";
                        }
                        if (dialogResult == DialogResult.No)
                        {
                            txtcarnet.Text = ""; txtcodlibro.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede prestar mas de 5 veces. Debes de devolver un libro para volver a prestar un libro.");
                    txtcarnet.Text = ""; txtcodlibro.Text = "";
                }
            }
            else
            {
                MessageBox.Show("El prestamo no se autorizo, todos los campos deben ser ingresados");
            }
        }
    }
}
