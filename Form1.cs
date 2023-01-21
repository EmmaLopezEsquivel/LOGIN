using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUnisur
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // usuario = "emmanuel" password= emma10
            string usuario = txbxUsuario.Text;
            string password = txbxPassword.Text;

            if(this.txbxUsuario.Text == "emmanuel" && this.txbxPassword.Text == "emma10")
            {
                intentos = 0;

                // picture.Image = new Bitmap(@"C:\Users\NEMEZIZ\source\repos\LoginUnisur\desbloqueospiderman.jpg");

                MessageBox.Show("BIENVENIDO");

 
            }
            else if (intentos <= 3 && intentos > 0)
            {
                AVISOS.Text = "solo tienes "+Convert.ToString(intentos)+ "  intentos mas";
                intentos--;
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
                // intentos++;
                Application.Exit();
            }
        }
    }
}
