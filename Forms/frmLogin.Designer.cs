namespace AlquilerApp_Proyecto.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtCliente = new TextBox();
            label5 = new Label();
            lblCliente = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblCrudAlquiler = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button2 = new Button();
            btnConsultar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRetornar = new Button();
            btnNuevo = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Location = new Point(130, 51);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(198, 27);
            txtCliente.TabIndex = 99;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(32, 47);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 98;
            label5.Text = "*";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblCliente.Location = new Point(49, 52);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(78, 23);
            lblCliente.TabIndex = 97;
            lblCliente.Text = "Cliente:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(349, 183);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(198, 27);
            txtUsuario.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(200, 178);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 101;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(217, 183);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 100;
            label2.Text = "Usuario:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(5, 209, 135);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = ContentAlignment.MiddleRight;
            btnLogin.Location = new Point(322, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Padding = new Padding(0, 0, 10, 0);
            btnLogin.Size = new Size(196, 44);
            btnLogin.TabIndex = 108;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 209, 135);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblCrudAlquiler);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 93);
            panel2.TabIndex = 110;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 44, 56);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRetornar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(780, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 450);
            panel1.TabIndex = 109;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(5, 209, 135);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 93);
            panel3.TabIndex = 91;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(135, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 71;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(189, 19);
            label3.Name = "label3";
            label3.Size = new Size(470, 56);
            label3.TabIndex = 28;
            label3.Text = "Gestion de Alquileres";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 44, 56);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 450);
            panel4.TabIndex = 90;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(89, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 71;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(67, 117);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(121, 108);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(111, 21, 30);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(49, 600);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 10, 0);
            button2.Size = new Size(197, 51);
            button2.TabIndex = 46;
            button2.Text = "Salir";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
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
            btnConsultar.Location = new Point(49, 384);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Padding = new Padding(0, 0, 10, 0);
            btnConsultar.Size = new Size(197, 61);
            btnConsultar.TabIndex = 72;
            btnConsultar.Text = "Consultar";
            btnConsultar.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultar.UseVisualStyleBackColor = false;
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
            btnRetornar.Location = new Point(49, 600);
            btnRetornar.Name = "btnRetornar";
            btnRetornar.Padding = new Padding(0, 0, 10, 0);
            btnRetornar.Size = new Size(197, 51);
            btnRetornar.TabIndex = 46;
            btnRetornar.Text = "Salir";
            btnRetornar.TextAlign = ContentAlignment.MiddleLeft;
            btnRetornar.UseVisualStyleBackColor = false;
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
            btnNuevo.Location = new Point(-20, 297);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 10, 0);
            btnNuevo.RightToLeft = RightToLeft.No;
            btnNuevo.Size = new Size(197, 61);
            btnNuevo.TabIndex = 43;
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(349, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 113;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(200, 231);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 112;
            label4.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(217, 236);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 111;
            label6.Text = "Contraseña:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 450);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label5);
            Controls.Add(lblCliente);
            Name = "frmLogin";
            Text = "frmLogin";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private Label label5;
        private Label lblCliente;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblCrudAlquiler;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button2;
        private Button btnConsultar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnRetornar;
        private Button btnNuevo;
        private TextBox txtPassword;
        private Label label4;
        private Label label6;
    }
}