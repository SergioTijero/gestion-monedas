namespace avancesssss.vistas
{
    partial class FrmUsuarioCliente
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
            this.txtgestor = new System.Windows.Forms.GroupBox();
            this.dgvUsuarioCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.txtgestor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtgestor
            // 
            this.txtgestor.Controls.Add(this.dgvUsuarioCliente);
            this.txtgestor.Location = new System.Drawing.Point(601, 47);
            this.txtgestor.Name = "txtgestor";
            this.txtgestor.Size = new System.Drawing.Size(1024, 710);
            this.txtgestor.TabIndex = 10;
            this.txtgestor.TabStop = false;
            this.txtgestor.Text = "Usuario Cliente";
            // 
            // dgvUsuarioCliente
            // 
            this.dgvUsuarioCliente.AllowUserToAddRows = false;
            this.dgvUsuarioCliente.AllowUserToDeleteRows = false;
            this.dgvUsuarioCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarioCliente.Location = new System.Drawing.Point(3, 27);
            this.dgvUsuarioCliente.Name = "dgvUsuarioCliente";
            this.dgvUsuarioCliente.ReadOnly = true;
            this.dgvUsuarioCliente.RowHeadersWidth = 82;
            this.dgvUsuarioCliente.RowTemplate.Height = 33;
            this.dgvUsuarioCliente.Size = new System.Drawing.Size(1018, 680);
            this.dgvUsuarioCliente.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.txtSaldoActual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(-73, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 494);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
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
            this.btnRegistrar.Location = new System.Drawing.Point(85, 383);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 42);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(273, 383);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 42);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(57, 292);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(139, 25);
            this.Label.TabIndex = 7;
            this.Label.Text = "Saldo Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(226, 225);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(375, 31);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtlogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(226, 158);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(375, 31);
            this.txtnombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(226, 94);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(375, 31);
            this.txtid.TabIndex = 0;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(226, 292);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(375, 31);
            this.txtSaldoActual.TabIndex = 6;
            // 
            // FrmUsuarioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 805);
            this.Controls.Add(this.txtgestor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarioCliente";
            this.Text = "FrmUsuarioCliente";
            this.Load += new System.EventHandler(this.FrmUsuarioCliente_Load);
            this.txtgestor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtgestor;
        private System.Windows.Forms.DataGridView dgvUsuarioCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtSaldoActual;
    }
}