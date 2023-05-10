namespace FormLogin
{
    partial class FormMenuPrincipal
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
            btnVenta = new Button();
            button1 = new Button();
            btnVerStock = new Button();
            btnHistorial = new Button();
            btnBalances = new Button();
            btnCerrarSecion = new Button();
            lblFecha = new Label();
            tmrHora = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(12, 44);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(115, 23);
            btnVenta.TabIndex = 0;
            btnVenta.Text = "Realizar Venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(133, 44);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 1;
            button1.Text = "Realizar Devolución";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnVerStock
            // 
            btnVerStock.Location = new Point(263, 44);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(124, 23);
            btnVerStock.TabIndex = 2;
            btnVerStock.Text = "Ver stock";
            btnVerStock.UseVisualStyleBackColor = true;
            btnVerStock.Click += btnVerStock_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(393, 44);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(124, 23);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial de ventas";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnBalances
            // 
            btnBalances.Location = new Point(12, 281);
            btnBalances.Name = "btnBalances";
            btnBalances.Size = new Size(124, 23);
            btnBalances.TabIndex = 4;
            btnBalances.Text = "Balances";
            btnBalances.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSecion
            // 
            btnCerrarSecion.Location = new Point(429, 281);
            btnCerrarSecion.Name = "btnCerrarSecion";
            btnCerrarSecion.Size = new Size(124, 23);
            btnCerrarSecion.TabIndex = 5;
            btnCerrarSecion.Text = "Cerrar sesion";
            btnCerrarSecion.UseVisualStyleBackColor = true;
            btnCerrarSecion.Click += btnCerrarSecion_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(409, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(45, 9);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(0, 15);
            lblHora.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(41, 118, 147);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(224, 263);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 316);
            Controls.Add(btnSalir);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(btnCerrarSecion);
            Controls.Add(btnBalances);
            Controls.Add(btnHistorial);
            Controls.Add(btnVerStock);
            Controls.Add(button1);
            Controls.Add(btnVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVenta;
        private Button button1;
        private Button btnVerStock;
        private Button btnHistorial;
        private Button btnBalances;
        private Button btnCerrarSecion;
        private Label lblFecha;
        private System.Windows.Forms.Timer tmrHora;
        private Label lblHora;
        private Button btnSalir;
    }
}