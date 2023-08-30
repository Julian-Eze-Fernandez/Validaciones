namespace Validaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnCargarCuit = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.maskedTxtPatente = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbtnNueva = new System.Windows.Forms.RadioButton();
            this.rdbtnVieja = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCargarPatente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(186, 381);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(0, 13);
            this.lblPatente.TabIndex = 34;
            // 
            // btnCargarCuit
            // 
            this.btnCargarCuit.Location = new System.Drawing.Point(525, 177);
            this.btnCargarCuit.Name = "btnCargarCuit";
            this.btnCargarCuit.Size = new System.Drawing.Size(133, 32);
            this.btnCargarCuit.TabIndex = 33;
            this.btnCargarCuit.Text = "Cargar Cuit";
            this.btnCargarCuit.UseVisualStyleBackColor = true;
            this.btnCargarCuit.Click += new System.EventHandler(this.btnCargarCuit_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(523, 91);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 32;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(522, 148);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(101, 13);
            this.lblDni.TabIndex = 31;
            this.lblDni.Text = "El Dni ingresado es:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(522, 60);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 13);
            this.lbl3.TabIndex = 30;
            this.lbl3.Text = "Ingrese el CUIT: ";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(522, 127);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(103, 13);
            this.lblCuit.TabIndex = 29;
            this.lblCuit.Text = "El Cuit ingresado es:";
            // 
            // maskedTxtPatente
            // 
            this.maskedTxtPatente.Location = new System.Drawing.Point(145, 284);
            this.maskedTxtPatente.Name = "maskedTxtPatente";
            this.maskedTxtPatente.Size = new System.Drawing.Size(238, 20);
            this.maskedTxtPatente.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rdbtnNueva);
            this.groupBox1.Controls.Add(this.rdbtnVieja);
            this.groupBox1.Location = new System.Drawing.Point(145, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 192);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato de patente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rdbtnNueva
            // 
            this.rdbtnNueva.AutoSize = true;
            this.rdbtnNueva.Location = new System.Drawing.Point(18, 111);
            this.rdbtnNueva.Name = "rdbtnNueva";
            this.rdbtnNueva.Size = new System.Drawing.Size(97, 17);
            this.rdbtnNueva.TabIndex = 5;
            this.rdbtnNueva.TabStop = true;
            this.rdbtnNueva.Text = "Patente Nueva";
            this.rdbtnNueva.UseVisualStyleBackColor = true;
            // 
            // rdbtnVieja
            // 
            this.rdbtnVieja.AutoSize = true;
            this.rdbtnVieja.Location = new System.Drawing.Point(18, 23);
            this.rdbtnVieja.Name = "rdbtnVieja";
            this.rdbtnVieja.Size = new System.Drawing.Size(88, 17);
            this.rdbtnVieja.TabIndex = 4;
            this.rdbtnVieja.TabStop = true;
            this.rdbtnVieja.Text = "Patente Vieja";
            this.rdbtnVieja.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(142, 359);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(139, 13);
            this.lbl2.TabIndex = 26;
            this.lbl2.Text = "Nº de patente ingresado es:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(142, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(293, 13);
            this.lbl1.TabIndex = 25;
            this.lbl1.Text = "Seleccione el formato y el Nº de patente que desea ingresar:";
            // 
            // btnCargarPatente
            // 
            this.btnCargarPatente.Location = new System.Drawing.Point(145, 310);
            this.btnCargarPatente.Name = "btnCargarPatente";
            this.btnCargarPatente.Size = new System.Drawing.Size(238, 36);
            this.btnCargarPatente.TabIndex = 24;
            this.btnCargarPatente.Text = "Cargar Patente";
            this.btnCargarPatente.UseVisualStyleBackColor = true;
            this.btnCargarPatente.Click += new System.EventHandler(this.btnCargarPatente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.btnCargarCuit);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.maskedTxtPatente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCargarPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnCargarCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.MaskedTextBox maskedTxtPatente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbtnNueva;
        private System.Windows.Forms.RadioButton rdbtnVieja;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCargarPatente;
    }
}

