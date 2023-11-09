namespace Presentacion
{
    partial class frm_modulo_sexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modulo_sexo));
            this.btn_editar = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.txt_nomenclatura = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.txt_descripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSize = false;
            this.btn_editar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_editar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_editar.Depth = 0;
            this.btn_editar.HighEmphasis = true;
            this.btn_editar.Icon = null;
            this.btn_editar.Location = new System.Drawing.Point(528, 296);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_editar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_editar.Size = new System.Drawing.Size(86, 36);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_editar.UseAccentColor = false;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = false;
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(622, 296);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(86, 36);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nomenclatura
            // 
            this.txt_nomenclatura.AnimateReadOnly = false;
            this.txt_nomenclatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomenclatura.Depth = 0;
            this.txt_nomenclatura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nomenclatura.Hint = "Nomenclatura";
            this.txt_nomenclatura.LeadingIcon = null;
            this.txt_nomenclatura.Location = new System.Drawing.Point(543, 135);
            this.txt_nomenclatura.MaxLength = 50;
            this.txt_nomenclatura.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nomenclatura.Multiline = false;
            this.txt_nomenclatura.Name = "txt_nomenclatura";
            this.txt_nomenclatura.Size = new System.Drawing.Size(165, 50);
            this.txt_nomenclatura.TabIndex = 19;
            this.txt_nomenclatura.Text = "";
            this.txt_nomenclatura.TrailingIcon = null;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = false;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(424, 296);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(96, 36);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AnimateReadOnly = false;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Depth = 0;
            this.txt_descripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.Hint = "Descripción del Sexo";
            this.txt_descripcion.LeadingIcon = null;
            this.txt_descripcion.Location = new System.Drawing.Point(424, 212);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(284, 50);
            this.txt_descripcion.TabIndex = 17;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TrailingIcon = null;
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Código";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(424, 136);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(99, 50);
            this.txt_id.TabIndex = 16;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(428, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 41);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Modulo Sexo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(68, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 297);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frm_modulo_sexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_nomenclatura);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frm_modulo_sexo";
            this.Text = "frm_modulo_sexo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_editar;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialTextBox txt_nomenclatura;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialTextBox txt_descripcion;
        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}