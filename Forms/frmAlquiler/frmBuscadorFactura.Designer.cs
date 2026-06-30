namespace AlquilerApp_Proyecto.Forms
{
    partial class frmBuscadorFactura
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
            cmbFiltroFactura = new ComboBox();
            txtBuscador = new TextBox();
            dgvFacturas = new DataGridView();
            lblBuscador = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltroFactura
            // 
            cmbFiltroFactura.FormattingEnabled = true;
            cmbFiltroFactura.Location = new Point(24, 46);
            cmbFiltroFactura.Name = "cmbFiltroFactura";
            cmbFiltroFactura.Size = new Size(151, 28);
            cmbFiltroFactura.TabIndex = 55;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscador.Location = new Point(256, 46);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(489, 27);
            txtBuscador.TabIndex = 54;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.AllowUserToOrderColumns = true;
            dgvFacturas.Anchor = AnchorStyles.None;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(22, 79);
            dgvFacturas.MultiSelect = false;
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(723, 354);
            dgvFacturas.TabIndex = 53;
            dgvFacturas.RowHeaderMouseDoubleClick += dgvFacturas_RowHeaderMouseDoubleClick;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(189, 50);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(61, 19);
            lblBuscador.TabIndex = 52;
            lblBuscador.Text = "Buscar:";
            // 
            // frmBuscadorFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 477);
            Controls.Add(cmbFiltroFactura);
            Controls.Add(txtBuscador);
            Controls.Add(dgvFacturas);
            Controls.Add(lblBuscador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscadorFactura";
            Text = "frmBuscadorFactura";
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFiltroFactura;
        private TextBox txtBuscador;
        private DataGridView dgvFacturas;
        private Label lblBuscador;
    }
}