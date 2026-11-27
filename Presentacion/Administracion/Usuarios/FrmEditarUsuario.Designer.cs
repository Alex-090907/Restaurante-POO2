namespace Restaurante.Presentacion.Administracion.Usuarios
{
    partial class FrmEditarUsuario
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
            txtUsuario = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtConfirmar = new TextBox();
            label6 = new Label();
            cmbRol = new ComboBox();
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
            label1.Text = "Editar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(30, 120);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(330, 29);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(400, 90);
            label3.Name = "label3";
            label3.TabIndex = 3;
            label3.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(400, 120);
            txtNombre.MaxLength = 150;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(330, 29);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.TabIndex = 5;
            label4.Text = "Nueva contraseña (opcional)";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(30, 205);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 29);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(400, 175);
            label5.Name = "label5";
            label5.TabIndex = 7;
            label5.Text = "Confirmar contraseña";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Font = new Font("Segoe UI", 12F);
            txtConfirmar.Location = new Point(400, 205);
            txtConfirmar.MaxLength = 50;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(330, 29);
            txtConfirmar.TabIndex = 8;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(30, 260);
            label6.Name = "label6";
            label6.TabIndex = 9;
            label6.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 12F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(30, 290);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(330, 29);
            cmbRol.TabIndex = 10;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 12F);
            chkActivo.Location = new Point(400, 292);
            chkActivo.Name = "chkActivo";
            chkActivo.TabIndex = 11;
            chkActivo.Text = "&Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14F);
            btnGuardar.Location = new Point(30, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 50);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(240, 360);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(190, 50);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmEditarUsuario
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(760, 440);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtConfirmar);
            Controls.Add(label6);
            Controls.Add(cmbRol);
            Controls.Add(chkActivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Name = "FrmEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += FrmEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtConfirmar;
        private Label label6;
        private ComboBox cmbRol;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnSalir;
    }
}