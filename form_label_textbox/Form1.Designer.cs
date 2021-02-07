namespace form_label_textbox
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEnterPwd = new System.Windows.Forms.Button();
            this.labelShowPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTitle.Location = new System.Drawing.Point(27, 74);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(269, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Contraseña de usuario";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(33, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(252, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonExit.Location = new System.Drawing.Point(558, 286);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEnterPwd
            // 
            this.buttonEnterPwd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonEnterPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterPwd.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnterPwd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEnterPwd.Location = new System.Drawing.Point(33, 197);
            this.buttonEnterPwd.Name = "buttonEnterPwd";
            this.buttonEnterPwd.Size = new System.Drawing.Size(81, 28);
            this.buttonEnterPwd.TabIndex = 1;
            this.buttonEnterPwd.Text = "Entrar";
            this.buttonEnterPwd.UseVisualStyleBackColor = false;
            this.buttonEnterPwd.Click += new System.EventHandler(this.buttonEnterPwd_Click);
            // 
            // labelShowPassword
            // 
            this.labelShowPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.labelShowPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowPassword.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelShowPassword.Location = new System.Drawing.Point(383, 197);
            this.labelShowPassword.Name = "labelShowPassword";
            this.labelShowPassword.Size = new System.Drawing.Size(141, 28);
            this.labelShowPassword.TabIndex = 4;
            this.labelShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::form_label_textbox.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(383, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(645, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelShowPassword);
            this.Controls.Add(this.buttonEnterPwd);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Universidad Tecnológica del Norte de Aguascalientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEnterPwd;
        private System.Windows.Forms.Label labelShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

