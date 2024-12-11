namespace avancesssss.vistas
{
    partial class Frmtransaccion
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
            this.dgvTransaccion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUserCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUserGestor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdTransaccion = new System.Windows.Forms.TextBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.txtgestor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtgestor
            // 
            this.txtgestor.Controls.Add(this.dgvTransaccion);
            this.txtgestor.Location = new System.Drawing.Point(715, 75);
            this.txtgestor.Name = "txtgestor";
            this.txtgestor.Size = new System.Drawing.Size(1172, 710);
            this.txtgestor.TabIndex = 10;
            this.txtgestor.TabStop = false;
            this.txtgestor.Text = "Transacciones";
            // 
            // dgvTransaccion
            // 
            this.dgvTransaccion.AllowUserToAddRows = false;
            this.dgvTransaccion.AllowUserToDeleteRows = false;
            this.dgvTransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaccion.Location = new System.Drawing.Point(3, 27);
            this.dgvTransaccion.Name = "dgvTransaccion";
            this.dgvTransaccion.ReadOnly = true;
            this.dgvTransaccion.RowHeadersWidth = 82;
            this.dgvTransaccion.RowTemplate.Height = 33;
            this.dgvTransaccion.Size = new System.Drawing.Size(1166, 680);
            this.dgvTransaccion.TabIndex = 0;
            this.dgvTransaccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaccion_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdUserCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdUserGestor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdMoneda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdTransaccion);
            this.groupBox1.Location = new System.Drawing.Point(40, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 710);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(226, 489);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(375, 31);
            this.txtCantidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(226, 423);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(375, 31);
            this.txtPrecioVenta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio Venta:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(451, 580);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 42);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(65, 580);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 42);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(256, 580);
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
            this.label4.Location = new System.Drawing.Point(57, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id User Cliente:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIdUserCliente
            // 
            this.txtIdUserCliente.Location = new System.Drawing.Point(226, 292);
            this.txtIdUserCliente.Name = "txtIdUserCliente";
            this.txtIdUserCliente.Size = new System.Drawing.Size(375, 31);
            this.txtIdUserCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id User Gestor:";
            // 
            // txtIdUserGestor
            // 
            this.txtIdUserGestor.Location = new System.Drawing.Point(226, 225);
            this.txtIdUserGestor.Name = "txtIdUserGestor";
            this.txtIdUserGestor.Size = new System.Drawing.Size(375, 31);
            this.txtIdUserGestor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Moneda:";
            // 
            // txtIdMoneda
            // 
            this.txtIdMoneda.Location = new System.Drawing.Point(226, 158);
            this.txtIdMoneda.Name = "txtIdMoneda";
            this.txtIdMoneda.Size = new System.Drawing.Size(375, 31);
            this.txtIdMoneda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Transaccion:";
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.Location = new System.Drawing.Point(226, 94);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.Size = new System.Drawing.Size(375, 31);
            this.txtIdTransaccion.TabIndex = 0;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Location = new System.Drawing.Point(226, 357);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(375, 31);
            this.dtpFecha2.TabIndex = 15;
            this.dtpFecha2.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // Frmtransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 926);
            this.Controls.Add(this.txtgestor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmtransaccion";
            this.Text = "Frmtransaccion";
            this.Load += new System.EventHandler(this.Frmtransaccion_Load);
            this.txtgestor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtgestor;
        private System.Windows.Forms.DataGridView dgvTransaccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUserCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdUserGestor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdTransaccion;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
    }
}