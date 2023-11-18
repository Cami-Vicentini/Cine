namespace CineFront.Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label4 = new Label();
            picLogo = new PictureBox();
            panelTop = new Panel();
            picMaxim = new PictureBox();
            picCerrar = new PictureBox();
            picMinim = new PictureBox();
            picBoxOcultar = new PictureBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            btnIniciarSesion = new Button();
            picBoxMostrar = new PictureBox();
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMaxim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxOcultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMostrar).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(267, 26);
            label4.Name = "label4";
            label4.Size = new Size(417, 106);
            label4.TabIndex = 88;
            label4.Text = "Cinematic";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(50, 143);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(269, 266);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 87;
            picLogo.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(203, 67, 53);
            panelTop.Controls.Add(picMaxim);
            panelTop.Controls.Add(picCerrar);
            panelTop.Controls.Add(picMinim);
            panelTop.Location = new Point(-97, -29);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1111, 68);
            panelTop.TabIndex = 85;
            // 
            // picMaxim
            // 
            picMaxim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMaxim.Image = (Image)resources.GetObject("picMaxim.Image");
            picMaxim.Location = new Point(948, 32);
            picMaxim.Margin = new Padding(4, 5, 4, 5);
            picMaxim.Name = "picMaxim";
            picMaxim.Size = new Size(32, 32);
            picMaxim.SizeMode = PictureBoxSizeMode.Zoom;
            picMaxim.TabIndex = 76;
            picMaxim.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(1000, 32);
            picCerrar.Margin = new Padding(4, 5, 4, 5);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(32, 32);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 74;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // picMinim
            // 
            picMinim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picMinim.Cursor = Cursors.Hand;
            picMinim.Image = (Image)resources.GetObject("picMinim.Image");
            picMinim.Location = new Point(892, 32);
            picMinim.Margin = new Padding(4, 5, 4, 5);
            picMinim.Name = "picMinim";
            picMinim.Size = new Size(32, 32);
            picMinim.SizeMode = PictureBoxSizeMode.Zoom;
            picMinim.TabIndex = 75;
            picMinim.TabStop = false;
            picMinim.Click += picMinim_Click;
            // 
            // picBoxOcultar
            // 
            picBoxOcultar.BackColor = Color.FromArgb(93, 109, 126);
            picBoxOcultar.Cursor = Cursors.Hand;
            picBoxOcultar.Image = (Image)resources.GetObject("picBoxOcultar.Image");
            picBoxOcultar.Location = new Point(751, 309);
            picBoxOcultar.Margin = new Padding(3, 2, 3, 2);
            picBoxOcultar.Name = "picBoxOcultar";
            picBoxOcultar.Size = new Size(46, 38);
            picBoxOcultar.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOcultar.TabIndex = 84;
            picBoxOcultar.TabStop = false;
            picBoxOcultar.Click += picBoxOcultar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.ControlLightLight;
            lblContraseña.Location = new Point(353, 309);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(140, 31);
            lblContraseña.TabIndex = 83;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(499, 313);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(246, 30);
            txtContraseña.TabIndex = 82;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(499, 228);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(246, 30);
            txtUsuario.TabIndex = 81;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(390, 224);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(103, 31);
            lblUsuario.TabIndex = 80;
            lblUsuario.Text = "Usuario:";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(60, 92, 95);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 67, 53);
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = SystemColors.ControlLightLight;
            btnIniciarSesion.ImageAlign = ContentAlignment.BottomLeft;
            btnIniciarSesion.Location = new Point(487, 479);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(223, 51);
            btnIniciarSesion.TabIndex = 86;
            btnIniciarSesion.Text = "Iniciar";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnLogin_Click;
            // 
            // picBoxMostrar
            // 
            picBoxMostrar.BackColor = Color.FromArgb(93, 109, 126);
            picBoxMostrar.Cursor = Cursors.Hand;
            picBoxMostrar.Image = (Image)resources.GetObject("picBoxMostrar.Image");
            picBoxMostrar.Location = new Point(751, 309);
            picBoxMostrar.Margin = new Padding(3, 2, 3, 2);
            picBoxMostrar.Name = "picBoxMostrar";
            picBoxMostrar.Size = new Size(46, 38);
            picBoxMostrar.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxMostrar.TabIndex = 89;
            picBoxMostrar.TabStop = false;
            picBoxMostrar.Click += picBoxMostrar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(60, 92, 95);
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 67, 53);
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarse.ImageAlign = ContentAlignment.BottomLeft;
            btnRegistrarse.Location = new Point(155, 479);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(223, 51);
            btnRegistrarse.TabIndex = 90;
            btnRegistrarse.Text = "Iniciar";
            btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(93, 109, 126);
            ClientSize = new Size(941, 555);
            Controls.Add(panelTop);
            Controls.Add(btnRegistrarse);
            Controls.Add(label4);
            Controls.Add(picLogo);
            Controls.Add(picBoxOcultar);
            Controls.Add(lblContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(picBoxMostrar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMaxim).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinim).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxOcultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox picLogo;
        private Panel panelTop;
        private PictureBox picCerrar;
        private PictureBox picMaxim;
        private PictureBox picMinim;
        private PictureBox picBoxOcultar;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnIniciarSesion;
        private PictureBox picBoxMostrar;
        private Button btnRegistrarse;
    }
}