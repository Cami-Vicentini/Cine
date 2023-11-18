namespace CineFront
{
    partial class FrmLoginPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPrincipal));
            panel1 = new Panel();
            lblBienvenida = new Label();
            btnEntrarALaApp = new Button();
            lblNoTienesCuenta = new Label();
            lblNuevaCuenta = new LinkLabel();
            picCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(btnEntrarALaApp);
            panel1.Controls.Add(lblNoTienesCuenta);
            panel1.Controls.Add(lblNuevaCuenta);
            panel1.Location = new Point(12, 50);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 341);
            panel1.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.ForeColor = SystemColors.ControlLightLight;
            lblBienvenida.Location = new Point(202, 11);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(110, 48);
            lblBienvenida.TabIndex = 5;
            lblBienvenida.Text = "Cine";
            // 
            // btnEntrarALaApp
            // 
            btnEntrarALaApp.BackColor = Color.Transparent;
            btnEntrarALaApp.Cursor = Cursors.Hand;
            btnEntrarALaApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 67, 53);
            btnEntrarALaApp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrarALaApp.Location = new Point(172, 171);
            btnEntrarALaApp.Margin = new Padding(4, 5, 4, 5);
            btnEntrarALaApp.Name = "btnEntrarALaApp";
            btnEntrarALaApp.Size = new Size(176, 42);
            btnEntrarALaApp.TabIndex = 9;
            btnEntrarALaApp.Text = "Ingresar";
            btnEntrarALaApp.UseVisualStyleBackColor = false;
            btnEntrarALaApp.Click += btnEntrarALaApp_Click;
            // 
            // lblNoTienesCuenta
            // 
            lblNoTienesCuenta.AutoSize = true;
            lblNoTienesCuenta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoTienesCuenta.ForeColor = SystemColors.ControlLightLight;
            lblNoTienesCuenta.Location = new Point(130, 261);
            lblNoTienesCuenta.Margin = new Padding(4, 0, 4, 0);
            lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            lblNoTienesCuenta.Size = new Size(258, 29);
            lblNoTienesCuenta.TabIndex = 7;
            lblNoTienesCuenta.Text = "No tiene una cuenta?";
            // 
            // lblNuevaCuenta
            // 
            lblNuevaCuenta.ActiveLinkColor = Color.FromArgb(203, 67, 53);
            lblNuevaCuenta.AutoSize = true;
            lblNuevaCuenta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaCuenta.LinkColor = Color.FromArgb(203, 67, 53);
            lblNuevaCuenta.Location = new Point(172, 298);
            lblNuevaCuenta.Margin = new Padding(4, 0, 4, 0);
            lblNuevaCuenta.Name = "lblNuevaCuenta";
            lblNuevaCuenta.Size = new Size(176, 29);
            lblNuevaCuenta.TabIndex = 6;
            lblNuevaCuenta.TabStop = true;
            lblNuevaCuenta.Text = "Nueva Cuenta";
            lblNuevaCuenta.LinkClicked += lblNuevaCuenta_LinkClicked;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(203, 67, 53);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(515, 2);
            picCerrar.Margin = new Padding(4, 5, 4, 5);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(32, 32);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 75;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(203, 67, 53);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(203, 67, 53);
            panel2.Location = new Point(-11, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 43);
            panel2.TabIndex = 76;
            // 
            // FrmLoginPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 55, 93);
            ClientSize = new Size(548, 440);
            Controls.Add(panel1);
            Controls.Add(picCerrar);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLoginPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoginPrincipal";
            Load += FrmLoginPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrarALaApp;
        private Label lblNoTienesCuenta;
        private LinkLabel lblNuevaCuenta;
        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private PictureBox picCerrar;
        private Panel panel2;
    }
}