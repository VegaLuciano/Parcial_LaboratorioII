namespace FormLogin
{
    partial class FormVenta
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
            ckbAlbum = new CheckBox();
            ckbInstrumento = new CheckBox();
            lblTituloVenta = new Label();
            lstbInstrumento = new ListBox();
            txtBuscador = new TextBox();
            dtgAlbum = new DataGridView();
            btnBuscarAlbum = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgAlbum).BeginInit();
            SuspendLayout();
            // 
            // ckbAlbum
            // 
            ckbAlbum.AutoSize = true;
            ckbAlbum.Location = new Point(389, 93);
            ckbAlbum.Name = "ckbAlbum";
            ckbAlbum.Size = new Size(62, 19);
            ckbAlbum.TabIndex = 0;
            ckbAlbum.Text = "Album";
            ckbAlbum.UseVisualStyleBackColor = true;
            ckbAlbum.CheckedChanged += ckbAlbum_CheckedChanged;
            // 
            // ckbInstrumento
            // 
            ckbInstrumento.AutoSize = true;
            ckbInstrumento.Location = new Point(117, 122);
            ckbInstrumento.Name = "ckbInstrumento";
            ckbInstrumento.Size = new Size(91, 19);
            ckbInstrumento.TabIndex = 1;
            ckbInstrumento.Text = "Instrumento";
            ckbInstrumento.UseVisualStyleBackColor = true;
            ckbInstrumento.CheckedChanged += ckbInstrumento_CheckedChanged;
            // 
            // lblTituloVenta
            // 
            lblTituloVenta.AutoSize = true;
            lblTituloVenta.Location = new Point(61, 39);
            lblTituloVenta.Name = "lblTituloVenta";
            lblTituloVenta.Size = new Size(42, 15);
            lblTituloVenta.TabIndex = 2;
            lblTituloVenta.Text = "VENTA";
            // 
            // lstbInstrumento
            // 
            lstbInstrumento.FormattingEnabled = true;
            lstbInstrumento.ItemHeight = 15;
            lstbInstrumento.Location = new Point(88, 171);
            lstbInstrumento.Name = "lstbInstrumento";
            lstbInstrumento.Size = new Size(120, 49);
            lstbInstrumento.TabIndex = 5;
            lstbInstrumento.Visible = false;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(484, 91);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(119, 23);
            txtBuscador.TabIndex = 6;
            // 
            // dtgAlbum
            // 
            dtgAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlbum.Location = new Point(389, 151);
            dtgAlbum.Name = "dtgAlbum";
            dtgAlbum.RowTemplate.Height = 25;
            dtgAlbum.Size = new Size(368, 123);
            dtgAlbum.TabIndex = 7;
            // 
            // btnBuscarAlbum
            // 
            btnBuscarAlbum.Location = new Point(645, 93);
            btnBuscarAlbum.Name = "btnBuscarAlbum";
            btnBuscarAlbum.Size = new Size(75, 23);
            btnBuscarAlbum.TabIndex = 8;
            btnBuscarAlbum.Text = "Buscar";
            btnBuscarAlbum.UseVisualStyleBackColor = true;
            btnBuscarAlbum.Click += btnBuscarAlbum_Click;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarAlbum);
            Controls.Add(dtgAlbum);
            Controls.Add(txtBuscador);
            Controls.Add(lstbInstrumento);
            Controls.Add(lblTituloVenta);
            Controls.Add(ckbInstrumento);
            Controls.Add(ckbAlbum);
            Name = "FormVenta";
            Text = "E";
            Load += FormVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlbum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbAlbum;
        private CheckBox ckbInstrumento;
        private Label lblTituloVenta;
        private ListBox lstbInstrumento;
        private TextBox txtBuscador;
        private DataGridView dtgAlbum;
        private Button btnBuscarAlbum;
    }
}