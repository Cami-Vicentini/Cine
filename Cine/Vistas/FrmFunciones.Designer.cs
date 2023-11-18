namespace CineFront.Vistas
{
    partial class FrmFunciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFunciones = new DataGridView();
            ColTitulo = new DataGridViewTextBoxColumn();
            ColSalaNro = new DataGridViewTextBoxColumn();
            ColFormato = new DataGridViewTextBoxColumn();
            ColDia = new DataGridViewTextBoxColumn();
            ColHora = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            cboPeliculas = new ComboBox();
            btnBuscar = new Button();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColTitulo, ColSalaNro, ColFormato, ColDia, ColHora, ColAcciones });
            dgvFunciones.Location = new Point(12, 177);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(1183, 502);
            dgvFunciones.TabIndex = 0;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick;
            // 
            // ColTitulo
            // 
            ColTitulo.HeaderText = "Titulo";
            ColTitulo.MinimumWidth = 6;
            ColTitulo.Name = "ColTitulo";
            ColTitulo.ReadOnly = true;
            ColTitulo.Width = 125;
            // 
            // ColSalaNro
            // 
            ColSalaNro.HeaderText = "Sala Nro";
            ColSalaNro.MinimumWidth = 6;
            ColSalaNro.Name = "ColSalaNro";
            ColSalaNro.ReadOnly = true;
            ColSalaNro.Width = 125;
            // 
            // ColFormato
            // 
            ColFormato.HeaderText = "Formato";
            ColFormato.MinimumWidth = 6;
            ColFormato.Name = "ColFormato";
            ColFormato.ReadOnly = true;
            ColFormato.Width = 125;
            // 
            // ColDia
            // 
            ColDia.HeaderText = "Dia";
            ColDia.MinimumWidth = 6;
            ColDia.Name = "ColDia";
            ColDia.ReadOnly = true;
            ColDia.Width = 125;
            // 
            // ColHora
            // 
            ColHora.HeaderText = "Hora";
            ColHora.MinimumWidth = 6;
            ColHora.Name = "ColHora";
            ColHora.ReadOnly = true;
            ColHora.Width = 125;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "Acciones";
            ColAcciones.MinimumWidth = 6;
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Width = 125;
            // 
            // cboPeliculas
            // 
            cboPeliculas.FormattingEnabled = true;
            cboPeliculas.Location = new Point(166, 70);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(300, 28);
            cboPeliculas.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(492, 69);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(747, 71);
            nudCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.ReadOnly = true;
            nudCantidad.Size = new Size(50, 27);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmFunciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 691);
            Controls.Add(nudCantidad);
            Controls.Add(btnBuscar);
            Controls.Add(cboPeliculas);
            Controls.Add(dgvFunciones);
            Name = "FrmFunciones";
            Text = "FrmFunciones";
            Load += FrmFunciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFunciones;
        private DataGridViewTextBoxColumn ColTitulo;
        private DataGridViewTextBoxColumn ColSalaNro;
        private DataGridViewTextBoxColumn ColFormato;
        private DataGridViewTextBoxColumn ColDia;
        private DataGridViewTextBoxColumn ColHora;
        private DataGridViewButtonColumn ColAcciones;
        private ComboBox cboPeliculas;
        private Button btnBuscar;
        private NumericUpDown nudCantidad;
    }
}