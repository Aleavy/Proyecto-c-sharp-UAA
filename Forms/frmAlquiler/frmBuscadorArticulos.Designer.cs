namespace AlquilerApp_Proyecto.Forms
{
    partial class frmBuscadorArticulos
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
            cmbFiltroArticulo = new ComboBox();
            txtBuscador = new TextBox();
            dgvArticulos = new DataGridView();
            lblBuscador = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltroArticulo
            // 
            cmbFiltroArticulo.FormattingEnabled = true;
            cmbFiltroArticulo.Location = new Point(12, 27);
            cmbFiltroArticulo.Name = "cmbFiltroArticulo";
            cmbFiltroArticulo.Size = new Size(151, 28);
            cmbFiltroArticulo.TabIndex = 51;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscador.Location = new Point(245, 28);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(231, 27);
            txtBuscador.TabIndex = 50;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // dgvArticulos
            // 
            dgvArticulos.AllowUserToAddRows = false;
            dgvArticulos.AllowUserToDeleteRows = false;
            dgvArticulos.AllowUserToOrderColumns = true;
            dgvArticulos.Anchor = AnchorStyles.None;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(12, 61);
            dgvArticulos.MultiSelect = false;
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.ReadOnly = true;
            dgvArticulos.RowHeadersWidth = 51;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.Size = new Size(664, 354);
            dgvArticulos.TabIndex = 49;
            dgvArticulos.CellFormatting += dgvArticulos_CellFormatting;
            dgvArticulos.RowHeaderMouseDoubleClick += dgvArticulos_RowHeaderMouseDoubleClick;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(178, 32);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(61, 19);
            lblBuscador.TabIndex = 48;
            lblBuscador.Text = "Buscar:";
            // 
            // frmBuscadorArticulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 560);
            Controls.Add(cmbFiltroArticulo);
            Controls.Add(txtBuscador);
            Controls.Add(dgvArticulos);
            Controls.Add(lblBuscador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBuscadorArticulos";
            Text = "frmBuscadorArticulos";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFiltroArticulo;
        private TextBox txtBuscador;
        private DataGridView dgvArticulos;
        private Label lblBuscador;
    }
}