namespace FormLogin
{
    partial class FormVerInstrumentos
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
            dataGridView1 = new DataGridView();
            instrumentoBindingSource = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            garantiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoInstrumento = new DataGridViewTextBoxColumn();
            fechaDeVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compradorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estaEnOfertaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, garantiaDataGridViewTextBoxColumn, TipoInstrumento, fechaDeVentaDataGridViewTextBoxColumn, compradorDataGridViewTextBoxColumn, estaEnOfertaDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = instrumentoBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(603, 263);
            dataGridView1.TabIndex = 0;
            // 
            // instrumentoBindingSource
            // 
            instrumentoBindingSource.DataSource = typeof(Entidades.Instrumento);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.Width = 80;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // garantiaDataGridViewTextBoxColumn
            // 
            garantiaDataGridViewTextBoxColumn.DataPropertyName = "Garantia";
            garantiaDataGridViewTextBoxColumn.HeaderText = "Garantia";
            garantiaDataGridViewTextBoxColumn.Name = "garantiaDataGridViewTextBoxColumn";
            garantiaDataGridViewTextBoxColumn.Width = 80;
            // 
            // TipoInstrumento
            // 
            TipoInstrumento.DataPropertyName = "TipoInstrumento";
            TipoInstrumento.HeaderText = "Tipo de instrumento";
            TipoInstrumento.Name = "TipoInstrumento";
            TipoInstrumento.ReadOnly = true;
            TipoInstrumento.Width = 150;
            // 
            // fechaDeVentaDataGridViewTextBoxColumn
            // 
            fechaDeVentaDataGridViewTextBoxColumn.DataPropertyName = "FechaDeVenta";
            fechaDeVentaDataGridViewTextBoxColumn.HeaderText = "FechaDeVenta";
            fechaDeVentaDataGridViewTextBoxColumn.Name = "fechaDeVentaDataGridViewTextBoxColumn";
            fechaDeVentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // compradorDataGridViewTextBoxColumn
            // 
            compradorDataGridViewTextBoxColumn.DataPropertyName = "Comprador";
            compradorDataGridViewTextBoxColumn.HeaderText = "Comprador";
            compradorDataGridViewTextBoxColumn.Name = "compradorDataGridViewTextBoxColumn";
            compradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // estaEnOfertaDataGridViewCheckBoxColumn
            // 
            estaEnOfertaDataGridViewCheckBoxColumn.DataPropertyName = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.HeaderText = "EstaEnOferta";
            estaEnOfertaDataGridViewCheckBoxColumn.Name = "estaEnOfertaDataGridViewCheckBoxColumn";
            estaEnOfertaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FormVerInstrumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 263);
            Controls.Add(dataGridView1);
            Name = "FormVerInstrumentos";
            Text = "FormVerInstrumentos";
            Load += FormVerInstrumentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)instrumentoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource instrumentoBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn garantiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoInstrumento;
        private DataGridViewTextBoxColumn fechaDeVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn compradorDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn estaEnOfertaDataGridViewCheckBoxColumn;
    }
}