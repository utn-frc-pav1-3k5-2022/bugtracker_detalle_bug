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
            string sql = "SELECT * FROM Bugs WHERE id_bug ='" + idBug + "'";
            DataTable dtBug = DataManager.GetInstance().ConsultaSQL(sql);
            txtTitulo.Text = dtBug.Rows[0]["titulo"].ToString();
            txtNroBug.Text = dtBug.Rows[0]["id_bug"].ToString();
            txtDescripcion.Text = dtBug.Rows[0]["descripcion"].ToString();
            txtFechaAlta.Text = dtBug.Rows[0]["fecha_alta"].ToString();
        }
    }
}
