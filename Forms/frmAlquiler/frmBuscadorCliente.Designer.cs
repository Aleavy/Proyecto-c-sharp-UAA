namespace AlquilerApp_Proyecto.Forms
{
    partial class frmBuscadorCliente
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
            txtBuscador = new TextBox();
            dgvClientes = new DataGridView();
            lblBuscador = new Label();
            cmbFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscador.Location = new Point(250, 49);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(586, 27);
            txtBuscador.TabIndex = 47;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToOrderColumns = true;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(26, 82);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(931, 464);
            dgvClientes.TabIndex = 46;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.DataBindingComplete += dgvClientes_DataBindingComplete;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(183, 52);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(61, 19);
            lblBuscador.TabIndex = 45;
            lblBuscador.Text = "Buscar:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(26, 48);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(151, 28);
            cmbFiltro.TabIndex = 48;
            // 
            // frmBuscadorCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 572);
            Controls.Add(cmbFiltro);
            Controls.Add(txtBuscador);
            Controls.Add(dgvClientes);
            Controls.Add(lblBuscador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscadorCliente";
            Text = "frmBuscadorCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscador;
        private DataGridView dgvClientes;
        private Label lblBuscador;
        private ComboBox cmbFiltro;
    }
}