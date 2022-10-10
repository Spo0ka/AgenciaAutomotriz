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
         bool Admin = false, Ejecutivo = false, Empleado = false;
        Frmmenu F;
        public FrmHerramientas()
        {
            InitializeComponent();
            MH=new ManejadorHerramientas();
            F = new Frmmenu();
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
                case 5: {
                        if (Empleado)
                        {
                            MessageBox.Show("No tienes los permisos joven");
                        }
                        else
                        {
                            FrmAgregarHerramienta frmAgregarHerramienta = new FrmAgregarHerramienta();
                            frmAgregarHerramienta.ShowDialog();
                        }
                        
                    } break;
                case 6: {
                        if (Admin == true)
                        {
                            MH.Borrar(H);
                        }
                        else
                        {
                            MessageBox.Show("No tienes permisos");
                        }
                         } break;
                default:
                    break;
            }
        }
        void cosa()
        {
            Admin = Frmmenu.Admin;
            Ejecutivo = Frmmenu.Ejecutivo;
            Empleado = Frmmenu.Empleado;
            MH.Permisus(Admin, Ejecutivo, Empleado, BtnAgregar);
        }
        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            cosa();
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
