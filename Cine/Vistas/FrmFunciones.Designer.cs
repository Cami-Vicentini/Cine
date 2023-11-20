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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFunciones));
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
            picCerrar = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.Anchor = AnchorStyles.None;
            dgvFunciones.BackgroundColor = Color.FromArgb(31, 31, 31);
            dgvFunciones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColTitulo, ColSalaNro, ColFormato, ColDia, ColHora, ColAcciones });
            dgvFunciones.Location = new Point(1, 192);
            dgvFunciones.Margin = new Padding(4, 5, 4, 5);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersVisible = false;
            dgvFunciones.RowHeadersWidth = 60;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(1479, 570);
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
            cboPeliculas.Location = new Point(34, 136);
            cboPeliculas.Margin = new Padding(4);
            cboPeliculas.Name = "cboPeliculas";
            cboPeliculas.Size = new Size(370, 33);
            cboPeliculas.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(31, 31, 31);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(648, 120);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(163, 52);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nudCantidad.Location = new Point(468, 128);
            nudCantidad.Margin = new Padding(4);
            nudCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.ReadOnly = true;
            nudCantidad.Size = new Size(62, 44);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(46, 52, 63);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1054, 6);
            picCerrar.Margin = new Padding(5, 6, 5, 6);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(40, 40);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 77;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(172, 28);
            label1.Name = "label1";
            label1.Size = new Size(210, 54);
            label1.TabIndex = 1;
            label1.Text = "Funciones";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 109, 126);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 111);
            panel1.TabIndex = 78;
            // 
            // FrmFunciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(1124, 643);
            Controls.Add(panel1);
            Controls.Add(picCerrar);
            Controls.Add(nudCantidad);
            Controls.Add(btnBuscar);
            Controls.Add(cboPeliculas);
            Controls.Add(dgvFunciones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmFunciones";
            Text = "FrmFunciones";
            Load += FrmFunciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox picCerrar;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}