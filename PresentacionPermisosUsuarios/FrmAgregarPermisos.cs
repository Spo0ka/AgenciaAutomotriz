using ManejadorPermisoUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisosUsuarios;

namespace PresentacionPermisosUsuarios
{

    public partial class FrmAgregarPermisos : Form
    {
        ManejaddorPermisos Mp;
        public FrmAgregarPermisos()
        {
            InitializeComponent();
            Mp = new ManejaddorPermisos();
            Mp.ExportarUsuario(cmbUsuarios);
            if (FrmPermisos.P.Idpermisos>0)
            {
                cmbUsuarios.Text = FrmPermisos.NombreUsuario;
                CmbAdm.Text = FrmPermisos.P.Administrador.ToString();
                CmbEje.Text = FrmPermisos.P.Ejecutivo.ToString();
                CmbEmp.Text = FrmPermisos.P.Empleado.ToString();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos(0,0,false,false,false);
            p.Idpermisos = FrmPermisos.P.Idpermisos;
            p.FkUsuario = int.Parse(cmbUsuarios.SelectedValue.ToString());
            p.Administrador = bool.Parse(CmbAdm.Text);
            p.Ejecutivo = bool.Parse(CmbEje.Text);
            p.Empleado = bool.Parse(CmbEmp.Text);
            Mp.Guardar(p);
            Close();
        }
    }
}
