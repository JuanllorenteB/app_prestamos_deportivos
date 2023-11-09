namespace Presentacion
{
    partial class frm_implementos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_implementos));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_codigo = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_valor = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.txt_especificaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(390, 40);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(322, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Modulo Implementos";
            // 
            // txt_codigo
            // 
            this.txt_codigo.AnimateReadOnly = false;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Depth = 0;
            this.txt_codigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.Hint = "Código";
            this.txt_codigo.LeadingIcon = null;
            this.txt_codigo.Location = new System.Drawing.Point(387, 94);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.MaxLength = 50;
            this.txt_codigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_codigo.Multiline = false;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(125, 50);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.Text = "";
            this.txt_codigo.TrailingIcon = null;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp_1);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.Hint = "Nombre";
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(536, 94);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(219, 50);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.Text = "";
            this.txt_nombre.TrailingIcon = null;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AnimateReadOnly = false;
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Depth = 0;
            this.txt_cantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cantidad.Hint = "Cantidad";
            this.txt_cantidad.LeadingIcon = null;
            this.txt_cantidad.Location = new System.Drawing.Point(583, 270);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad.MaxLength = 50;
            this.txt_cantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cantidad.Multiline = false;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(172, 50);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.Text = "";
            this.txt_cantidad.TrailingIcon = null;
            // 
            // txt_valor
            // 
            this.txt_valor.AnimateReadOnly = false;
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valor.Depth = 0;
            this.txt_valor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_valor.Hint = "Valor";
            this.txt_valor.LeadingIcon = null;
            this.txt_valor.Location = new System.Drawing.Point(387, 270);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_valor.MaxLength = 50;
            this.txt_valor.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_valor.Multiline = false;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(172, 50);
            this.txt_valor.TabIndex = 5;
            this.txt_valor.Text = "";
            this.txt_valor.TrailingIcon = null;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(387, 337);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(536, 337);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(659, 337);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_especificaciones
            // 
            this.txt_especificaciones.AnimateReadOnly = false;
            this.txt_especificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_especificaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_especificaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_especificaciones.Depth = 0;
            this.txt_especificaciones.HideSelection = true;
            this.txt_especificaciones.Hint = "Descripción";
            this.txt_especificaciones.Location = new System.Drawing.Point(387, 158);
            this.txt_especificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txt_especificaciones.MaxLength = 32767;
            this.txt_especificaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_especificaciones.Name = "txt_especificaciones";
            this.txt_especificaciones.PasswordChar = '\0';
            this.txt_especificaciones.ReadOnly = false;
            this.txt_especificaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_especificaciones.SelectedText = "";
            this.txt_especificaciones.SelectionLength = 0;
            this.txt_especificaciones.SelectionStart = 0;
            this.txt_especificaciones.ShortcutsEnabled = true;
            this.txt_especificaciones.Size = new System.Drawing.Size(368, 96);
            this.txt_especificaciones.TabIndex = 9;
            this.txt_especificaciones.TabStop = false;
            this.txt_especificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_especificaciones.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 333);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_implementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_especificaciones);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_implementos";
            this.Text = "frm_implementos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_codigo;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad;
        private MaterialSkin.Controls.MaterialTextBox txt_valor;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_especificaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}