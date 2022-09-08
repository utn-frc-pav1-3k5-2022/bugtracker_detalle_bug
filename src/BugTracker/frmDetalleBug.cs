using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmDetalleBug : Form
    {
        public frmDetalleBug()
        {
            InitializeComponent();

        }
              

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void InicializarDetalleBug(int idBug)
        {
            string sql = " SELECT b.id_bug, b.titulo, p.nombre 'producto', e.nombre 'estado', b.fecha_alta, b.descripcion, pri.nombre 'prioridad', cri.nombre 'criticidad' FROM Bugs b JOIN Productos p ON b.id_producto = p.id_producto JOIN estados e ON b.id_estado = e.id_estado JOIN prioridades pri ON b.id_prioridad = pri.id_prioridad JOIN criticidades cri ON b.id_criticidad = cri.id_criticidad WHERE id_bug = '" + idBug + "'";
            DataTable dtbug = DataManager.GetInstance().ConsultaSQL(sql);
            txtNroBug.Text = idBug.ToString();
            txtTitulo.Text = dtbug.Rows[0]["Titulo"].ToString();
            txtProducto.Text = dtbug.Rows[0]["producto"].ToString();
            txtFechaAlta.Text = dtbug.Rows[0]["fecha_alta"].ToString();
            txtDescripcion.Text = dtbug.Rows[0]["descripcion"].ToString();
            txtEstado.Text = dtbug.Rows[0]["estado"].ToString();
            txtPrioridad.Text = dtbug.Rows[0]["prioridad"].ToString();
            txtCriticidad.Text = dtbug.Rows[0]["criticidad"].ToString();

        }
    }
}
