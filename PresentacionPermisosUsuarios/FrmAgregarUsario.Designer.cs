namespace PresentacionPermisosUsuarios
{
    partial class FrmAgregarUsario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFDN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Lbl = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcontra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 140);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // txtFDN
            // 
            this.txtFDN.Location = new System.Drawing.Point(358, 274);
            this.txtFDN.Name = "txtFDN";
            this.txtFDN.Size = new System.Drawing.Size(239, 31);
            this.txtFDN.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(358, 199);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(239, 31);
            this.txtAP.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Apellido Paterno";
            // 
            // txtAM
            // 
            this.txtAM.Location = new System.Drawing.Point(87, 274);
            this.txtAM.Name = "txtAM";
            this.txtAM.Size = new System.Drawing.Size(239, 31);
            this.txtAM.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 199);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 31);
            this.txtNombre.TabIndex = 26;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(82, 246);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(174, 25);
            this.Lbl.TabIndex = 24;
            this.Lbl.Text = "Apellido Materno";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.BtnSalir.BackgroundImage = global::PresentacionPermisosUsuarios.Properties.Resources.cerrar;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Location = new System.Drawing.Point(623, 51);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(38, 35);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = global::PresentacionPermisosUsuarios.Properties.Resources.salvado;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(284, 394);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(133, 38);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(87, 353);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(239, 31);
            this.TxtRFC.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Rfc";
            // 
            // Txtcontra
            // 
            this.Txtcontra.Location = new System.Drawing.Point(358, 353);
            this.Txtcontra.Name = "Txtcontra";
            this.Txtcontra.Size = new System.Drawing.Size(239, 31);
            this.Txtcontra.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Password";
            // 
            // FrmAgregarUsario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 478);
            this.Controls.Add(this.Txtcontra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFDN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.Lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmAgregarUsario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarUsario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtcontra;
        private System.Windows.Forms.Label label4;
    }
}