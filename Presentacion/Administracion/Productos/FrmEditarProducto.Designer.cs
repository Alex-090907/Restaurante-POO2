namespace Restaurante.Presentacion.Administracion.Productos
{
    partial class FrmEditarProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            nudPVP = new NumericUpDown();
            label4 = new Label();
            nudPC = new NumericUpDown();
            label5 = new Label();
            cmbCategoria = new ComboBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPVP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPC).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Editar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Nombre de Producto";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(30, 120);
            txtNombre.MaxLength = 150;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 29);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 175);
            label3.Name = "label3";
            label3.TabIndex = 3;
            label3.Text = "PVP";
            // 
            // nudPVP
            // 
            nudPVP.DecimalPlaces = 2;
            nudPVP.Font = new Font("Segoe UI", 12F);
            nudPVP.Location = new Point(30, 205);
            nudPVP.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPVP.Name = "nudPVP";
            nudPVP.Size = new Size(400, 29);
            nudPVP.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 260);
            label4.Name = "label4";
            label4.TabIndex = 5;
            label4.Text = "Precio de Costo";
            // 
            // nudPC
            // 
            nudPC.DecimalPlaces = 2;
            nudPC.Font = new Font("Segoe UI", 12F);
            nudPC.Location = new Point(30, 290);
            nudPC.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPC.Name = "nudPC";
            nudPC.Size = new Size(400, 29);
            nudPC.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 345);
            label5.Name = "label5";
            label5.TabIndex = 7;
            label5.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(30, 375);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(400, 29);
            cmbCategoria.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(30, 445);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(240, 445);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(190, 50);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmEditarProducto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(460, 525);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(nudPVP);
            Controls.Add(label4);
            Controls.Add(nudPC);
            Controls.Add(label5);
            Controls.Add(cmbCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Name = "FrmEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            Load += FrmEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPVP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private NumericUpDown nudPVP;
        private Label label4;
        private NumericUpDown nudPC;
        private Label label5;
        private ComboBox cmbCategoria;
        private Button btnGuardar;
        private Button btnSalir;
    }
}