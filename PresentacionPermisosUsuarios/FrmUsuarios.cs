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
using System.Linq.Expressions;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios Mu;
        public static Usuarios U = new Usuarios(0, "", "", "", "", "", "");
        int columna = 0, fila = 0;
        bool admin, ejecutivo;
        public FrmUsuarios()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            U.Idusuario = -1;
            FrmAgregarUsario frmAgregarUsario = new FrmAgregarUsario();
            frmAgregarUsario.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Mu.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            U.Idusuario = int.Parse(DtgMostrar.Rows[fila].Cells[0].Value.ToString());
            U.Nombre = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            U.Apellidop = DtgMostrar.Rows[fila].Cells[2].Value.ToString();
            U.ApellidoM = DtgMostrar.Rows[fila].Cells[3].Value.ToString();
            U.Fdn = DtgMostrar.Rows[fila].Cells[4].Value.ToString();
            U.Rfc = DtgMostrar.Rows[fila].Cells[5].Value.ToString();
            U.Contra = DtgMostrar.Rows[fila].Cells[6].Value.ToString();
            switch (columna)
            {
                case 7: { FrmAgregarUsario frmAgregarUsario = new FrmAgregarUsario();
                        frmAgregarUsario.ShowDialog();
                    } break;
                case 8: {
                        if (admin == true)
                        {
                            Mu.Borrar(U);
                        }
                        else
                        {
                            MessageBox.Show("No hay permisos");
                        }
                         } break;
                default: break;
            }
        }
        void cosa() 
        {
            admin = Frmmenu.Admin;
            ejecutivo = Frmmenu.Ejecutivo;

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cosa();
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
