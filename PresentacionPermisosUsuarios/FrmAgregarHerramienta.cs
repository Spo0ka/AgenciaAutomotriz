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
using ManejadorPermisoUsuarios;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmAgregarHerramienta : Form
    {
        ManejadorHerramientas Mh;
        public FrmAgregarHerramienta()
        {
            InitializeComponent();
            Mh = new ManejadorHerramientas();
            if (FrmHerramientas.H.CodigoHerramientas !="-1")
            {
                txtCh.Text = FrmHerramientas.H.CodigoHerramientas;
                txtDescripcion.Text = FrmHerramientas.H.Descripcion;
                txtMarca.Text = FrmHerramientas.H.Marca;
                txtMedida.Text = FrmHerramientas.H.Medida.ToString();
                txtNombre.Text = FrmHerramientas.H.Nombre;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Herramientas H = new Herramientas("","",0,"","");
            H.Marca = txtMarca.Text;
            H.Descripcion = txtDescripcion.Text;
            H.Nombre = txtNombre.Text;
            H.Medida = double.Parse(txtMedida.Text);
            H.CodigoHerramientas = txtCh.Text;
            Mh.Guardar(H);
            MessageBox.Show("Datos Guardados");
            Close();
        }
    }
}
