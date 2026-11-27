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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(360, 45);
            label1.TabIndex = 0;
            label1.Text = "Restaurante";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(70, 95);
            button1.Name = "button1";
            button1.Size = new Size(280, 55);
            button1.TabIndex = 1;
            button1.Text = "&Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(70, 170);
            button2.Name = "button2";
            button2.Size = new Size(280, 55);
            button2.TabIndex = 2;
            button2.Text = "&Roles";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(70, 245);
            button3.Name = "button3";
            button3.Size = new Size(280, 55);
            button3.TabIndex = 3;
            button3.Text = "&Usuarios";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnSalir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnSalir;
    }
}