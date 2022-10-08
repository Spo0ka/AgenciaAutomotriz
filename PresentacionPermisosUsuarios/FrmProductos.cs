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
    public partial class FrmProductos : Form
    {
        ManejadorProductos MP;
        public static Productos P = new Productos("","","","");
        int fila = 0, columna = 0;
        public FrmProductos()
        {
            InitializeComponent();
            MP = new ManejadorProductos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            P.CodigoDeBarras = "-1";
            FrmAgregarProductos frmAgregarProductos = new FrmAgregarProductos();
            frmAgregarProductos.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P.CodigoDeBarras = DtgMostrar.Rows[fila].Cells[0].Value.ToString();
            P.Nombre = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            P.Descripcion = DtgMostrar.Rows[fila].Cells[2].Value.ToString();
            P.Marca = DtgMostrar.Rows[fila].Cells[3].Value.ToString();
            switch (columna)
            {
                case 4: { FrmAgregarProductos frmAgregarProductos = new FrmAgregarProductos();
                        frmAgregarProductos.ShowDialog();
                    }break;
                case 5: { MP.Borrar(P); } break;
                default:
                    break;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            actualizar();
            
        }

        void actualizar() {
            MP.Mostrar(DtgMostrar, TxtBuscar.Text);
        }
    }
}
