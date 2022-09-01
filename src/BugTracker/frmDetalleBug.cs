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
            DataTable dt;
            string query = "SELECT * FROM BUGS WHERE id_bug = " + idBug;

            dt = DataManager.GetInstance().ConsultaSQL(query);

            this.txtCriticidad.Text = dt.Rows[0]["id_criticidad"].ToString();
            this.txtDescripcion.Text = dt.Rows[0]["descripcion"].ToString();
            this.txtEstado.Text = dt.Rows[0]["id_estado"].ToString();
            this.txtFechaAlta.Text = dt.Rows[0]["fecha_alta"].ToString();
            this.txtNroBug.Text = dt.Rows[0]["id_bug"].ToString();
            this.txtPrioridad.Text = dt.Rows[0]["id_prioridad"].ToString();
            this.txtProducto.Text = dt.Rows[0]["id_producto"].ToString();
            this.txtTitulo.Text = dt.Rows[0]["titulo"].ToString();
        }
    }
}
