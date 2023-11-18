namespace CineFront2
{
    partial class FrmInsertarPelicula
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
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(12, 9);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(51, 16);
            this.lblPelicula.TabIndex = 0;
            this.lblPelicula.Text = "Pelicula:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(40, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(28, 79);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(52, 16);
            this.lblDirector.TabIndex = 2;
            this.lblDirector.Text = "Director:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(34, 114);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(46, 16);
            this.lblIdioma.TabIndex = 3;
            this.lblIdioma.Text = "Idioma:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(32, 149);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(48, 16);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(4, 184);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(76, 16);
            this.lblClasificacion.TabIndex = 5;
            this.lblClasificacion.Text = "Clasificacion:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(22, 219);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(58, 16);
            this.lblDuracion.TabIndex = 6;
            this.lblDuracion.Text = "Duracion:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(378, 149);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 16);
            this.lblSala.TabIndex = 7;
            this.lblSala.Text = "Sala:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(378, 184);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(27, 16);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "Dia:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(372, 219);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 16);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(114, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 24);
            this.txtTitulo.TabIndex = 10;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(114, 71);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(185, 24);
            this.txtDirector.TabIndex = 11;
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(114, 106);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(121, 24);
            this.cboIdioma.TabIndex = 12;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(114, 141);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 24);
            this.cboGenero.TabIndex = 13;
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(114, 176);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(121, 24);
            this.cboClasificacion.TabIndex = 14;
            // 
            // nudDuracion
            // 
            this.nudDuracion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDuracion.Location = new System.Drawing.Point(114, 211);
            this.nudDuracion.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(120, 24);
            this.nudDuracion.TabIndex = 15;
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(414, 146);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(121, 24);
            this.cboSala.TabIndex = 16;
            // 
            // dtpDia
            // 
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(414, 178);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(91, 24);
            this.dtpDia.TabIndex = 17;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(414, 213);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(91, 24);
            this.dtpHora.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(333, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmInsertarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.nudDuracion);
            this.Controls.Add(this.cboClasificacion);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPelicula);
            this.Name = "FrmInsertarPelicula";
            this.Text = "Insertar Pelicula";
            this.Load += new System.EventHandler(this.FrmInsertarPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPelicula;
        private Label lblTitulo;
        private Label lblDirector;
        private Label lblIdioma;
        private Label lblGenero;
        private Label lblClasificacion;
        private Label lblDuracion;
        private Label lblSala;
        private Label lblDia;
        private Label lblHora;
        private TextBox txtTitulo;
        private TextBox txtDirector;
        private ComboBox cboIdioma;
        private ComboBox cboGenero;
        private ComboBox cboClasificacion;
        private NumericUpDown nudDuracion;
        private ComboBox cboSala;
        private DateTimePicker dtpDia;
        private DateTimePicker dtpHora;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}