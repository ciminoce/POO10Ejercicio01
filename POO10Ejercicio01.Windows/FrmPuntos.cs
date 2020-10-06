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
    }
}
