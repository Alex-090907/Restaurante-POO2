namespace Restaurante.Presentacion.Administracion.Usuarios
{
    partial class FrmListaUsuarios
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
            dgvUsuarios = new DataGridView();
            colUsuario = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewCheckBoxColumn();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Lista de Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colUsuario, colNombre, colRol, colActivo });
            dgvUsuarios.Font = new Font("Segoe UI", 11F);
            dgvUsuarios.Location = new Point(30, 85);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(740, 280);
            dgvUsuarios.TabIndex = 1;
            // 
            // colUsuario
            // 
            colUsuario.DataPropertyName = "NombreUsuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "NombreCompleto";
            colNombre.FillWeight = 160F;
            colNombre.HeaderText = "Nombre completo";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.DataPropertyName = "Rol";
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.DataPropertyName = "Activo";
            colActivo.FillWeight = 50F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14F);
            btnNuevo.Location = new Point(30, 390);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 50);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14F);
            btnEditar.Location = new Point(200, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 14F);
            btnSalir.Location = new Point(620, 390);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(800, 465);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnNuevo);
            Controls.Add(btnEditar);
            Controls.Add(btnSalir);
            Name = "FrmListaUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Usuarios";
            Load += FrmListaUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewCheckBoxColumn colActivo;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnSalir;
    }
}