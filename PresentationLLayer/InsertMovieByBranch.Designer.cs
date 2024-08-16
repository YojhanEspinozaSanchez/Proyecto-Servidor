namespace PresentationLLayer
{
    partial class InsertMovieByBranch
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
            this.BackGrounPanel = new System.Windows.Forms.Panel();
            this.dataGridViewAssociate = new System.Windows.Forms.DataGridView();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguageMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.QtyBox = new System.Windows.Forms.TextBox();
            this.DisplayMoviesButton = new System.Windows.Forms.Button();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.DsiplayAssoButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BackGrounPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGrounPanel
            // 
            this.BackGrounPanel.BackColor = System.Drawing.Color.Navy;
            this.BackGrounPanel.Controls.Add(this.dataGridViewAssociate);
            this.BackGrounPanel.Controls.Add(this.dataGridViewMovie);
            this.BackGrounPanel.Controls.Add(this.RegisterButton);
            this.BackGrounPanel.Controls.Add(this.HeaderPanel);
            this.BackGrounPanel.Controls.Add(this.InfoPanel);
            this.BackGrounPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGrounPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGrounPanel.Name = "BackGrounPanel";
            this.BackGrounPanel.Size = new System.Drawing.Size(1527, 599);
            this.BackGrounPanel.TabIndex = 3;
            this.BackGrounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGrounPanel_Paint);
            // 
            // dataGridViewAssociate
            // 
            this.dataGridViewAssociate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssociate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty,
            this.IdMovie,
            this.NameMovie,
            this.IdCategory,
            this.NameCategory,
            this.DescriptionCategory,
            this.MovieYear,
            this.LanguageMovie,
            this.BranchId,
            this.NameBranch,
            this.AddressBranch,
            this.NumberBranch,
            this.ActiveBranch,
            this.IdAdmin,
            this.IdentAdmin,
            this.NameAdmin,
            this.FlastName,
            this.SlastName,
            this.DateBirth,
            this.DateEntry});
            this.dataGridViewAssociate.Location = new System.Drawing.Point(418, 112);
            this.dataGridViewAssociate.Name = "dataGridViewAssociate";
            this.dataGridViewAssociate.RowHeadersWidth = 72;
            this.dataGridViewAssociate.RowTemplate.Height = 31;
            this.dataGridViewAssociate.Size = new System.Drawing.Size(1098, 426);
            this.dataGridViewAssociate.TabIndex = 17;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Cantidad";
            this.Qty.MinimumWidth = 9;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 175;
            // 
            // IdMovie
            // 
            this.IdMovie.HeaderText = "ID Pelicula";
            this.IdMovie.MinimumWidth = 9;
            this.IdMovie.Name = "IdMovie";
            this.IdMovie.ReadOnly = true;
            this.IdMovie.Width = 175;
            // 
            // NameMovie
            // 
            this.NameMovie.HeaderText = "Titulo";
            this.NameMovie.MinimumWidth = 9;
            this.NameMovie.Name = "NameMovie";
            this.NameMovie.ReadOnly = true;
            this.NameMovie.Width = 175;
            // 
            // IdCategory
            // 
            this.IdCategory.HeaderText = "ID Categoria";
            this.IdCategory.MinimumWidth = 9;
            this.IdCategory.Name = "IdCategory";
            this.IdCategory.ReadOnly = true;
            this.IdCategory.Width = 175;
            // 
            // NameCategory
            // 
            this.NameCategory.HeaderText = "Nombre Categoria";
            this.NameCategory.MinimumWidth = 9;
            this.NameCategory.Name = "NameCategory";
            this.NameCategory.ReadOnly = true;
            this.NameCategory.Width = 175;
            // 
            // DescriptionCategory
            // 
            this.DescriptionCategory.HeaderText = "Descripcion";
            this.DescriptionCategory.MinimumWidth = 9;
            this.DescriptionCategory.Name = "DescriptionCategory";
            this.DescriptionCategory.ReadOnly = true;
            this.DescriptionCategory.Width = 175;
            // 
            // MovieYear
            // 
            this.MovieYear.HeaderText = "Año Lanzamiento";
            this.MovieYear.MinimumWidth = 9;
            this.MovieYear.Name = "MovieYear";
            this.MovieYear.ReadOnly = true;
            this.MovieYear.Width = 175;
            // 
            // LanguageMovie
            // 
            this.LanguageMovie.HeaderText = "Idioma";
            this.LanguageMovie.MinimumWidth = 9;
            this.LanguageMovie.Name = "LanguageMovie";
            this.LanguageMovie.ReadOnly = true;
            this.LanguageMovie.Width = 175;
            // 
            // BranchId
            // 
            this.BranchId.HeaderText = "ID Sucursal";
            this.BranchId.MinimumWidth = 9;
            this.BranchId.Name = "BranchId";
            this.BranchId.ReadOnly = true;
            this.BranchId.Width = 175;
            // 
            // NameBranch
            // 
            this.NameBranch.HeaderText = "Nombre Sucursal";
            this.NameBranch.MinimumWidth = 9;
            this.NameBranch.Name = "NameBranch";
            this.NameBranch.ReadOnly = true;
            this.NameBranch.Width = 175;
            // 
            // AddressBranch
            // 
            this.AddressBranch.HeaderText = "Direccion";
            this.AddressBranch.MinimumWidth = 9;
            this.AddressBranch.Name = "AddressBranch";
            this.AddressBranch.ReadOnly = true;
            this.AddressBranch.Width = 175;
            // 
            // NumberBranch
            // 
            this.NumberBranch.HeaderText = "Telefono";
            this.NumberBranch.MinimumWidth = 9;
            this.NumberBranch.Name = "NumberBranch";
            this.NumberBranch.ReadOnly = true;
            this.NumberBranch.Width = 175;
            // 
            // ActiveBranch
            // 
            this.ActiveBranch.HeaderText = "Activo";
            this.ActiveBranch.MinimumWidth = 9;
            this.ActiveBranch.Name = "ActiveBranch";
            this.ActiveBranch.ReadOnly = true;
            this.ActiveBranch.Width = 175;
            // 
            // IdAdmin
            // 
            this.IdAdmin.HeaderText = "ID Encargado";
            this.IdAdmin.MinimumWidth = 9;
            this.IdAdmin.Name = "IdAdmin";
            this.IdAdmin.ReadOnly = true;
            this.IdAdmin.Width = 175;
            // 
            // IdentAdmin
            // 
            this.IdentAdmin.HeaderText = "Identificacion";
            this.IdentAdmin.MinimumWidth = 9;
            this.IdentAdmin.Name = "IdentAdmin";
            this.IdentAdmin.ReadOnly = true;
            this.IdentAdmin.Width = 175;
            // 
            // NameAdmin
            // 
            this.NameAdmin.HeaderText = "Nombre Encargado";
            this.NameAdmin.MinimumWidth = 9;
            this.NameAdmin.Name = "NameAdmin";
            this.NameAdmin.ReadOnly = true;
            this.NameAdmin.Width = 175;
            // 
            // FlastName
            // 
            this.FlastName.HeaderText = "Primer Apellido";
            this.FlastName.MinimumWidth = 9;
            this.FlastName.Name = "FlastName";
            this.FlastName.ReadOnly = true;
            this.FlastName.Width = 175;
            // 
            // SlastName
            // 
            this.SlastName.HeaderText = "Segundo Apellido";
            this.SlastName.MinimumWidth = 9;
            this.SlastName.Name = "SlastName";
            this.SlastName.ReadOnly = true;
            this.SlastName.Width = 175;
            // 
            // DateBirth
            // 
            this.DateBirth.HeaderText = "Fecha Nacimiento";
            this.DateBirth.MinimumWidth = 9;
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.ReadOnly = true;
            this.DateBirth.Width = 175;
            // 
            // DateEntry
            // 
            this.DateEntry.HeaderText = "Fecha Ingreso";
            this.DateEntry.MinimumWidth = 9;
            this.DateEntry.Name = "DateEntry";
            this.DateEntry.ReadOnly = true;
            this.DateEntry.Width = 175;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.MovieName,
            this.CategoryId,
            this.MovieCategory,
            this.Description,
            this.ReleaseYear,
            this.MovieLanguage});
            this.dataGridViewMovie.Location = new System.Drawing.Point(418, 112);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.RowHeadersWidth = 72;
            this.dataGridViewMovie.RowTemplate.Height = 31;
            this.dataGridViewMovie.Size = new System.Drawing.Size(1098, 426);
            this.dataGridViewMovie.TabIndex = 5;
            this.dataGridViewMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovie_CellContentClick);
            // 
            // MovieId
            // 
            this.MovieId.HeaderText = "ID de Pelicula";
            this.MovieId.MinimumWidth = 9;
            this.MovieId.Name = "MovieId";
            this.MovieId.Width = 175;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Titulo";
            this.MovieName.MinimumWidth = 9;
            this.MovieName.Name = "MovieName";
            this.MovieName.Width = 175;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "ID de Categoria";
            this.CategoryId.MinimumWidth = 9;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.Width = 175;
            // 
            // MovieCategory
            // 
            this.MovieCategory.HeaderText = "Nombre de Categoria";
            this.MovieCategory.MinimumWidth = 9;
            this.MovieCategory.Name = "MovieCategory";
            this.MovieCategory.Width = 175;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.Width = 175;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.HeaderText = "Año de Lanzamiento";
            this.ReleaseYear.MinimumWidth = 9;
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.Width = 175;
            // 
            // MovieLanguage
            // 
            this.MovieLanguage.HeaderText = "Idioma";
            this.MovieLanguage.MinimumWidth = 9;
            this.MovieLanguage.Name = "MovieLanguage";
            this.MovieLanguage.Width = 175;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(802, 555);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(149, 33);
            this.RegisterButton.TabIndex = 16;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HeaderPanel.Controls.Add(this.label8);
            this.HeaderPanel.Controls.Add(this.pictureBox);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1526, 98);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(52, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 67);
            this.label8.TabIndex = 3;
            this.label8.Text = "VIDEOTECA";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PresentationLLayer.Properties.Resources.pngwing_com;
            this.pictureBox.Location = new System.Drawing.Point(1420, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(84, 74);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.QtyBox);
            this.InfoPanel.Controls.Add(this.DisplayMoviesButton);
            this.InfoPanel.Controls.Add(this.BranchComboBox);
            this.InfoPanel.Controls.Add(this.DsiplayAssoButton);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Location = new System.Drawing.Point(0, 95);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(403, 498);
            this.InfoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad ";
            // 
            // QtyBox
            // 
            this.QtyBox.Location = new System.Drawing.Point(170, 330);
            this.QtyBox.Name = "QtyBox";
            this.QtyBox.Size = new System.Drawing.Size(163, 26);
            this.QtyBox.TabIndex = 20;
            this.QtyBox.TextChanged += new System.EventHandler(this.LanguageBox_TextChanged);
            this.QtyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyBox_KeyPress);
            // 
            // DisplayMoviesButton
            // 
            this.DisplayMoviesButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMoviesButton.Location = new System.Drawing.Point(30, 430);
            this.DisplayMoviesButton.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayMoviesButton.Name = "DisplayMoviesButton";
            this.DisplayMoviesButton.Size = new System.Drawing.Size(141, 49);
            this.DisplayMoviesButton.TabIndex = 19;
            this.DisplayMoviesButton.Text = " Mostrar Peliculas";
            this.DisplayMoviesButton.UseVisualStyleBackColor = true;
            this.DisplayMoviesButton.Click += new System.EventHandler(this.DisplayMoviesButton_Click);
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.BranchComboBox.Location = new System.Drawing.Point(118, 123);
            this.BranchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(163, 28);
            this.BranchComboBox.TabIndex = 18;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // DsiplayAssoButton
            // 
            this.DsiplayAssoButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsiplayAssoButton.Location = new System.Drawing.Point(227, 430);
            this.DsiplayAssoButton.Margin = new System.Windows.Forms.Padding(4);
            this.DsiplayAssoButton.Name = "DsiplayAssoButton";
            this.DsiplayAssoButton.Size = new System.Drawing.Size(141, 49);
            this.DsiplayAssoButton.TabIndex = 4;
            this.DsiplayAssoButton.Text = " Mostrar Asociaciones";
            this.DsiplayAssoButton.UseVisualStyleBackColor = true;
            this.DsiplayAssoButton.Click += new System.EventHandler(this.DsiplayAssoButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(93, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sucursales Disponibles";
            // 
            // InsertMovieByBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 599);
            this.Controls.Add(this.BackGrounPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertMovieByBranch";
            this.Text = "InsertMovieByBranch";
            this.BackGrounPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssociate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGrounPanel;
        private System.Windows.Forms.Button DsiplayAssoButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieLanguage;
        private System.Windows.Forms.Button DisplayMoviesButton;
        private System.Windows.Forms.TextBox QtyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAssociate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanguageMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEntry;
    }
}