using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class AsignarModificarUser : Form
    {
        public AsignarModificarUser()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte, txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.DeleteReporte( txtId);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.modificarReporte(txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarRe user = new AsignarRe();
            user.ShowDialog();
        }
    }
}
