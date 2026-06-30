namespace AlquilerApp_Proyecto.Forms
{
    partial class frmGestionAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAlquiler));
            lblFechaEmisión = new Label();
            label5 = new Label();
            lblCliente = new Label();
            label4 = new Label();
            txtEmpleado = new TextBox();
            lblEmpleado = new Label();
            lblFechaDevolucion = new Label();
            lblFechaEntrega = new Label();
            panel1 = new Panel();
            btnConsultar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRetornar = new Button();
            btnNuevo = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblCrudAlquiler = new Label();
            dgvAlquilerDetalle = new DataGridView();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaEmision = new DateTimePicker();
            dtpFechaEntrega = new DateTimePicker();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtCliente = new TextBox();
            lblEstado = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            cmbEstado = new ComboBox();
            btnAñadirCliente = new Button();
            txtSubtotal = new TextBox();
            lblSubTotal = new Label();
            txtIva = new TextBox();
            lblPorcentajeIva = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquilerDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblFechaEmisión
            // 
            lblFechaEmisión.AutoSize = true;
            lblFechaEmisión.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFechaEmisión.Location = new Point(30, 129);
            lblFechaEmisión.Name = "lblFechaEmisión";
            lblFechaEmisión.Size = new Size(163, 23);
            lblFechaEmisión.TabIndex = 87;
            lblFechaEmisión.Text = "Fecha de Emisión:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(21, 163);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 85;
            label5.Text = "*";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCliente.Location = new Point(38, 168);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(78, 23);
            lblCliente.TabIndex = 84;
            lblCliente.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(20, 207);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 83;
            label4.Text = "*";
            // 
            // txtEmpleado
            // 
            txtEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtEmpleado.Location = new Point(135, 203);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(212, 27);
            txtEmpleado.TabIndex = 81;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEmpleado.Location = new Point(32, 205);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(100, 23);
            lblEmpleado.TabIndex = 78;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFechaDevolucion.Location = new Point(463, 167);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(186, 23);
            lblFechaDevolucion.TabIndex = 77;
            lblFechaDevolucion.Text = "Fecha de devolución:";
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblFechaEntrega.Location = new Point(478, 129);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(165, 23);
            lblFechaEntrega.TabIndex = 76;
            lblFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 44, 56);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRetornar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(959, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 727);
            panel1.TabIndex = 88;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.BackColor = Color.FromArgb(5, 209, 135);
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.ImageAlign = ContentAlignment.MiddleRight;
            btnConsultar.Location = new Point(14, 384);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Padding = new Padding(0, 0, 10, 0);
            btnConsultar.Size = new Size(197, 61);
            btnConsultar.TabIndex = 72;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // btnRetornar
            // 
            btnRetornar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRetornar.BackColor = Color.FromArgb(111, 21, 30);
            btnRetornar.Cursor = Cursors.Hand;
            btnRetornar.FlatAppearance.BorderSize = 0;
            btnRetornar.FlatStyle = FlatStyle.Flat;
            btnRetornar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetornar.ForeColor = Color.White;
            btnRetornar.Image = (Image)resources.GetObject("btnRetornar.Image");
            btnRetornar.ImageAlign = ContentAlignment.MiddleRight;
            btnRetornar.Location = new Point(14, 600);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Padding = new Padding(0, 0, 10, 0);
            btnRetornar.Size = new Size(197, 51);
            btnRetornar.TabIndex = 46;
            btnRetornar.Text = "Salir";
            btnRetornar.TextAlign = ContentAlignment.MiddleLeft;
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(5, 209, 135);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(14, 298);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 10, 0);
            btnNuevo.RightToLeft = RightToLeft.No;
            btnNuevo.Size = new Size(197, 61);
            btnNuevo.TabIndex = 43;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 209, 135);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblCrudAlquiler);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 93);
            panel2.TabIndex = 89;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // lblCrudAlquiler
            // 
            lblCrudAlquiler.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCrudAlquiler.ForeColor = Color.White;
            lblCrudAlquiler.Location = new Point(189, 19);
            lblCrudAlquiler.Name = "lblCrudAlquiler";
            lblCrudAlquiler.Size = new Size(470, 56);
            lblCrudAlquiler.TabIndex = 28;
            lblCrudAlquiler.Text = "Gestion de Alquileres";
            lblCrudAlquiler.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvAlquilerDetalle
            // 
            dgvAlquilerDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquilerDetalle.Location = new Point(75, 298);
            dgvAlquilerDetalle.Name = "dgvAlquilerDetalle";
            dgvAlquilerDetalle.RowHeadersWidth = 51;
            dgvAlquilerDetalle.Size = new Size(803, 300);
            dgvAlquilerDetalle.TabIndex = 90;
            dgvAlquilerDetalle.RowHeaderMouseDoubleClick += dgvAlquilerDetalle_RowHeaderMouseDoubleClick;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(649, 163);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 27);
            dtpFechaDevolucion.TabIndex = 91;
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Location = new Point(199, 124);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(250, 27);
            dtpFechaEmision.TabIndex = 91;
            dtpFechaEmision.Value = new DateTime(2026, 6, 22, 10, 20, 13, 0);
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(649, 126);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(250, 27);
            dtpFechaEntrega.TabIndex = 92;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(678, 677);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 27);
            txtTotal.TabIndex = 94;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(616, 677);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 23);
            lblTotal.TabIndex = 93;
            lblTotal.Text = "Total:";
            // 
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Location = new Point(119, 167);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(198, 27);
            txtCliente.TabIndex = 96;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEstado.Location = new Point(476, 208);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 23);
            lblEstado.TabIndex = 95;
            lblEstado.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(16, 123);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 99;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(464, 125);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 100;
            label3.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(449, 159);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 101;
            label6.Text = "*";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(557, 203);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 86;
            // 
            // btnAñadirCliente
            // 
            btnAñadirCliente.Location = new Point(323, 166);
            btnAñadirCliente.Name = "btnAñadirCliente";
            btnAñadirCliente.Size = new Size(24, 29);
            btnAñadirCliente.TabIndex = 102;
            btnAñadirCliente.Text = "..";
            btnAñadirCliente.UseVisualStyleBackColor = true;
            btnAñadirCliente.Click += lblAñadirCliente_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubtotal.Location = new Point(678, 611);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(200, 27);
            txtSubtotal.TabIndex = 104;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSubTotal.Location = new Point(584, 615);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(92, 23);
            lblSubTotal.TabIndex = 103;
            lblSubTotal.Text = "Sub total:";
            // 
            // txtIva
            // 
            txtIva.BorderStyle = BorderStyle.FixedSingle;
            txtIva.Location = new Point(678, 644);
            txtIva.Name = "txtIva";
            txtIva.Size = new Size(200, 27);
            txtIva.TabIndex = 106;
            // 
            // lblPorcentajeIva
            // 
            lblPorcentajeIva.AutoSize = true;
            lblPorcentajeIva.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPorcentajeIva.Location = new Point(623, 648);
            lblPorcentajeIva.Name = "lblPorcentajeIva";
            lblPorcentajeIva.Size = new Size(49, 23);
            lblPorcentajeIva.TabIndex = 105;
            lblPorcentajeIva.Text = "IVA:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(111, 21, 30);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(287, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 108;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(5, 209, 135);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(135, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(146, 44);
            btnGuardar.TabIndex = 107;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(455, 203);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 109;
            label1.Text = "*";
            // 
            // frmGestionAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 727);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtIva);
            Controls.Add(lblPorcentajeIva);
            Controls.Add(txtSubtotal);
            Controls.Add(lblSubTotal);
            Controls.Add(btnAñadirCliente);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(lblEstado);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(dtpFechaEmision);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dgvAlquilerDetalle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblFechaEmisión);
            Controls.Add(cmbEstado);
            Controls.Add(label5);
            Controls.Add(lblCliente);
            Controls.Add(label4);
            Controls.Add(txtEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblFechaEntrega);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestionAlquiler";
            Text = "frmCrudAlquiler";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlquilerDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaEmisión;
        private Label label5;
        private Label lblCliente;
        private Label label4;
        private TextBox txtEmpleado;
        private Label lblEmpleado;
        private Label lblFechaDevolucion;
        private Label lblFechaEntrega;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnRetornar;
        private Button btnNuevo;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblCrudAlquiler;
        private DataGridView dgvAlquilerDetalle;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaEmision;
        private DateTimePicker dtpFechaEntrega;
        private TextBox txtTotal;
        private Label lblTotal;
        private TextBox txtCliente;
        private Label lblEstado;
        private Label label2;
        private Label label3;
        private Label label6;
        private ComboBox cmbEstado;
        private Button btnAñadirCliente;
        private TextBox txtSubtotal;
        private Label lblSubTotal;
        private TextBox txtIva;
        private Label lblPorcentajeIva;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label1;
        private Button btnConsultar;
    }
}