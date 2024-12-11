namespace avancesssss.vistas
{
    partial class FrmUsuariogestor1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAcceso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtgestor = new System.Windows.Forms.GroupBox();
            this.dgvUsuarioGestor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.txtgestor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioGestor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAcceso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombre2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(466, 383);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 42);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(95, 383);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 42);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(279, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 42);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Acceso:";
            // 
            // txtAcceso
            // 
            this.txtAcceso.Location = new System.Drawing.Point(226, 292);
            this.txtAcceso.Name = "txtAcceso";
            this.txtAcceso.Size = new System.Drawing.Size(375, 31);
            this.txtAcceso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login:";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(226, 225);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(375, 31);
            this.txtlogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(226, 158);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(375, 31);
            this.txtnombre2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(226, 94);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(375, 31);
            this.txtid2.TabIndex = 0;
            // 
            // txtgestor
            // 
            this.txtgestor.Controls.Add(this.dgvUsuarioGestor);
            this.txtgestor.Location = new System.Drawing.Point(686, 58);
            this.txtgestor.Name = "txtgestor";
            this.txtgestor.Size = new System.Drawing.Size(1147, 710);
            this.txtgestor.TabIndex = 8;
            this.txtgestor.TabStop = false;
            this.txtgestor.Text = "Usuario Gestor";
            // 
            // dgvUsuarioGestor
            // 
            this.dgvUsuarioGestor.AllowUserToAddRows = false;
            this.dgvUsuarioGestor.AllowUserToDeleteRows = false;
            this.dgvUsuarioGestor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioGestor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarioGestor.Location = new System.Drawing.Point(3, 27);
            this.dgvUsuarioGestor.Name = "dgvUsuarioGestor";
            this.dgvUsuarioGestor.ReadOnly = true;
            this.dgvUsuarioGestor.RowHeadersWidth = 82;
            this.dgvUsuarioGestor.RowTemplate.Height = 33;
            this.dgvUsuarioGestor.Size = new System.Drawing.Size(1141, 680);
            this.dgvUsuarioGestor.TabIndex = 0;
            this.dgvUsuarioGestor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioGestor_CellContentClick);
            // 
            // FrmUsuariogestor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 790);
            this.Controls.Add(this.txtgestor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuariogestor1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Frmgestor1";
            this.Load += new System.EventHandler(this.Frmgestor1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtgestor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioGestor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAcceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.GroupBox txtgestor;
        private System.Windows.Forms.DataGridView dgvUsuarioGestor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}