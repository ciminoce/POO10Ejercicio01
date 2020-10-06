using System;
using System.Collections.Generic;
using System.Windows.Forms;
using POO10Ejercicio01.Datos;
using POO10Ejercicio01.Entidades;

namespace POO10Ejercicio01.Windows
{
    public partial class FrmPuntos : Form
    {
        public FrmPuntos()
        {
            InitializeComponent();
        }

        private RepositorioDePuntos _repositorio;
        private List<Punto> _lista;
        private void FrmPuntos_Load(object sender, EventArgs e)
        {
            _repositorio=new RepositorioDePuntos();
            _lista = _repositorio.GetLista();
            MostrarDatosEnGrilla();
            MostrarCantidadDeRegistros();
        }

        private void MostrarCantidadDeRegistros()
        {
            CantidadTextBox.Text = _repositorio.GetCantidad().ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            PuntosDataGridView.Rows.Clear();
            foreach (var punto in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, punto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            PuntosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Punto punto)
        {
            r.Cells[colX.Index].Value = punto.CoordenadaX;
            r.Cells[colY.Index].Value = punto.CoordenadaY;

            r.Tag = punto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(PuntosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            if (_repositorio.EstaModificado)
            {
                _repositorio.GuardarDatosEnArchivo();
            }
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmPuntosAE frm = new FrmPuntosAE {Text = "Agregar Punto"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                Punto punto = frm.GetPunto();
                if (!_repositorio.ExistePunto(punto))
                {
                    _repositorio.Agregar(punto);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, punto);
                    AgregarFila(r);
                    MostrarCantidadDeRegistros();
                    MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Punto repetido", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    
                }
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (PuntosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = PuntosDataGridView.SelectedRows[0];
            Punto punto = (Punto) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja el punto {punto.ToString()}?", "Confirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                _repositorio.Borrar(punto);
                PuntosDataGridView.Rows.Remove(r);
                MostrarCantidadDeRegistros();
                MessageBox.Show("Registro Borrado", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (PuntosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = PuntosDataGridView.SelectedRows[0];
            Punto punto = (Punto) r.Tag;
            Punto puntoAuxiliar =(Punto) punto.Clone();
            FrmPuntosAE frm = new FrmPuntosAE {Text = "Edición de un Punto"};
            frm.SetPunto(puntoAuxiliar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                puntoAuxiliar = frm.GetPunto();

                if (!_repositorio.ExistePunto(puntoAuxiliar))
                {
                    
                   _repositorio.Modificar(punto, puntoAuxiliar);
                    SetearFila(r, puntoAuxiliar);
                    _repositorio.EstaModificado = true;
                    MessageBox.Show("Registro Editado", "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    SetearFila(r, punto);
                    MessageBox.Show("Registro Repetido", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    
                }

            }


        }
    }
}
