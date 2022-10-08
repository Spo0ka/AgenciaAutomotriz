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
    public partial class FrmAgregarProductos : Form
    {
        ManejadorProductos Mp;
        public FrmAgregarProductos()
        {
            InitializeComponent();
            Mp = new ManejadorProductos();
            if (FrmProductos.P.CodigoDeBarras !="-1")
            {
                txtCB.Text = FrmProductos.P.CodigoDeBarras;
                txtDescripcion.Text = FrmProductos.P.Descripcion;
                txtMarca.Text=FrmProductos.P.Marca;
                txtNombre.Text = FrmProductos.P.Nombre;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Productos P = new Productos("","","","");
            P.CodigoDeBarras = txtCB.Text;
            P.Nombre = txtNombre.Text;
            P.Descripcion = txtDescripcion.Text;
            P.Marca = txtMarca.Text;

            Mp.Guardar(P);
            MessageBox.Show("Datos guardados");
            Close();

        }
    }
}
