using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox2.Posicion == Ejercicio1.ePosicion.IZQUIERDA)
            {
                labelTextBox2.Posicion = Ejercicio1.ePosicion.DERECHA;
                this.Text = ""+Ejercicio1.ePosicion.DERECHA;
                button1.Text = "IZQUIERDA";
            }
            else
            {
                labelTextBox2.Posicion = Ejercicio1.ePosicion.IZQUIERDA;
                this.Text = "" + Ejercicio1.ePosicion.IZQUIERDA;
                button1.Text = "DERECHA";
            }
        }
    }
}
