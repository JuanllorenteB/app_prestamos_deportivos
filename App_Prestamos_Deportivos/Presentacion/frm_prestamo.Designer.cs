namespace Presentacion
{
    partial class frm_prestamo
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
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_codigo = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_prestamo = new MaterialSkin.Controls.MaterialButton();
            this.btn_agregar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txt_observaciones = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.dtg_prestamo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_descripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nombre_implemento = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_existencia = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_cantidad_prestamo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Identificación de la persona";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(65, 88);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(223, 50);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            this.txt_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyUp);
            // 
            // txt_codigo
            // 
            this.txt_codigo.AnimateReadOnly = false;
            this.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo.Depth = 0;
            this.txt_codigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_codigo.Hint = "Código del implemento";
            this.txt_codigo.LeadingIcon = null;
            this.txt_codigo.Location = new System.Drawing.Point(65, 155);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.MaxLength = 50;
            this.txt_codigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_codigo.Multiline = false;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(223, 50);
            this.txt_codigo.TabIndex = 2;
            this.txt_codigo.Text = "";
            this.txt_codigo.TrailingIcon = null;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp);
            // 
            // btn_prestamo
            // 
            this.btn_prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prestamo.AutoSize = false;
            this.btn_prestamo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prestamo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_prestamo.Depth = 0;
            this.btn_prestamo.HighEmphasis = true;
            this.btn_prestamo.Icon = null;
            this.btn_prestamo.Location = new System.Drawing.Point(62, 352);
            this.btn_prestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_prestamo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_prestamo.Name = "btn_prestamo";
            this.btn_prestamo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_prestamo.Size = new System.Drawing.Size(81, 27);
            this.btn_prestamo.TabIndex = 7;
            this.btn_prestamo.Text = "Prestar";
            this.btn_prestamo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_prestamo.UseAccentColor = false;
            this.btn_prestamo.UseVisualStyleBackColor = true;
            this.btn_prestamo.Click += new System.EventHandler(this.btn_prestamo_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.AutoSize = false;
            this.btn_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agregar.Depth = 0;
            this.btn_agregar.HighEmphasis = true;
            this.btn_agregar.Icon = null;
            this.btn_agregar.Location = new System.Drawing.Point(245, 352);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agregar.Size = new System.Drawing.Size(49, 27);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "+";
            this.btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agregar.UseAccentColor = false;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(148, 352);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(92, 27);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.AnimateReadOnly = false;
            this.txt_observaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_observaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_observaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_observaciones.Depth = 0;
            this.txt_observaciones.HideSelection = true;
            this.txt_observaciones.Hint = "Observaciones";
            this.txt_observaciones.Location = new System.Drawing.Point(323, 285);
            this.txt_observaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txt_observaciones.MaxLength = 32767;
            this.txt_observaciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.PasswordChar = '\0';
            this.txt_observaciones.ReadOnly = false;
            this.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_observaciones.SelectedText = "";
            this.txt_observaciones.SelectionLength = 0;
            this.txt_observaciones.SelectionStart = 0;
            this.txt_observaciones.ShortcutsEnabled = true;
            this.txt_observaciones.Size = new System.Drawing.Size(353, 102);
            this.txt_observaciones.TabIndex = 10;
            this.txt_observaciones.TabStop = false;
            this.txt_observaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_observaciones.UseSystemPasswordChar = false;
            // 
            // dtg_prestamo
            // 
            this.dtg_prestamo.AllowUserToAddRows = false;
            this.dtg_prestamo.AllowUserToDeleteRows = false;
            this.dtg_prestamo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_prestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_prestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtg_prestamo.Location = new System.Drawing.Point(62, 406);
            this.dtg_prestamo.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_prestamo.Name = "dtg_prestamo";
            this.dtg_prestamo.ReadOnly = true;
            this.dtg_prestamo.RowHeadersWidth = 62;
            this.dtg_prestamo.RowTemplate.Height = 28;
            this.dtg_prestamo.Size = new System.Drawing.Size(615, 98);
            this.dtg_prestamo.TabIndex = 11;
            this.dtg_prestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_prestamo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código del Implemento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad Prestada";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.AnimateReadOnly = false;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre.Hint = "Nombre de la persona";
            this.txt_nombre.LeadingIcon = null;
            this.txt_nombre.Location = new System.Drawing.Point(323, 88);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(353, 50);
            this.txt_nombre.TabIndex = 12;
            this.txt_nombre.Text = "";
            this.txt_nombre.TrailingIcon = null;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AnimateReadOnly = false;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Depth = 0;
            this.txt_descripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_descripcion.Hint = "Descripción";
            this.txt_descripcion.LeadingIcon = null;
            this.txt_descripcion.Location = new System.Drawing.Point(323, 155);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.MaxLength = 50;
            this.txt_descripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(353, 50);
            this.txt_descripcion.TabIndex = 13;
            this.txt_descripcion.Text = "";
            this.txt_descripcion.TrailingIcon = null;
            // 
            // txt_nombre_implemento
            // 
            this.txt_nombre_implemento.AnimateReadOnly = false;
            this.txt_nombre_implemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_implemento.Depth = 0;
            this.txt_nombre_implemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nombre_implemento.Hint = "Nombre del Implemento";
            this.txt_nombre_implemento.LeadingIcon = null;
            this.txt_nombre_implemento.Location = new System.Drawing.Point(323, 220);
            this.txt_nombre_implemento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_implemento.MaxLength = 50;
            this.txt_nombre_implemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nombre_implemento.Multiline = false;
            this.txt_nombre_implemento.Name = "txt_nombre_implemento";
            this.txt_nombre_implemento.Size = new System.Drawing.Size(353, 50);
            this.txt_nombre_implemento.TabIndex = 15;
            this.txt_nombre_implemento.Text = "";
            this.txt_nombre_implemento.TrailingIcon = null;
            // 
            // txt_existencia
            // 
            this.txt_existencia.AnimateReadOnly = false;
            this.txt_existencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_existencia.Depth = 0;
            this.txt_existencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_existencia.Hint = "Exitencias";
            this.txt_existencia.LeadingIcon = null;
            this.txt_existencia.Location = new System.Drawing.Point(65, 220);
            this.txt_existencia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_existencia.MaxLength = 50;
            this.txt_existencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_existencia.Multiline = false;
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.Size = new System.Drawing.Size(223, 50);
            this.txt_existencia.TabIndex = 16;
            this.txt_existencia.Text = "";
            this.txt_existencia.TrailingIcon = null;
            // 
            // txt_cantidad_prestamo
            // 
            this.txt_cantidad_prestamo.AnimateReadOnly = false;
            this.txt_cantidad_prestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad_prestamo.Depth = 0;
            this.txt_cantidad_prestamo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_cantidad_prestamo.Hint = "Cantidad a prestar";
            this.txt_cantidad_prestamo.LeadingIcon = null;
            this.txt_cantidad_prestamo.Location = new System.Drawing.Point(65, 285);
            this.txt_cantidad_prestamo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad_prestamo.MaxLength = 50;
            this.txt_cantidad_prestamo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_cantidad_prestamo.Multiline = false;
            this.txt_cantidad_prestamo.Name = "txt_cantidad_prestamo";
            this.txt_cantidad_prestamo.Size = new System.Drawing.Size(223, 50);
            this.txt_cantidad_prestamo.TabIndex = 17;
            this.txt_cantidad_prestamo.Text = "";
            this.txt_cantidad_prestamo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(293, 23);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(323, 41);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Realizados Prestamo";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // frm_prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(765, 522);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_cantidad_prestamo);
            this.Controls.Add(this.txt_existencia);
            this.Controls.Add(this.txt_nombre_implemento);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dtg_prestamo);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_prestamo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_prestamo";
            this.Text = "frm_prestamo";
            this.Load += new System.EventHandler(this.frm_prestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_prestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialTextBox txt_codigo;
        private MaterialSkin.Controls.MaterialButton btn_prestamo;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txt_observaciones;
        private System.Windows.Forms.DataGridView dtg_prestamo;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_descripcion;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre_implemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialTextBox txt_existencia;
        private MaterialSkin.Controls.MaterialTextBox txt_cantidad_prestamo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}