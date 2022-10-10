namespace PresentacionPermisosUsuarios
{
    partial class Frmmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbProductos = new System.Windows.Forms.ToolStripButton();
            this.TSBHerramientas = new System.Windows.Forms.ToolStripButton();
            this.TsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.TSBPERMISOS = new System.Windows.Forms.ToolStripButton();
            this.TPBREGRESAR = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbProductos,
            this.TSBHerramientas,
            this.TsbUsuario,
            this.TSBPERMISOS,
            this.TPBREGRESAR});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbProductos
            // 
            this.TsbProductos.AutoSize = false;
            this.TsbProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TsbProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbProductos.Image = global::PresentacionPermisosUsuarios.Properties.Resources.caja;
            this.TsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbProductos.Name = "TsbProductos";
            this.TsbProductos.Size = new System.Drawing.Size(40, 40);
            this.TsbProductos.Text = "Productos";
            this.TsbProductos.Click += new System.EventHandler(this.TsbProductos_Click);
            // 
            // TSBHerramientas
            // 
            this.TSBHerramientas.AutoSize = false;
            this.TSBHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TSBHerramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBHerramientas.Image = global::PresentacionPermisosUsuarios.Properties.Resources.configuraciones;
            this.TSBHerramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBHerramientas.Name = "TSBHerramientas";
            this.TSBHerramientas.Size = new System.Drawing.Size(40, 40);
            this.TSBHerramientas.Text = "Herramientas";
            this.TSBHerramientas.Click += new System.EventHandler(this.TSBHerramientas_Click);
            // 
            // TsbUsuario
            // 
            this.TsbUsuario.AutoSize = false;
            this.TsbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TsbUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbUsuario.Image = global::PresentacionPermisosUsuarios.Properties.Resources.perfil;
            this.TsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUsuario.Name = "TsbUsuario";
            this.TsbUsuario.Size = new System.Drawing.Size(40, 40);
            this.TsbUsuario.Text = "Usuarios";
            this.TsbUsuario.Click += new System.EventHandler(this.TsbUsuario_Click);
            // 
            // TSBPERMISOS
            // 
            this.TSBPERMISOS.AutoSize = false;
            this.TSBPERMISOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TSBPERMISOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPERMISOS.Image = global::PresentacionPermisosUsuarios.Properties.Resources.permiso;
            this.TSBPERMISOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPERMISOS.Name = "TSBPERMISOS";
            this.TSBPERMISOS.Size = new System.Drawing.Size(40, 40);
            this.TSBPERMISOS.Text = "Permisos";
            this.TSBPERMISOS.Click += new System.EventHandler(this.TSBPERMISOS_Click);
            // 
            // TPBREGRESAR
            // 
            this.TPBREGRESAR.AutoSize = false;
            this.TPBREGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TPBREGRESAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TPBREGRESAR.Image = global::PresentacionPermisosUsuarios.Properties.Resources.cerrar;
            this.TPBREGRESAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TPBREGRESAR.Name = "TPBREGRESAR";
            this.TPBREGRESAR.Size = new System.Drawing.Size(40, 40);
            this.TPBREGRESAR.Text = "Regresar";
            this.TPBREGRESAR.Click += new System.EventHandler(this.TPBREGRESAR_Click);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 491);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmmenu";
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbProductos;
        private System.Windows.Forms.ToolStripButton TSBHerramientas;
        private System.Windows.Forms.ToolStripButton TPBREGRESAR;
        private System.Windows.Forms.ToolStripButton TsbUsuario;
        private System.Windows.Forms.ToolStripButton TSBPERMISOS;
    }
}