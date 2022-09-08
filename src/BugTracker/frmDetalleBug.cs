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
            string sql = "Select B.id_bug, B.titulo, B.fecha_alta, b.descripcion, P.nombre AS Nombre_Producto, C.nombre AS Nombre_Criticidad, E.nombre AS Nombre_Estado, PR.nombre AS Nombre_Prioridad from Bugs B join Productos P on B.id_producto = P.id_producto join Criticidades C on B.id_criticidad = C.id_criticidad join Estados E on B.id_estado = E.id_estado join Prioridades PR on B.id_prioridad = PR.id_prioridad where B.id_bug = '" + idBug + "'";
            DataTable dtBug = DataManager.GetInstance().ConsultaSQL(sql);
            txtNroBug.Text = idBug.ToString();
            txtTitulo.Text = dtBug.Rows[0]["Titulo"].ToString();
            txtFechaAlta.Text = dtBug.Rows[0]["fecha_alta"].ToString();
            txtDescripcion.Text = dtBug.Rows[0]["descripcion"].ToString();
            txtCriticidad.Text = dtBug.Rows[0]["Nombre_Criticidad"].ToString();
            txtEstado.Text = dtBug.Rows[0]["Nombre_Estado"].ToString();
            txtPrioridad.Text = dtBug.Rows[0]["Nombre_Prioridad"].ToString();
            txtProducto.Text = dtBug.Rows[0]["Nombre_Producto"].ToString(); 
        }
    }
}
