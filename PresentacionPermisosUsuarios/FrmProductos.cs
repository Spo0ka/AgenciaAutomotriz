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
using AccesoDatos;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmProductos : Form
    {
        ManejadorProductos MP;
        FrmLogin FrmLogin;
        Frmmenu M;
       
        public static Productos P = new Productos("","","","");
        public static bool Admin = false, Ejecutivo = false, Empleado = false;
        int fila = 0, columna = 0;
        public FrmProductos()
        {
            InitializeComponent();
            MP = new ManejadorProductos();
            FrmLogin = new FrmLogin();
            M = new Frmmenu();
          
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
                case 4: {
                        if (Empleado == true)
                        {
                            MessageBox.Show("Nah mu amigo permisos naoh naoh");
                        }
                        else
                        {
                            FrmAgregarProductos frmAgregarProductos = new FrmAgregarProductos();
                            frmAgregarProductos.ShowDialog();
                        }
                        
                    }break;
                case 5: {
                        if (Admin == true)
                        {
                            MP.Borrar(P);
                        }
                        else
                        {
                            MessageBox.Show("OH OH NO PERMISOS");
                        }
                         } break;
                default:
                    break;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            actualizar();
            
        }

        public void cosa()
        {
            Admin = Frmmenu.Admin;
            Ejecutivo = Frmmenu.Ejecutivo;
            Empleado = Frmmenu.Empleado;
            MP.Permisus(Admin, Ejecutivo, Empleado, BtnAgregar);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cosa();
        }

        void actualizar() {
            MP.Mostrar(DtgMostrar, TxtBuscar.Text);
        }
    }
}
