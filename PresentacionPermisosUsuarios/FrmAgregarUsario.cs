using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorPermisoUsuarios;
using EntidadesPermisosUsuarios;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmAgregarUsario : Form
    {
        ManejadorUsuarios Mu;
        public FrmAgregarUsario()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();
            if (FrmUsuarios.U.Idusuario>0)
            {
                txtNombre.Text = FrmUsuarios.U.Nombre;
                txtAP.Text = FrmUsuarios.U.Apellidop;
                txtAM.Text = FrmUsuarios.U.ApellidoM;
                txtFDN.Text = FrmUsuarios.U.Fdn;
                TxtRFC.Text = FrmUsuarios.U.Rfc;
                Txtcontra.Text = FrmUsuarios.U.Contra;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios Us = new Usuarios(0,"","","","","","");
            Us.Idusuario = FrmUsuarios.U.Idusuario;
            Us.Nombre = txtNombre.Text;
            Us.Apellidop = txtAP.Text;
            Us.ApellidoM = txtAM.Text;
            Us.Fdn = txtFDN.Text;
            Us.Rfc = TxtRFC.Text;
            Us.Contra = Txtcontra.Text;
            Mu.Guardar(Us);
            MessageBox.Show("Guardado exitosamente");
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
