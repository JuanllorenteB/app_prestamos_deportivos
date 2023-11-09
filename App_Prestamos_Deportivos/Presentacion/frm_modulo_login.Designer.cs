namespace Presentacion
{
    partial class frm_modulo_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modulo_login));
            this.txt_usuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.AnimateReadOnly = false;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Depth = 0;
            this.txt_usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_usuario.Hint = "Usuario";
            this.txt_usuario.LeadingIcon = null;
            this.txt_usuario.Location = new System.Drawing.Point(281, 94);
            this.txt_usuario.MaxLength = 50;
            this.txt_usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(318, 50);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "";
            this.txt_usuario.TrailingIcon = null;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AnimateReadOnly = false;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Depth = 0;
            this.txt_contraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contraseña.Hint = "Contraseña";
            this.txt_contraseña.LeadingIcon = null;
            this.txt_contraseña.Location = new System.Drawing.Point(281, 162);
            this.txt_contraseña.MaxLength = 50;
            this.txt_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Password = true;
            this.txt_contraseña.Size = new System.Drawing.Size(318, 50);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.Text = "";
            this.txt_contraseña.TrailingIcon = null;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = false;
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(422, 221);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(133, 41);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AutoSize = false;
            this.btn_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ingresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ingresar.Depth = 0;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.HighEmphasis = true;
            this.btn_ingresar.Icon = null;
            this.btn_ingresar.Location = new System.Drawing.Point(281, 221);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ingresar.Size = new System.Drawing.Size(133, 41);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ingresar.UseAccentColor = false;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(285, 38);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(204, 41);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Iniciar Sesión";
            // 
            // frm_modulo_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(613, 277);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_modulo_login";
            this.Text = "frm_modulo_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_usuario;
        private MaterialSkin.Controls.MaterialTextBox txt_contraseña;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btn_ingresar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}