using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionPermisosUsuarios
{
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void TPBREGRESAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void TSBHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas frmHerramientas = new FrmHerramientas();
            frmHerramientas.ShowDialog();
        }

        private void TsbUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
