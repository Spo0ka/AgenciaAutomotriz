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
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios Mu;
       
        public FrmLogin()
        {
            InitializeComponent();
            Mu = new ManejadorUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void BtnLOG_Click(object sender, EventArgs e)
        {
           bool Cosa = Mu.login(TxtUsuario.Text,TxtContra.Text);
            if (Cosa == true)
            {
                MessageBox.Show("EN DON CAMARON");
                Frmmenu frmmenu = new Frmmenu();
                frmmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("MI LOCO NINO ES LA BESTO QUINTILLIZA? O ES ENAMORAMIENTO");
            }
            
        }
    }
}
