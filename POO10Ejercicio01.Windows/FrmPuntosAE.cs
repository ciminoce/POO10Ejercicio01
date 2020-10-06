using System;
using System.Windows.Forms;
using POO10Ejercicio01.Entidades;

namespace POO10Ejercicio01.Windows
{
    public partial class FrmPuntosAE : Form
    {
        public FrmPuntosAE()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Punto punto;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (punto==null)
                {
                    punto = new Punto();

                }
                punto.CoordenadaX = int.Parse(CoordenadaXTextBox.Text);
                punto.CoordenadaY = int.Parse(CoordenadaYTextBox.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(CoordenadaXTextBox.Text, out int X))
            {
                valido = false;
                errorProvider1.SetError(CoordenadaXTextBox,"Coordenada X mal ingresada");
            }
            if (!int.TryParse(CoordenadaYTextBox.Text, out int Y))
            {
                valido = false;
                errorProvider1.SetError(CoordenadaYTextBox,"Coordenada Y mal ingresada");
            }

            return valido;
        }

        public Punto GetPunto()
        {
            return punto;
        }

        public void SetPunto(Punto punto)
        {
            this.punto = punto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (punto!=null)
            {
                CoordenadaXTextBox.Text = punto.CoordenadaX.ToString();
                CoordenadaYTextBox.Text = punto.CoordenadaY.ToString();
            }
        }
    }
}
