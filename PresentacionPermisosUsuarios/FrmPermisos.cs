using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorPermisoUsuarios;
using EntidadesPermisosUsuarios;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmPermisos : Form
    {
        int columna = 0, fila = 0;
        ManejaddorPermisos Mp;
        public static Permisos P = new Permisos(0,0,false,false,false);
        public static string NombreUsuario = "";
        public FrmPermisos()
        {
            InitializeComponent();
            Mp = new ManejaddorPermisos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            P.Idpermisos = -1;
            FrmAgregarPermisos frmAgregarPermisos = new FrmAgregarPermisos();
            frmAgregarPermisos.ShowDialog();
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P.Idpermisos = int.Parse(DtgMostrar.Rows[fila].Cells[0].Value.ToString());
            NombreUsuario = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            P.Administrador = bool.Parse(DtgMostrar.Rows[fila].Cells[2].Value.ToString());
            P.Ejecutivo = bool.Parse(DtgMostrar.Rows[fila].Cells[3].Value.ToString());
            P.Empleado = bool.Parse(DtgMostrar.Rows[fila].Cells[4].Value.ToString());
            switch (columna)
            {
                case 5: {
                        
                            FrmAgregarPermisos frmAgregarHerramienta = new FrmAgregarPermisos();
                            frmAgregarHerramienta.ShowDialog();
                        
                    } break;
                case 6: { Mp.Borrar(P);  } break;
                default: break;
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mp.Mostrar(DtgMostrar, TxtBuscar.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
