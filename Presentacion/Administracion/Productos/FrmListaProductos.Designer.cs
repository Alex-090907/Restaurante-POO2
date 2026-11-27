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
            lstListaproductos = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // lstListaproductos
            // 
            lstListaproductos.Font = new Font("Segoe UI", 14F);
            lstListaproductos.FormattingEnabled = true;
            lstListaproductos.ItemHeight = 25;
            lstListaproductos.Location = new Point(30, 85);
            lstListaproductos.Name = "lstListaproductos";
            lstListaproductos.Size = new Size(460, 254);
            lstListaproductos.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(30, 365);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 2;
            button1.Text = "&Nuevo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(190, 365);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 3;
            button2.Text = "&Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(350, 365);
            button3.Name = "button3";
            button3.Size = new Size(140, 50);
            button3.TabIndex = 4;
            button3.Text = "E&liminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 445);
            Controls.Add(label1);
            Controls.Add(lstListaproductos);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Name = "FrmListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Productos";
            Activated += FrmListaProductos_Activated;
            Load += FrmListaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstListaproductos;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}