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
using AccesoDatos;
namespace PresentacionPermisosUsuarios
{
    public partial class Frmmenu : Form
    {
        FrmLogin FrmLogin;
        AccesoDatosPermisos Adp;
        ManejaddorPermisos Mp;

        public static bool Admin, Ejecutivo, Empleado;
        public Frmmenu()
        {
            InitializeComponent();
            Mp = new ManejaddorPermisos();
            FrmLogin  = new FrmLogin();
            Adp = new AccesoDatosPermisos();
        }
        
        public void cosa()
        {
            
            DataSet ds = Adp.Mostrar(FrmLogin.UsuarioEpiko);
            MessageBox.Show(FrmLogin.UsuarioEpiko);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < 1; i++)
            {
                Admin = bool.Parse(dt.Rows[i]["Administrador"].ToString());
                Ejecutivo = bool.Parse(dt.Rows[i]["Ejecutivo"].ToString());
                Empleado = bool.Parse(dt.Rows[i]["Empleado"].ToString());
                Mp.Lospermisus(Admin, Ejecutivo, Empleado, TsbUsuario, TSBPERMISOS);
            }
                

        }

        private void TPBREGRESAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void TSBHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas frmHerramientas = new FrmHerramientas();
            frmHerramientas.ShowDialog();
        }

        private void TsbUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void TSBPERMISOS_Click(object sender, EventArgs e)
        {
            FrmPermisos frmPermisos = new FrmPermisos();
            frmPermisos.ShowDialog();
        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            cosa();
        }
    }
}
