namespace CineFront.Vistas
{
    partial class FrmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarSesion));
            picMaximizar = new PictureBox();
            picMinimizar = new PictureBox();
            piCerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            picBoxOcultar = new PictureBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            btnIniciar = new Button();
            picBoxMostrar = new PictureBox();
            panelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)picMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMostrar).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // picMaximizar
            // 
            picMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaximizar.Cursor = Cursors.Hand;
            picMaximizar.Image = (Image)resources.GetObject("picMaximizar.Image");
            picMaximizar.Location = new Point(983, 2);
            picMaximizar.Margin = new Padding(5, 6, 5, 6);
            picMaximizar.Name = "picMaximizar";
            picMaximizar.Size = new Size(40, 40);
            picMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMaximizar.TabIndex = 86;
            picMaximizar.TabStop = false;
            // 
            // picMinimizar
            // 
            picMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinimizar.Cursor = Cursors.Hand;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(918, 2);
            picMinimizar.Margin = new Padding(5, 6, 5, 6);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(40, 40);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 85;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // piCerrar
            // 
            piCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            piCerrar.Cursor = Cursors.Hand;
            piCerrar.Image = (Image)resources.GetObject("piCerrar.Image");
            piCerrar.Location = new Point(1044, 2);
            piCerrar.Margin = new Padding(5, 6, 5, 6);
            piCerrar.Name = "piCerrar";
            piCerrar.Size = new Size(40, 40);
            piCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            piCerrar.TabIndex = 84;
            piCerrar.TabStop = false;
            piCerrar.Click += piCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-23, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(526, 580);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 79;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(picBoxOcultar);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(picBoxMostrar);
            panel1.Location = new Point(510, 80);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 530);
            panel1.TabIndex = 80;
            // 
            // picBoxOcultar
            // 
            picBoxOcultar.Cursor = Cursors.Hand;
            picBoxOcultar.Image = (Image)resources.GetObject("picBoxOcultar.Image");
            picBoxOcultar.Location = new Point(473, 268);
            picBoxOcultar.Name = "picBoxOcultar";
            picBoxOcultar.Size = new Size(54, 45);
            picBoxOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOcultar.TabIndex = 14;
            picBoxOcultar.TabStop = false;
            picBoxOcultar.Click += picBoxOcultar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.ActiveCaptionText;
            txtContraseña.Location = new Point(201, 280);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(251, 35);
            txtContraseña.TabIndex = 13;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.ControlLightLight;
            lblContraseña.Location = new Point(11, 280);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(184, 33);
            lblContraseña.TabIndex = 12;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(63, 198);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(132, 33);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.ActiveCaptionText;
            txtUsuario.Location = new Point(201, 198);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(251, 35);
            txtUsuario.TabIndex = 10;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(31, 31, 31);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 22, 22);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(209, 417);
            btnIniciar.Margin = new Padding(5, 6, 5, 6);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(220, 52);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // picBoxMostrar
            // 
            picBoxMostrar.Cursor = Cursors.Hand;
            picBoxMostrar.Image = (Image)resources.GetObject("picBoxMostrar.Image");
            picBoxMostrar.Location = new Point(473, 270);
            picBoxMostrar.Name = "picBoxMostrar";
            picBoxMostrar.Size = new Size(54, 45);
            picBoxMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxMostrar.TabIndex = 15;
            picBoxMostrar.TabStop = false;
            picBoxMostrar.Click += picBoxMostrar_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(198, 22, 22);
            panelTop.Controls.Add(picMaximizar);
            panelTop.Controls.Add(piCerrar);
            panelTop.Controls.Add(picMinimizar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 48);
            panelTop.TabIndex = 81;
            // 
            // FrmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(1100, 665);
            Controls.Add(panelTop);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIniciarSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmIniciarSesion";
            Load += FrmIniciarSesion_Load;
            ((System.ComponentModel.ISupportInitialize)picMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)piCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMostrar).EndInit();
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox picBoxMostrar;
        private PictureBox picBoxOcultar;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnIniciar;
        private PictureBox picMaximizar;
        private PictureBox picMinimizar;
        private PictureBox piCerrar;
        private Panel panelTop;
    }
}