namespace Restaurante.Presentacion.Administracion.Roles
{
    partial class FrmNuevoRol
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
            txtDescripcion = new TextBox();
            chkActivo = new CheckBox();
            btnGuardar = new Button();
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
            label1.Text = "Nuevo Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Nombre del Rol";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(30, 120);
            txtNombre.MaxLength = 50;
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
            label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(30, 205);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(400, 80);
            txtDescripcion.TabIndex = 4;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Font = new Font("Segoe UI", 12F);
            chkActivo.Location = new Point(30, 310);
            chkActivo.Name = "chkActivo";
            chkActivo.TabIndex = 5;
            chkActivo.Text = "&Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(30, 365);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(240, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(190, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmNuevoRol
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(460, 445);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(chkActivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Name = "FrmNuevoRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Rol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnSalir;
    }
}