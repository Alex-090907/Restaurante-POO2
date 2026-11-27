namespace Restaurante
{
    partial class Form1
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
            lblTitulo = new Label();
            btnProductos = new Button();
            btnRoles = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Restaurante";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 14F);
            btnProductos.Location = new Point(70, 95);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(280, 55);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "&Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnRoles
            // 
            btnRoles.Font = new Font("Segoe UI", 14F);
            btnRoles.Location = new Point(70, 170);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(280, 55);
            btnRoles.TabIndex = 2;
            btnRoles.Text = "&Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 14F);
            btnUsuarios.Location = new Point(70, 245);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(280, 55);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "&Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(70, 320);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(280, 55);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(420, 410);
            Controls.Add(lblTitulo);
            Controls.Add(btnProductos);
            Controls.Add(btnRoles);
            Controls.Add(btnUsuarios);
            Controls.Add(btnSalir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnProductos;
        private Button btnRoles;
        private Button btnUsuarios;
        private Button btnSalir;
    }
}