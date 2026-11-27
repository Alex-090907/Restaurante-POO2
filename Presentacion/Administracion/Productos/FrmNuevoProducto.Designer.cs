namespace Restaurante.Presentacion.Administracion.Productos
{
    partial class FrmNuevoProducto
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
            textBox1 = new TextBox();
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
            label1.Location = new Point(43, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 48);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Producto";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(43, 200);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaxLength = 150;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 39);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 292);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 3;
            label3.Text = "PVP";
            // 
            // nudPVP
            // 
            nudPVP.DecimalPlaces = 2;
            nudPVP.Font = new Font("Segoe UI", 12F);
            nudPVP.Location = new Point(43, 342);
            nudPVP.Margin = new Padding(4, 5, 4, 5);
            nudPVP.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPVP.Name = "nudPVP";
            nudPVP.Size = new Size(571, 39);
            nudPVP.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(43, 433);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 5;
            label4.Text = "Precio de Costo";
            // 
            // nudPC
            // 
            nudPC.DecimalPlaces = 2;
            nudPC.Font = new Font("Segoe UI", 12F);
            nudPC.Location = new Point(43, 483);
            nudPC.Margin = new Padding(4, 5, 4, 5);
            nudPC.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPC.Name = "nudPC";
            nudPC.Size = new Size(571, 39);
            nudPC.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(43, 575);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 7;
            label5.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(43, 625);
            cmbCategoria.Margin = new Padding(4, 5, 4, 5);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(570, 40);
            cmbCategoria.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(43, 742);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(271, 83);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(343, 742);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(271, 83);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmNuevoProducto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(657, 875);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(nudPVP);
            Controls.Add(label4);
            Controls.Add(nudPC);
            Controls.Add(label5);
            Controls.Add(cmbCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += FrmNuevoProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPVP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
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