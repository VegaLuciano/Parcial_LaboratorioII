namespace FormLogin
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            pnlTop = new Panel();
            pnlLogo = new Panel();
            pnlDatos = new Panel();
            btnSalir = new Button();
            pictureBox2 = new PictureBox();
            pnlContraseña = new Panel();
            pnlErrorContraseña = new Panel();
            lblErroContraseña = new Label();
            pnlTxtContraseña = new Panel();
            txtContraseña = new TextBox();
            pnlUsuario = new Panel();
            pnlErrorUsuario = new Panel();
            lblErrorUsuario = new Label();
            pnlTxtUsuario = new Panel();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblContraseña = new Label();
            btnIngresar = new Button();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlContraseña.SuspendLayout();
            pnlErrorContraseña.SuspendLayout();
            pnlUsuario.SuspendLayout();
            pnlErrorUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(17, 53, 71);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(5);
            pnlTop.Size = new Size(1002, 33);
            pnlTop.TabIndex = 6;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 53, 71);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 33);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(258, 507);
            pnlLogo.TabIndex = 7;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(btnSalir);
            pnlDatos.Controls.Add(pictureBox2);
            pnlDatos.Controls.Add(pnlContraseña);
            pnlDatos.Controls.Add(pnlUsuario);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Controls.Add(pictureBox1);
            pnlDatos.Controls.Add(lblLogin);
            pnlDatos.Controls.Add(lblContraseña);
            pnlDatos.Controls.Add(btnIngresar);
            pnlDatos.Dock = DockStyle.Fill;
            pnlDatos.Location = new Point(258, 33);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(744, 507);
            pnlDatos.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(659, 6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(73, 35);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(79, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 36);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pnlContraseña
            // 
            pnlContraseña.BackColor = Color.FromArgb(30, 30, 30);
            pnlContraseña.Controls.Add(pnlErrorContraseña);
            pnlContraseña.Controls.Add(pnlTxtContraseña);
            pnlContraseña.Controls.Add(txtContraseña);
            pnlContraseña.Location = new Point(216, 244);
            pnlContraseña.Name = "pnlContraseña";
            pnlContraseña.Size = new Size(430, 110);
            pnlContraseña.TabIndex = 13;
            // 
            // pnlErrorContraseña
            // 
            pnlErrorContraseña.Controls.Add(lblErroContraseña);
            pnlErrorContraseña.Location = new Point(3, 61);
            pnlErrorContraseña.Name = "pnlErrorContraseña";
            pnlErrorContraseña.Size = new Size(430, 32);
            pnlErrorContraseña.TabIndex = 13;
            // 
            // lblErroContraseña
            // 
            lblErroContraseña.AutoSize = true;
            lblErroContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErroContraseña.ForeColor = Color.Red;
            lblErroContraseña.Location = new Point(18, 0);
            lblErroContraseña.Name = "lblErroContraseña";
            lblErroContraseña.Size = new Size(143, 19);
            lblErroContraseña.TabIndex = 13;
            lblErroContraseña.Text = "Contraseña incorrecta";
            lblErroContraseña.TextAlign = ContentAlignment.MiddleCenter;
            lblErroContraseña.Visible = false;
            // 
            // pnlTxtContraseña
            // 
            pnlTxtContraseña.BackColor = Color.White;
            pnlTxtContraseña.Location = new Point(21, 35);
            pnlTxtContraseña.Name = "pnlTxtContraseña";
            pnlTxtContraseña.Size = new Size(341, 1);
            pnlTxtContraseña.TabIndex = 13;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(64, 64, 64);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(21, 10);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(341, 22);
            txtContraseña.TabIndex = 8;
            txtContraseña.Text = "Contraseña";
            txtContraseña.Click += txtContraseña_Click;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.FromArgb(30, 30, 30);
            pnlUsuario.Controls.Add(pnlErrorUsuario);
            pnlUsuario.Controls.Add(pnlTxtUsuario);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(216, 97);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(427, 109);
            pnlUsuario.TabIndex = 12;
            // 
            // pnlErrorUsuario
            // 
            pnlErrorUsuario.Controls.Add(lblErrorUsuario);
            pnlErrorUsuario.Location = new Point(3, 61);
            pnlErrorUsuario.Name = "pnlErrorUsuario";
            pnlErrorUsuario.Size = new Size(430, 32);
            pnlErrorUsuario.TabIndex = 13;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorUsuario.ForeColor = Color.Red;
            lblErrorUsuario.Location = new Point(18, 0);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(121, 19);
            lblErrorUsuario.TabIndex = 13;
            lblErrorUsuario.Text = "Usuario incorrecto";
            lblErrorUsuario.Visible = false;
            // 
            // pnlTxtUsuario
            // 
            pnlTxtUsuario.BackColor = Color.White;
            pnlTxtUsuario.Location = new Point(21, 35);
            pnlTxtUsuario.Name = "pnlTxtUsuario";
            pnlTxtUsuario.Size = new Size(341, 1);
            pnlTxtUsuario.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(64, 64, 64);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(21, 10);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 22);
            txtUsuario.TabIndex = 8;
            txtUsuario.Text = "Ingresar Usuario";
            txtUsuario.Click += txtUsuario_Click;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(131, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 19);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(82, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 35);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(367, 37);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(61, 28);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Login";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.ButtonFace;
            lblContraseña.Location = new Point(131, 254);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(79, 19);
            lblContraseña.TabIndex = 7;
            lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnIngresar.FlatAppearance.BorderSize = 2;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(317, 381);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(211, 35);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1002, 540);
            Controls.Add(pnlDatos);
            Controls.Add(pnlLogo);
            Controls.Add(pnlTop);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Form1";
            Load += FormLogin_Load;
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlContraseña.ResumeLayout(false);
            pnlContraseña.PerformLayout();
            pnlErrorContraseña.ResumeLayout(false);
            pnlErrorContraseña.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlErrorUsuario.ResumeLayout(false);
            pnlErrorUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel pnlTop;
        private Panel pnlLogo;
        private Panel pnlDatos;
        private Label lblContraseña;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Panel pnlTxtUsuario;
        private Panel pnlUsuario;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Panel pnlErrorUsuario;
        private Label lblErrorUsuario;
        private PictureBox pictureBox2;
        private Panel pnlContraseña;
        private Panel pnlErrorContraseña;
        private Panel pnlTxtContraseña;
        private TextBox txtContraseña;
        private Label lblErroContraseña;
        private Button btnSalir;
    }
}