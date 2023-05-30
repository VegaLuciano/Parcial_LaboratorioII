namespace FormLogin
{
    partial class FormVerStock
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
            btnAlbum = new Button();
            btnInstrumentos = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnAlbum
            // 
            btnAlbum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlbum.Location = new Point(69, 90);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Size = new Size(136, 43);
            btnAlbum.TabIndex = 0;
            btnAlbum.Text = "Ver Albums";
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnInstrumentos
            // 
            btnInstrumentos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstrumentos.Location = new Point(69, 139);
            btnInstrumentos.Name = "btnInstrumentos";
            btnInstrumentos.Size = new Size(136, 44);
            btnInstrumentos.TabIndex = 1;
            btnInstrumentos.Text = "Ver Instrumentos";
            btnInstrumentos.UseVisualStyleBackColor = true;
            btnInstrumentos.Click += btnInstrumentos_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(69, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 42);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar stock";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormVerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(546, 306);
            Controls.Add(btnAgregar);
            Controls.Add(btnInstrumentos);
            Controls.Add(btnAlbum);
            Name = "FormVerStock";
            Text = "FormVerStock";
            Load += FormVerStock_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlbum;
        private Button btnInstrumentos;
        private Button btnAgregar;
    }
}