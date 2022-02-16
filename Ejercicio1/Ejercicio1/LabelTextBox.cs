using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{

    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }
    public partial class LabelTextBox : UserControl
    {

        private ePosicion posicion = ePosicion.IZQUIERDA;

        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o a la DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if(Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                    if (CambiaPosicion != null)
                    {
                        CambiaPosicion(this, new EventArgs());
                    }
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        private int separacion = 0;

        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Design")]
        [Description("Enlaza con la propiedad PasswordChar del Textbox")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;

        [Category("")]
        [Description("Se lanza cuando la propiedad Separación cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("Cambio texto")]
        [Description("Se lanza cuando sucede el evento TextChanged de txt")]
        public event System.EventHandler TxtChanged;

        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);

                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;

                case ePosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    //txt.Width = this.Width - lbl.Width - Separacion;
                    this.Width = txt.Width + lbl.Width + Separacion;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void txt_TxtChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }
    }
}
