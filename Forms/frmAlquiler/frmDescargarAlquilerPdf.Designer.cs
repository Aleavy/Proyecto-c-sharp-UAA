namespace AlquilerApp_Proyecto.Forms.frmAlquiler
{
    partial class frmDescargarAlquilerPdf
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
            dgfAlquileres = new DataGridView();
            btnExcel = new Button();
            btnPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgfAlquileres).BeginInit();
            SuspendLayout();
            // 
            // dgfAlquileres
            // 
            dgfAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgfAlquileres.Location = new Point(26, 110);
            dgfAlquileres.Name = "dgfAlquileres";
            dgfAlquileres.RowHeadersWidth = 51;
            dgfAlquileres.Size = new Size(706, 308);
            dgfAlquileres.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(478, 74);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 1;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(596, 74);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(94, 29);
            btnPdf.TabIndex = 2;
            btnPdf.Text = "Pdf";
            btnPdf.UseVisualStyleBackColor = true;
            // 
            // frmDescargarAlquilerPdf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPdf);
            Controls.Add(btnExcel);
            Controls.Add(dgfAlquileres);
            Name = "frmDescargarAlquilerPdf";
            Text = "frmDescargarAlquilerPdf";
            Load += frmDescargarAlquilerPdf_Load;
            ((System.ComponentModel.ISupportInitialize)dgfAlquileres).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgfAlquileres;
        private Button btnExcel;
        private Button btnPdf;
    }
}