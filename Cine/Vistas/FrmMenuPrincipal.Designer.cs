namespace CineFront.Vistas
{
    partial class FrmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            picCerrar = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelLateral = new Panel();
            panelAcercaDe = new Panel();
            btnIntegrantes = new Button();
            btnAcercaDe = new Button();
            panelReportes = new Panel();
            btnFunciones = new Button();
            btnReportes = new Button();
            panelTransaccion = new Panel();
            btnPeliculas = new Button();
            btnTransaccion = new Button();
            panelSoporte = new Panel();
            btnButacas = new Button();
            btnSoporte = new Button();
            panelArchivo = new Panel();
            btnSalir = new Button();
            btnArchivo = new Button();
            panelLogo = new Panel();
            pictureBox4 = new PictureBox();
            lblHora = new Label();
            lblDate = new Label();
            reloj = new System.Windows.Forms.Timer(components);
            panelChildForm = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLateral.SuspendLayout();
            panelAcercaDe.SuspendLayout();
            panelReportes.SuspendLayout();
            panelTransaccion.SuspendLayout();
            panelSoporte.SuspendLayout();
            panelArchivo.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1326, 6);
            picCerrar.Margin = new Padding(5, 6, 5, 6);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(40, 40);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 77;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(198, 22, 22);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(picCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 57);
            panel1.TabIndex = 78;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 80;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1263, 6);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1194, 6);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.Controls.Add(panelAcercaDe);
            panelLateral.Controls.Add(btnAcercaDe);
            panelLateral.Controls.Add(panelReportes);
            panelLateral.Controls.Add(btnReportes);
            panelLateral.Controls.Add(panelTransaccion);
            panelLateral.Controls.Add(btnTransaccion);
            panelLateral.Controls.Add(panelSoporte);
            panelLateral.Controls.Add(btnSoporte);
            panelLateral.Controls.Add(panelArchivo);
            panelLateral.Controls.Add(btnArchivo);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 57);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(256, 643);
            panelLateral.TabIndex = 79;
            // 
            // panelAcercaDe
            // 
            panelAcercaDe.BackColor = Color.FromArgb(46, 52, 63);
            panelAcercaDe.Controls.Add(btnIntegrantes);
            panelAcercaDe.Dock = DockStyle.Top;
            panelAcercaDe.Location = new Point(0, 510);
            panelAcercaDe.Name = "panelAcercaDe";
            panelAcercaDe.Size = new Size(256, 50);
            panelAcercaDe.TabIndex = 90;
            // 
            // btnIntegrantes
            // 
            btnIntegrantes.Dock = DockStyle.Top;
            btnIntegrantes.FlatStyle = FlatStyle.Flat;
            btnIntegrantes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIntegrantes.ForeColor = SystemColors.ControlLightLight;
            btnIntegrantes.Image = (Image)resources.GetObject("btnIntegrantes.Image");
            btnIntegrantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnIntegrantes.Location = new Point(0, 0);
            btnIntegrantes.Name = "btnIntegrantes";
            btnIntegrantes.Size = new Size(256, 50);
            btnIntegrantes.TabIndex = 5;
            btnIntegrantes.Text = "Integrantes";
            btnIntegrantes.UseVisualStyleBackColor = true;
            btnIntegrantes.Click += btnIntegrantes_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Dock = DockStyle.Top;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcercaDe.ForeColor = SystemColors.ControlLightLight;
            btnAcercaDe.Image = (Image)resources.GetObject("btnAcercaDe.Image");
            btnAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcercaDe.Location = new Point(0, 465);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(256, 45);
            btnAcercaDe.TabIndex = 89;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            btnAcercaDe.Click += btnAcercaDe_Click;
            // 
            // panelReportes
            // 
            panelReportes.BackColor = Color.FromArgb(46, 52, 63);
            panelReportes.Controls.Add(btnFunciones);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 414);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(256, 51);
            panelReportes.TabIndex = 88;
            // 
            // btnFunciones
            // 
            btnFunciones.Dock = DockStyle.Top;
            btnFunciones.FlatStyle = FlatStyle.Flat;
            btnFunciones.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFunciones.ForeColor = SystemColors.ControlLightLight;
            btnFunciones.Image = (Image)resources.GetObject("btnFunciones.Image");
            btnFunciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnFunciones.Location = new Point(0, 0);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(256, 51);
            btnFunciones.TabIndex = 4;
            btnFunciones.Text = "Funciones";
            btnFunciones.UseVisualStyleBackColor = true;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = SystemColors.ControlLightLight;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 369);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(256, 45);
            btnReportes.TabIndex = 87;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // panelTransaccion
            // 
            panelTransaccion.BackColor = Color.FromArgb(46, 52, 63);
            panelTransaccion.Controls.Add(btnPeliculas);
            panelTransaccion.Dock = DockStyle.Top;
            panelTransaccion.Location = new Point(0, 318);
            panelTransaccion.Name = "panelTransaccion";
            panelTransaccion.Size = new Size(256, 51);
            panelTransaccion.TabIndex = 86;
            // 
            // btnPeliculas
            // 
            btnPeliculas.Dock = DockStyle.Top;
            btnPeliculas.FlatStyle = FlatStyle.Flat;
            btnPeliculas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPeliculas.ForeColor = SystemColors.ControlLightLight;
            btnPeliculas.Image = (Image)resources.GetObject("btnPeliculas.Image");
            btnPeliculas.ImageAlign = ContentAlignment.MiddleLeft;
            btnPeliculas.Location = new Point(0, 0);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(256, 51);
            btnPeliculas.TabIndex = 3;
            btnPeliculas.Text = "Peliculas";
            btnPeliculas.UseVisualStyleBackColor = true;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnTransaccion
            // 
            btnTransaccion.Dock = DockStyle.Top;
            btnTransaccion.FlatStyle = FlatStyle.Flat;
            btnTransaccion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransaccion.ForeColor = SystemColors.ControlLightLight;
            btnTransaccion.Image = (Image)resources.GetObject("btnTransaccion.Image");
            btnTransaccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaccion.Location = new Point(0, 273);
            btnTransaccion.Name = "btnTransaccion";
            btnTransaccion.Size = new Size(256, 45);
            btnTransaccion.TabIndex = 85;
            btnTransaccion.Text = "Transaccion";
            btnTransaccion.UseVisualStyleBackColor = true;
            btnTransaccion.Click += btnTransaccion_Click;
            // 
            // panelSoporte
            // 
            panelSoporte.BackColor = Color.FromArgb(46, 52, 63);
            panelSoporte.Controls.Add(btnButacas);
            panelSoporte.Dock = DockStyle.Top;
            panelSoporte.Location = new Point(0, 225);
            panelSoporte.Name = "panelSoporte";
            panelSoporte.Size = new Size(256, 48);
            panelSoporte.TabIndex = 84;
            // 
            // btnButacas
            // 
            btnButacas.Dock = DockStyle.Top;
            btnButacas.FlatStyle = FlatStyle.Flat;
            btnButacas.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacas.ForeColor = SystemColors.ControlLightLight;
            btnButacas.Image = (Image)resources.GetObject("btnButacas.Image");
            btnButacas.ImageAlign = ContentAlignment.MiddleLeft;
            btnButacas.Location = new Point(0, 0);
            btnButacas.Name = "btnButacas";
            btnButacas.Size = new Size(256, 48);
            btnButacas.TabIndex = 1;
            btnButacas.Text = "Butacas";
            btnButacas.UseVisualStyleBackColor = true;
            btnButacas.Click += btnButacas_Click;
            // 
            // btnSoporte
            // 
            btnSoporte.Dock = DockStyle.Top;
            btnSoporte.FlatStyle = FlatStyle.Flat;
            btnSoporte.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoporte.ForeColor = SystemColors.ControlLightLight;
            btnSoporte.Image = (Image)resources.GetObject("btnSoporte.Image");
            btnSoporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoporte.Location = new Point(0, 180);
            btnSoporte.Name = "btnSoporte";
            btnSoporte.Size = new Size(256, 45);
            btnSoporte.TabIndex = 83;
            btnSoporte.Text = "Soporte";
            btnSoporte.UseVisualStyleBackColor = true;
            btnSoporte.Click += btnSoporte_Click;
            // 
            // panelArchivo
            // 
            panelArchivo.BackColor = Color.FromArgb(46, 52, 63);
            panelArchivo.Controls.Add(btnSalir);
            panelArchivo.Dock = DockStyle.Top;
            panelArchivo.Location = new Point(0, 133);
            panelArchivo.Name = "panelArchivo";
            panelArchivo.Size = new Size(256, 47);
            panelArchivo.TabIndex = 82;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(256, 47);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.Dock = DockStyle.Top;
            btnArchivo.FlatStyle = FlatStyle.Flat;
            btnArchivo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnArchivo.ForeColor = SystemColors.ControlLightLight;
            btnArchivo.Image = (Image)resources.GetObject("btnArchivo.Image");
            btnArchivo.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchivo.Location = new Point(0, 88);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(256, 45);
            btnArchivo.TabIndex = 81;
            btnArchivo.Text = "Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox4);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(256, 88);
            panelLogo.TabIndex = 80;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(256, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = SystemColors.ControlLightLight;
            lblHora.Location = new Point(42, 77);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(183, 55);
            lblHora.TabIndex = 81;
            lblHora.Text = "lblHora";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlLightLight;
            lblDate.Location = new Point(42, 18);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(123, 37);
            lblDate.TabIndex = 80;
            lblDate.Text = "lblDate";
            // 
            // reloj
            // 
            reloj.Enabled = true;
            reloj.Tick += reloj_Tick;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(51, 51, 51);
            panelChildForm.Controls.Add(lblHora);
            panelChildForm.Controls.Add(pictureBox5);
            panelChildForm.Controls.Add(lblDate);
            panelChildForm.Controls.Add(pictureBox6);
            panelChildForm.Controls.Add(pictureBox7);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(256, 57);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1124, 643);
            panelChildForm.TabIndex = 80;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(159, 453);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(301, 243);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(416, 153);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(460, 490);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 82;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.None;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(778, 275);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(432, 365);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 83;
            pictureBox7.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1380, 700);
            Controls.Add(panelChildForm);
            Controls.Add(panelLateral);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLateral.ResumeLayout(false);
            panelAcercaDe.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelTransaccion.ResumeLayout(false);
            panelSoporte.ResumeLayout(false);
            panelArchivo.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picCerrar;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panelLateral;
        private PictureBox pictureBox4;
        private Panel panelLogo;
        private Button btnArchivo;
        private Panel panelArchivo;
        private Button btnSalir;
        private Button btnSoporte;
        private Panel panelSoporte;
        private Button btnButacas;
        private Button btnReportes;
        private Panel panelTransaccion;
        private Button btnPeliculas;
        private Button btnTransaccion;
        private Panel panelAcercaDe;
        private Button btnIntegrantes;
        private Button btnAcercaDe;
        private Panel panelReportes;
        private Button btnFunciones;
        private Label lblDate;
        private Label lblHora;
        private System.Windows.Forms.Timer reloj;
        private Panel panelChildForm;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}