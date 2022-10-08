using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPermisosUsuarios;
using ManejadorPermisoUsuarios;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas MH;
        public static Herramientas H = new Herramientas("", "", 0, "", "");
        int Columna = 0, fila = 0;
        public FrmHerramientas()
        {
            InitializeComponent();
            MH=new ManejadorHerramientas();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MH.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            H.CodigoHerramientas = "-1";
            FrmAgregarHerramienta frmAgregarHerramienta = new FrmAgregarHerramienta();
            frmAgregarHerramienta.ShowDialog();
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            H.CodigoHerramientas = DtgMostrar.Rows[fila].Cells[0].Value.ToString();
            H.Nombre = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            H.Medida =double.Parse(DtgMostrar.Rows[fila].Cells[2].Value.ToString());
            H.Marca = DtgMostrar.Rows[fila].Cells[3].Value.ToString();
            H.Descripcion = DtgMostrar.Rows[fila].Cells[4].Value.ToString();
            switch (Columna)
            {
                case 5: { FrmAgregarHerramienta frmAgregarHerramienta = new FrmAgregarHerramienta();
                        frmAgregarHerramienta.ShowDialog();
                    } break;
                case 6: { MH.Borrar(H); } break;
                default:
                    break;
            }
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
