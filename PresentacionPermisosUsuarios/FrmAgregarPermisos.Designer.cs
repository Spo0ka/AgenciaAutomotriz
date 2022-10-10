namespace PresentacionPermisosUsuarios
{
    partial class FrmAgregarPermisos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.laskd = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.CmbAdm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbEje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEmp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 140);
            this.panel1.TabIndex = 4;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.BtnSalir.BackgroundImage = global::PresentacionPermisosUsuarios.Properties.Resources.cerrar;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Location = new System.Drawing.Point(553, 51);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(38, 35);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permisos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = global::PresentacionPermisosUsuarios.Properties.Resources.salvado;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(260, 386);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(88, 50);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // laskd
            // 
            this.laskd.AutoSize = true;
            this.laskd.Location = new System.Drawing.Point(30, 181);
            this.laskd.Name = "laskd";
            this.laskd.Size = new System.Drawing.Size(86, 25);
            this.laskd.TabIndex = 5;
            this.laskd.Text = "Usuario";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Items.AddRange(new object[] {
            "false",
            "true"});
            this.cmbUsuarios.Location = new System.Drawing.Point(35, 209);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(228, 33);
            this.cmbUsuarios.TabIndex = 7;
            // 
            // CmbAdm
            // 
            this.CmbAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdm.FormattingEnabled = true;
            this.CmbAdm.Items.AddRange(new object[] {
            "false",
            "true"});
            this.CmbAdm.Location = new System.Drawing.Point(352, 209);
            this.CmbAdm.Name = "CmbAdm";
            this.CmbAdm.Size = new System.Drawing.Size(228, 33);
            this.CmbAdm.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADMINISTRATIVO";
            // 
            // CmbEje
            // 
            this.CmbEje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEje.FormattingEnabled = true;
            this.CmbEje.Items.AddRange(new object[] {
            "false",
            "true"});
            this.CmbEje.Location = new System.Drawing.Point(35, 326);
            this.CmbEje.Name = "CmbEje";
            this.CmbEje.Size = new System.Drawing.Size(228, 33);
            this.CmbEje.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "EJECTIVO";
            // 
            // CmbEmp
            // 
            this.CmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmp.FormattingEnabled = true;
            this.CmbEmp.Items.AddRange(new object[] {
            "false",
            "true"});
            this.CmbEmp.Location = new System.Drawing.Point(352, 326);
            this.CmbEmp.Name = "CmbEmp";
            this.CmbEmp.Size = new System.Drawing.Size(228, 33);
            this.CmbEmp.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "EMPLEADO";
            // 
            // FrmAgregarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 510);
            this.Controls.Add(this.CmbEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbEje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbAdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.laskd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAgregarPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPermisos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label laskd;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox CmbAdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbEje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEmp;
        private System.Windows.Forms.Label label5;
    }
}