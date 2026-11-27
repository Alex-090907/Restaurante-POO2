namespace Restaurante.Presentacion.Administracion.Productos
{
    partial class FrmListaProductos
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
            lstProductos = new ListBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Lista de Productos";
            // 
            // lstProductos
            // 
            lstProductos.Font = new Font("Segoe UI", 14F);
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 25;
            lstProductos.Location = new Point(30, 85);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(620, 254);
            lstProductos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14F);
            btnNuevo.Location = new Point(30, 365);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 50);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(190, 365);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 50);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14F);
            btnEliminar.Location = new Point(350, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 50);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "E&liminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(510, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 50);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(680, 445);
            Controls.Add(label1);
            Controls.Add(lstProductos);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Name = "FrmListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Productos";
            Load += FrmListaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstProductos;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}