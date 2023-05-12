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
            components = new System.ComponentModel.Container();
            albumBindingSource1 = new BindingSource(components);
            albumBindingSource = new BindingSource(components);
            albumBindingSource2 = new BindingSource(components);
            dtgAlbum = new DataGridView();
            albumBindingSource3 = new BindingSource(components);
            nombreDelAlbumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaEnOfertaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            añoDeSalidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMusicaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDeVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compradorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            dtgAlbum.AutoGenerateColumns = false;
            dtgAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlbum.Columns.AddRange(new DataGridViewColumn[] { nombreDelAlbumDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, estaEnOfertaDataGridViewCheckBoxColumn, stockDataGridViewTextBoxColumn, autorDataGridViewTextBoxColumn, añoDeSalidaDataGridViewTextBoxColumn, tipoMusicaDataGridViewTextBoxColumn, fechaDeVentaDataGridViewTextBoxColumn, compradorDataGridViewTextBoxColumn });
            dtgAlbum.DataSource = albumBindingSource3;
            dtgAlbum.Location = new Point(63, 22);
            dtgAlbum.Name = "dtgAlbum";
            dtgAlbum.RowTemplate.Height = 25;
            dtgAlbum.Size = new Size(613, 320);
            dtgAlbum.TabIndex = 0;
            // 
            // albumBindingSource3
            // 
            albumBindingSource3.DataSource = typeof(Entidades.Album);
            // 
            // nombreDelAlbumDataGridViewTextBoxColumn
            // 
            nombreDelAlbumDataGridViewTextBoxColumn.DataPropertyName = "NombreDelAlbum";
            nombreDelAlbumDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDelAlbumDataGridViewTextBoxColumn.Name = "nombreDelAlbumDataGridViewTextBoxColumn";
            nombreDelAlbumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            precioDataGridViewTextBoxColumn.Width = 70;
            // 
            // estaEnOfertaDataGridViewCheckBoxColumn
            // 
            estaEnOfertaDataGridViewCheckBoxColumn.DataPropertyName = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.HeaderText = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.Name = "estaEnOfertaDataGridViewCheckBoxColumn";
            estaEnOfertaDataGridViewCheckBoxColumn.ReadOnly = true;
            estaEnOfertaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            stockDataGridViewTextBoxColumn.Width = 80;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.ReadOnly = true;
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
            tipoMusicaDataGridViewTextBoxColumn.Width = 120;
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
            // FormVerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 438);
            Controls.Add(dtgAlbum);
            Name = "FormVerStock";
            Text = "FormVerStock";
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
        private DataGridViewTextBoxColumn nombreDelAlbumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estaEnOfertaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn añoDeSalidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMusicaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDeVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn;
        private BindingSource albumBindingSource3;
    }
}