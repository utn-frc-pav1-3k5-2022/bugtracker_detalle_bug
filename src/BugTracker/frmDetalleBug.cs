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

            string sql = "SELECT bug.id_bug, " +
                          "bug.titulo," +
                          "bug.descripcion," +
                          "bug.fecha_alta," +
                          "bug.id_usuario_responsable," +
                          "responsable.usuario as responsable,  " +
                          "bug.id_usuario_asignado," +
                          "asignado.usuario as asignado," +
                          "bug.id_producto," +
                          "producto.nombre as producto, " +
                          "bug.id_prioridad," +
                          "prioridad.nombre as prioridad," +
                          "bug.id_criticidad," +
                          "criticidad.nombre as criticidad, " +
                          "bug.id_estado," +
                          "estado.nombre as estado" +
                      "  FROM Bugs as bug" +
                      "  LEFT JOIN Usuarios as responsable ON responsable.id_usuario = bug.id_usuario_responsable" +
                      "  LEFT JOIN Usuarios as asignado ON asignado.id_usuario = bug.id_usuario_asignado" +
                      " INNER JOIN Productos as producto ON producto.id_producto = bug.id_producto" +
                      " INNER JOIN Prioridades as prioridad ON prioridad.id_prioridad = bug.id_prioridad" +
                      " INNER JOIN Criticidades as criticidad ON criticidad.id_criticidad = bug.id_criticidad" +
                      " INNER JOIN Estados as estado ON estado.id_estado = bug.id_estado" +
                        " WHERE id_bug = '" + idBug + "'";

            DataTable dtBug = DataManager.GetInstance().ConsultaSQL(sql);
            txtTitulo.Text = dtBug.Rows[0]["titulo"].ToString();
            txtProducto.Text = dtBug.Rows[0]["producto"].ToString();
            /*txtNroBug.Text = dtBug.Rows[0]["id_bug"].ToString();
            txtProducto.Text = dtBug.Rows[0]["producto"].ToString();
            txtFechaAlta.Text = dtBug.Rows[0]["fecha_alta"].ToString();
            txtDescripcion.Text = dtBug.Rows[0]["descripcion"].ToString();
            txtEstado.Text = dtBug.Rows[0]["id_estado"].ToString();
            txtPrioridad.Text = dtBug.Rows[0]["id_prioridad"].ToString();
            txtCriticidad.Text = dtBug.Rows[0]["id_criticidad"].ToString();*/



        }
    }
}
