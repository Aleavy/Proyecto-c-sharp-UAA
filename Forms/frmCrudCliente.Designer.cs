namespace AlquilerApp_Proyecto.Repositories
{
    partial class frmCrudCliente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrudCliente));
            lblCrudCliente = new Label();
            btnRefrescarLista = new Button();
            lblBuscador = new Label();
            cmsMenuOrden = new ContextMenuStrip(components);
            cmsOrdenarAsc = new ToolStripMenuItem();
            cmsOrdenarDesc = new ToolStripMenuItem();
            btnRetornar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            txtBuscador = new TextBox();
            dgvClientes = new DataGridView();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCampoObligatorio1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtRazonSocial = new TextBox();
            txtDocumento = new TextBox();
            lblTelefono = new Label();
            lbl = new Label();
            lblRazonSocial = new Label();
            label5 = new Label();
            lblTipoDocumento = new Label();
            cmbTipoDocumento = new ComboBox();
            tipoDocumentoRepositoryBindingSource = new BindingSource(components);
            clienteBindingSource = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            lblDocumento = new Label();
            cmbFiltroCliente = new ComboBox();
            cmsMenuOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoDocumentoRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblCrudCliente
            // 
            lblCrudCliente.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCrudCliente.ForeColor = Color.White;
            lblCrudCliente.Location = new Point(189, 19);
            lblCrudCliente.Name = "lblCrudCliente";
            lblCrudCliente.Size = new Size(470, 56);
            lblCrudCliente.TabIndex = 28;
            lblCrudCliente.Text = "Gestion de Clientes";
            lblCrudCliente.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRefrescarLista
            // 
            btnRefrescarLista.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefrescarLista.Location = new Point(754, 275);
            btnRefrescarLista.Name = "btnRefrescarLista";
            btnRefrescarLista.Size = new Size(135, 32);
            btnRefrescarLista.TabIndex = 32;
            btnRefrescarLista.Text = "Refrescar Lista";
            btnRefrescarLista.UseVisualStyleBackColor = true;
            btnRefrescarLista.Click += btnRefrescarLista_Click;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(248, 317);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(61, 19);
            lblBuscador.TabIndex = 36;
            lblBuscador.Text = "Buscar:";
            // 
            // cmsMenuOrden
            // 
            cmsMenuOrden.ImageScalingSize = new Size(20, 20);
            cmsMenuOrden.Items.AddRange(new ToolStripItem[] { cmsOrdenarAsc, cmsOrdenarDesc });
            cmsMenuOrden.Name = "contextMenuStrip1";
            cmsMenuOrden.Size = new Size(115, 52);
            // 
            // cmsOrdenarAsc
            // 
            cmsOrdenarAsc.Name = "cmsOrdenarAsc";
            cmsOrdenarAsc.Size = new Size(114, 24);
            cmsOrdenarAsc.Text = "ASC";
            // 
            // cmsOrdenarDesc
            // 
            cmsOrdenarDesc.Name = "cmsOrdenarDesc";
            cmsOrdenarDesc.Size = new Size(114, 24);
            cmsOrdenarDesc.Text = "DESC";
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
            btnRetornar.Location = new Point(37, 585);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Padding = new Padding(0, 0, 10, 0);
            btnRetornar.Size = new Size(197, 51);
            btnRetornar.TabIndex = 46;
            btnRetornar.Text = "Salir";
            btnRetornar.TextAlign = ContentAlignment.MiddleLeft;
            btnRetornar.UseVisualStyleBackColor = false;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(5, 209, 135);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(37, 449);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(0, 0, 10, 0);
            btnEliminar.Size = new Size(197, 61);
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(5, 209, 135);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleRight;
            btnActualizar.Location = new Point(37, 371);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Padding = new Padding(0, 0, 10, 0);
            btnActualizar.Size = new Size(197, 61);
            btnActualizar.TabIndex = 44;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleLeft;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
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
            btnNuevo.Location = new Point(37, 293);
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
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscador.Location = new Point(315, 313);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(574, 27);
            txtBuscador.TabIndex = 42;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(121, 345);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(768, 412);
            dgvClientes.TabIndex = 41;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.DataBindingComplete += dgvClientes_DataBindingComplete;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 44, 56);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRetornar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEliminar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(944, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 784);
            panel1.TabIndex = 52;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 209, 135);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblCrudCliente);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 93);
            panel2.TabIndex = 53;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(541, 158);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 70;
            label4.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(6, 198);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 68;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(7, 158);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 67;
            label1.Text = "*";
            // 
            // lblCampoObligatorio1
            // 
            lblCampoObligatorio1.AutoSize = true;
            lblCampoObligatorio1.ForeColor = Color.Red;
            lblCampoObligatorio1.Location = new Point(7, 116);
            lblCampoObligatorio1.Name = "lblCampoObligatorio1";
            lblCampoObligatorio1.Size = new Size(15, 20);
            lblCampoObligatorio1.TabIndex = 66;
            lblCampoObligatorio1.Text = "*";
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
            btnCancelar.Location = new Point(273, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 65;
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
            btnGuardar.Location = new Point(121, 232);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 10, 0);
            btnGuardar.Size = new Size(146, 44);
            btnGuardar.TabIndex = 64;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.Window;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = SystemColors.WindowText;
            txtDireccion.Location = new Point(121, 199);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(768, 27);
            txtDireccion.TabIndex = 63;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(658, 156);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(231, 27);
            txtTelefono.TabIndex = 62;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            txtRazonSocial.Location = new Point(150, 160);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(380, 27);
            txtRazonSocial.TabIndex = 60;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Location = new Point(136, 116);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(380, 27);
            txtDocumento.TabIndex = 59;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTelefono.Location = new Point(562, 158);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(90, 23);
            lblTelefono.TabIndex = 58;
            lblTelefono.Text = "Telefono:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbl.Location = new Point(18, 199);
            lbl.Name = "lbl";
            lbl.Size = new Size(97, 23);
            lbl.TabIndex = 57;
            lbl.Text = "Dirección:";
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblRazonSocial.Location = new Point(18, 162);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(126, 23);
            lblRazonSocial.TabIndex = 55;
            lblRazonSocial.Text = "Razón Social:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(548, 116);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 73;
            label5.Text = "*";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTipoDocumento.Location = new Point(562, 120);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(180, 23);
            lblTipoDocumento.TabIndex = 71;
            lblTipoDocumento.Text = "Tipo de Documento:";
            // 
            // cmbTipoDocumento
            // 
            cmbTipoDocumento.FormattingEnabled = true;
            cmbTipoDocumento.Location = new Point(738, 116);
            cmbTipoDocumento.Name = "cmbTipoDocumento";
            cmbTipoDocumento.Size = new Size(151, 28);
            cmbTipoDocumento.TabIndex = 74;
            // 
            // tipoDocumentoRepositoryBindingSource
            // 
            tipoDocumentoRepositoryBindingSource.DataSource = typeof(TipoDocumentoRepository);
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Models.Cliente);
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblDocumento.Location = new Point(18, 116);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(112, 23);
            lblDocumento.TabIndex = 75;
            lblDocumento.Text = "Documento:";
            // 
            // cmbFiltroCliente
            // 
            cmbFiltroCliente.FormattingEnabled = true;
            cmbFiltroCliente.Location = new Point(121, 312);
            cmbFiltroCliente.Name = "cmbFiltroCliente";
            cmbFiltroCliente.Size = new Size(121, 28);
            cmbFiltroCliente.TabIndex = 76;
            // 
            // frmCrudCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1220, 784);
            Controls.Add(cmbFiltroCliente);
            Controls.Add(lblDocumento);
            Controls.Add(cmbTipoDocumento);
            Controls.Add(label5);
            Controls.Add(lblTipoDocumento);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCampoObligatorio1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtRazonSocial);
            Controls.Add(txtDocumento);
            Controls.Add(lblTelefono);
            Controls.Add(lbl);
            Controls.Add(lblRazonSocial);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtBuscador);
            Controls.Add(dgvClientes);
            Controls.Add(lblBuscador);
            Controls.Add(btnRefrescarLista);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCrudCliente";
            Text = "frmCrudCliente";
            cmsMenuOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoDocumentoRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCrudCliente;
        private Button btnRefrescarLista;
        private RadioButton rdApellido;
        private Label lblBuscador;
        private ContextMenuStrip cmsMenuOrden;
        private ToolStripMenuItem cmsOrdenarAsc;
        private ToolStripMenuItem cmsOrdenarDesc;
        private Button btnRetornar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnNuevo;
        private TextBox txtBuscador;
        private DataGridView dgvClientes;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCampoObligatorio1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtRazonSocial;
        private TextBox txtDocumento;
        private Label lblTelefono;
        private Label lbl;
        private Label lblTipoDocumento;
        private Label lblRazonSocial;
        private Label lblDocumento1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private ComboBox cmbTipoDocumento;
        private BindingSource clienteBindingSource;
        private BindingSource clienteBindingSource1;
        private BindingSource tipoDocumentoRepositoryBindingSource;
        private Label lblDocumento;
        private ComboBox cmbFiltroCliente;
    }
}