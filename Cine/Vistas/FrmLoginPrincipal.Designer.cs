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
            btnEntrarALaApp = new Button();
            lblNoTienesCuenta = new Label();
            lblNuevaCuenta = new LinkLabel();
            pictureBox2 = new PictureBox();
            picCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEntrarALaApp);
            panel1.Controls.Add(lblNoTienesCuenta);
            panel1.Controls.Add(lblNuevaCuenta);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 62);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 450);
            panel1.TabIndex = 0;
            // 
            // btnEntrarALaApp
            // 
            btnEntrarALaApp.BackColor = Color.FromArgb(31, 31, 31);
            btnEntrarALaApp.Cursor = Cursors.Hand;
            btnEntrarALaApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 22, 22);
            btnEntrarALaApp.FlatStyle = FlatStyle.Flat;
            btnEntrarALaApp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrarALaApp.ForeColor = SystemColors.ControlLightLight;
            btnEntrarALaApp.Location = new Point(215, 224);
            btnEntrarALaApp.Margin = new Padding(5, 6, 5, 6);
            btnEntrarALaApp.Name = "btnEntrarALaApp";
            btnEntrarALaApp.Size = new Size(220, 52);
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
            lblNoTienesCuenta.Location = new Point(162, 310);
            lblNoTienesCuenta.Margin = new Padding(5, 0, 5, 0);
            lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            lblNoTienesCuenta.Size = new Size(327, 33);
            lblNoTienesCuenta.TabIndex = 7;
            lblNoTienesCuenta.Text = "¿No tiene una cuenta?";
            // 
            // lblNuevaCuenta
            // 
            lblNuevaCuenta.ActiveLinkColor = Color.FromArgb(198, 22, 22);
            lblNuevaCuenta.AutoSize = true;
            lblNuevaCuenta.Cursor = Cursors.Hand;
            lblNuevaCuenta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNuevaCuenta.LinkColor = Color.FromArgb(198, 22, 22);
            lblNuevaCuenta.Location = new Point(219, 367);
            lblNuevaCuenta.Margin = new Padding(5, 0, 5, 0);
            lblNuevaCuenta.Name = "lblNuevaCuenta";
            lblNuevaCuenta.Size = new Size(212, 33);
            lblNuevaCuenta.TabIndex = 6;
            lblNuevaCuenta.TabStop = true;
            lblNuevaCuenta.Text = "Nueva Cuenta";
            lblNuevaCuenta.LinkClicked += lblNuevaCuenta_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, -28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(606, 304);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // picCerrar
            // 
            picCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picCerrar.BackColor = Color.FromArgb(198, 22, 22);
            picCerrar.Cursor = Cursors.Hand;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(631, 6);
            picCerrar.Margin = new Padding(5, 6, 5, 6);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(40, 40);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 75;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(198, 22, 22);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 6);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(198, 22, 22);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(picCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 54);
            panel2.TabIndex = 76;
            // 
            // FrmLoginPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 63);
            ClientSize = new Size(685, 523);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "FrmLoginPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLoginPrincipal";
            Load += FrmLoginPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEntrarALaApp;
        private Label lblNoTienesCuenta;
        private LinkLabel lblNuevaCuenta;
        private PictureBox pictureBox1;
        private PictureBox picCerrar;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}