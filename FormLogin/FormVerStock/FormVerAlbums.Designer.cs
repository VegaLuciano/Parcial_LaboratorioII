namespace FormLogin
{
    partial class FormVerAlbums
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
            albumBindingSource1 = new BindingSource(components);
            albumBindingSource = new BindingSource(components);
            albumBindingSource2 = new BindingSource(components);
            dtgAlbum = new DataGridView();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDelAlbumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            añoDeSalidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMusicaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaEnOfertaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            fechaDeVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compradorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            albumBindingSource3 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)albumBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource3).BeginInit();
            SuspendLayout();
            // 
            // albumBindingSource1
            // 
            albumBindingSource1.DataSource = typeof(Entidades.Album);
            // 
            // albumBindingSource
            // 
            albumBindingSource.DataSource = typeof(Entidades.Album);
            // 
            // albumBindingSource2
            // 
            albumBindingSource2.DataSource = typeof(Entidades.Album);
            // 
            // dtgAlbum
            // 
            dtgAlbum.AllowUserToAddRows = false;
            dtgAlbum.AllowUserToDeleteRows = false;
            dtgAlbum.AllowUserToResizeColumns = false;
            dtgAlbum.AllowUserToResizeRows = false;
            dtgAlbum.AutoGenerateColumns = false;
            dtgAlbum.BackgroundColor = Color.FromArgb(30, 30, 30);
            dtgAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlbum.Columns.AddRange(new DataGridViewColumn[] { autorDataGridViewTextBoxColumn, nombreDelAlbumDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, añoDeSalidaDataGridViewTextBoxColumn, tipoMusicaDataGridViewTextBoxColumn, estaEnOfertaDataGridViewCheckBoxColumn, fechaDeVentaDataGridViewTextBoxColumn, compradorDataGridViewTextBoxColumn });
            dtgAlbum.DataSource = albumBindingSource3;
            dtgAlbum.Dock = DockStyle.Fill;
            dtgAlbum.Location = new Point(0, 0);
            dtgAlbum.MultiSelect = false;
            dtgAlbum.Name = "dtgAlbum";
            dtgAlbum.ReadOnly = true;
            dtgAlbum.RowTemplate.Height = 25;
            dtgAlbum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlbum.Size = new Size(784, 420);
            dtgAlbum.TabIndex = 0;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.ReadOnly = true;
            autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDelAlbumDataGridViewTextBoxColumn
            // 
            nombreDelAlbumDataGridViewTextBoxColumn.DataPropertyName = "NombreDelAlbum";
            nombreDelAlbumDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDelAlbumDataGridViewTextBoxColumn.Name = "nombreDelAlbumDataGridViewTextBoxColumn";
            nombreDelAlbumDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDelAlbumDataGridViewTextBoxColumn.Width = 180;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            precioDataGridViewTextBoxColumn.Width = 80;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            stockDataGridViewTextBoxColumn.Width = 80;
            // 
            // añoDeSalidaDataGridViewTextBoxColumn
            // 
            añoDeSalidaDataGridViewTextBoxColumn.DataPropertyName = "AñoDeSalida";
            añoDeSalidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            añoDeSalidaDataGridViewTextBoxColumn.Name = "añoDeSalidaDataGridViewTextBoxColumn";
            añoDeSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMusicaDataGridViewTextBoxColumn
            // 
            tipoMusicaDataGridViewTextBoxColumn.DataPropertyName = "TipoMusica";
            tipoMusicaDataGridViewTextBoxColumn.HeaderText = "Tipo de musica";
            tipoMusicaDataGridViewTextBoxColumn.Name = "tipoMusicaDataGridViewTextBoxColumn";
            tipoMusicaDataGridViewTextBoxColumn.ReadOnly = true;
            tipoMusicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estaEnOfertaDataGridViewCheckBoxColumn
            // 
            estaEnOfertaDataGridViewCheckBoxColumn.DataPropertyName = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.HeaderText = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.Name = "estaEnOfertaDataGridViewCheckBoxColumn";
            estaEnOfertaDataGridViewCheckBoxColumn.ReadOnly = true;
            estaEnOfertaDataGridViewCheckBoxColumn.Visible = false;
            estaEnOfertaDataGridViewCheckBoxColumn.Width = 80;
            // 
            // fechaDeVentaDataGridViewTextBoxColumn
            // 
            fechaDeVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeVenta";
            fechaDeVentaDataGridViewTextBoxColumn.HeaderText = "FechaDeVenta";
            fechaDeVentaDataGridViewTextBoxColumn.Name = "fechaDeVentaDataGridViewTextBoxColumn";
            fechaDeVentaDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDeVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // compradorDataGridViewTextBoxColumn
            // 
            compradorDataGridViewTextBoxColumn.DataPropertyName = "Comprador";
            compradorDataGridViewTextBoxColumn.HeaderText = "Comprador";
            compradorDataGridViewTextBoxColumn.Name = "compradorDataGridViewTextBoxColumn";
            compradorDataGridViewTextBoxColumn.ReadOnly = true;
            compradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // albumBindingSource3
            // 
            albumBindingSource3.DataSource = typeof(Entidades.Album);
            // 
            // FormVerAlbums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 420);
            Controls.Add(dtgAlbum);
            Name = "FormVerAlbums";
            Text = "Albums";
            Load += FormVerStock_Load;
            ((System.ComponentModel.ISupportInitialize)albumBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource albumBindingSource;
        private BindingSource albumBindingSource1;
        private BindingSource albumBindingSource2;
        private DataGridView dtgAlbum;
        private BindingSource albumBindingSource3;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDelAlbumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn añoDeSalidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMusicaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estaEnOfertaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn fechaDeVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn;
    }
}