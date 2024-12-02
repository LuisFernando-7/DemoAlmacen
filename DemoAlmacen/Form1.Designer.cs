namespace DemoAlmacen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtVariedades = new TextBox();
            label2 = new Label();
            txtNombreProductos = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvVariedades = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombrePro = new DataGridViewTextBoxColumn();
            Variedad = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVariedades).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtVariedades);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombreProductos);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 160);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(375, 99);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtVariedades
            // 
            txtVariedades.Location = new Point(43, 99);
            txtVariedades.Name = "txtVariedades";
            txtVariedades.Size = new Size(269, 23);
            txtVariedades.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Variedades";
            // 
            // txtNombreProductos
            // 
            txtNombreProductos.Location = new Point(43, 38);
            txtNombreProductos.Name = "txtNombreProductos";
            txtNombreProductos.Size = new Size(269, 23);
            txtNombreProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Productos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvVariedades);
            panel2.Location = new Point(12, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 237);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(375, 198);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 23);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click_1;
            // 
            // dgvVariedades
            // 
            dgvVariedades.AllowUserToAddRows = false;
            dgvVariedades.AllowUserToDeleteRows = false;
            dgvVariedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVariedades.Columns.AddRange(new DataGridViewColumn[] { Id, NombrePro, Variedad, Fecha });
            dgvVariedades.Location = new Point(3, 3);
            dgvVariedades.Name = "dgvVariedades";
            dgvVariedades.ReadOnly = true;
            dgvVariedades.Size = new Size(496, 178);
            dgvVariedades.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NombrePro
            // 
            NombrePro.HeaderText = "NombrePro";
            NombrePro.Name = "NombrePro";
            NombrePro.ReadOnly = true;
            // 
            // Variedad
            // 
            Variedad.HeaderText = "Variedad";
            Variedad.Name = "Variedad";
            Variedad.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "DemostracionAlmacen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVariedades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txtVariedades;
        private Label label2;
        private TextBox txtNombreProductos;
        private Label label1;
        private Panel panel2;
        private Button btnProcesar;
        private DataGridView dgvVariedades;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombrePro;
        private DataGridViewTextBoxColumn Variedad;
        private DataGridViewTextBoxColumn Fecha;
    }
}
