namespace AlquilerApp_Proyecto.Forms
{
    partial class frmMenuPrincipal
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
            lblTituloMenuPrincipal = new Label();
            btnMenuCliente = new Button();
            btnMenuArticulo = new Button();
            btnMenuCategoria = new Button();
            btnRetornar = new Button();
            txtMenuAlquilerDetalle = new Button();
            btnMenuEmpleado = new Button();
            btbMenuEstadoAlquiler = new Button();
            btnMenuTipoDocumento = new Button();
            btnUsuarioCrud = new Button();
            SuspendLayout();
            // 
            // lblTituloMenuPrincipal
            // 
            lblTituloMenuPrincipal.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloMenuPrincipal.Location = new Point(60, 23);
            lblTituloMenuPrincipal.Name = "lblTituloMenuPrincipal";
            lblTituloMenuPrincipal.Size = new Size(456, 48);
            lblTituloMenuPrincipal.TabIndex = 0;
            lblTituloMenuPrincipal.Text = "Sistema de Alquiler de Sillas y Mesas";
            lblTituloMenuPrincipal.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMenuCliente
            // 
            btnMenuCliente.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuCliente.Location = new Point(12, 108);
            btnMenuCliente.Name = "btnMenuCliente";
            btnMenuCliente.Size = new Size(242, 34);
            btnMenuCliente.TabIndex = 1;
            btnMenuCliente.Text = "Menu de Cliente";
            btnMenuCliente.UseVisualStyleBackColor = true;
            btnMenuCliente.Click += btnMenuCliente_Click;
            // 
            // btnMenuArticulo
            // 
            btnMenuArticulo.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuArticulo.Location = new Point(12, 188);
            btnMenuArticulo.Name = "btnMenuArticulo";
            btnMenuArticulo.Size = new Size(242, 34);
            btnMenuArticulo.TabIndex = 2;
            btnMenuArticulo.Text = "Menu de Articulo";
            btnMenuArticulo.UseVisualStyleBackColor = true;
            btnMenuArticulo.Click += btnMenuArticulo_Click;
            // 
            // btnMenuCategoria
            // 
            btnMenuCategoria.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuCategoria.Location = new Point(12, 148);
            btnMenuCategoria.Name = "btnMenuCategoria";
            btnMenuCategoria.Size = new Size(242, 34);
            btnMenuCategoria.TabIndex = 3;
            btnMenuCategoria.Text = "Menu de Categoria";
            btnMenuCategoria.UseVisualStyleBackColor = true;
            btnMenuCategoria.Click += btnMenuCategoria_Click;
            // 
            // btnRetornar
            // 
            btnRetornar.Location = new Point(412, 381);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Size = new Size(94, 29);
            btnRetornar.TabIndex = 5;
            btnRetornar.Text = "Retornar";
            btnRetornar.UseVisualStyleBackColor = true;
            btnRetornar.Click += btnRetornar_Click;
            // 
            // txtMenuAlquilerDetalle
            // 
            txtMenuAlquilerDetalle.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMenuAlquilerDetalle.Location = new Point(295, 108);
            txtMenuAlquilerDetalle.Name = "txtMenuAlquilerDetalle";
            txtMenuAlquilerDetalle.Size = new Size(242, 34);
            txtMenuAlquilerDetalle.TabIndex = 6;
            txtMenuAlquilerDetalle.Text = "Menu de Alquiler y Detalle";
            txtMenuAlquilerDetalle.UseVisualStyleBackColor = true;
            txtMenuAlquilerDetalle.Click += txtMenuAlquilerDetalle_Click;
            // 
            // btnMenuEmpleado
            // 
            btnMenuEmpleado.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuEmpleado.Location = new Point(295, 148);
            btnMenuEmpleado.Name = "btnMenuEmpleado";
            btnMenuEmpleado.Size = new Size(242, 34);
            btnMenuEmpleado.TabIndex = 7;
            btnMenuEmpleado.Text = "Menu Empleado";
            btnMenuEmpleado.UseVisualStyleBackColor = true;
            btnMenuEmpleado.Click += btnMenuEmpleado_Click;
            // 
            // btbMenuEstadoAlquiler
            // 
            btbMenuEstadoAlquiler.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btbMenuEstadoAlquiler.Location = new Point(295, 188);
            btbMenuEstadoAlquiler.Name = "btbMenuEstadoAlquiler";
            btbMenuEstadoAlquiler.Size = new Size(242, 34);
            btbMenuEstadoAlquiler.TabIndex = 8;
            btbMenuEstadoAlquiler.Text = "Menu de Estado del Alquiler";
            btbMenuEstadoAlquiler.UseVisualStyleBackColor = true;
            btbMenuEstadoAlquiler.Click += btbMenuEstadoAlquiler_Click;
            // 
            // btnMenuTipoDocumento
            // 
            btnMenuTipoDocumento.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuTipoDocumento.Location = new Point(12, 228);
            btnMenuTipoDocumento.Name = "btnMenuTipoDocumento";
            btnMenuTipoDocumento.Size = new Size(242, 34);
            btnMenuTipoDocumento.TabIndex = 9;
            btnMenuTipoDocumento.Text = "Menu de Tipo de Documento";
            btnMenuTipoDocumento.UseVisualStyleBackColor = true;
            btnMenuTipoDocumento.Click += btnMenuTipoDocumento_Click;
            // 
            // btnUsuarioCrud
            // 
            btnUsuarioCrud.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarioCrud.Location = new Point(295, 228);
            btnUsuarioCrud.Name = "btnUsuarioCrud";
            btnUsuarioCrud.Size = new Size(242, 34);
            btnUsuarioCrud.TabIndex = 10;
            btnUsuarioCrud.Text = "Menu de Usuario";
            btnUsuarioCrud.UseVisualStyleBackColor = true;
            btnUsuarioCrud.Click += btnUsuarioCrud_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnRetornar;
            ClientSize = new Size(568, 431);
            Controls.Add(btnUsuarioCrud);
            Controls.Add(btnMenuTipoDocumento);
            Controls.Add(btbMenuEstadoAlquiler);
            Controls.Add(btnMenuEmpleado);
            Controls.Add(txtMenuAlquilerDetalle);
            Controls.Add(btnRetornar);
            Controls.Add(btnMenuCategoria);
            Controls.Add(btnMenuArticulo);
            Controls.Add(btnMenuCliente);
            Controls.Add(lblTituloMenuPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion


        private Label lblTituloMenuPrincipal;
        private Button btnMenuCliente;
        private Button btnMenuArticulo;
        private Button btnMenuCategoria;
        private Button btnRetornar;
        private Button txtMenuAlquilerDetalle;
        private Button btnMenuEmpleado;
        private Button btbMenuEstadoAlquiler;
        private Button btnMenuTipoDocumento;
        private Button btnUsuarioCrud;
    }
}