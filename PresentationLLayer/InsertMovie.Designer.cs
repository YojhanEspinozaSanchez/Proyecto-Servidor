namespace PresentationLLayer
{
    partial class InsertMovie
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
            this.DsiplayButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LanguageBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.CategoryIdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MovieIdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackGrounPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGrounPanel
            // 
            this.BackGrounPanel.BackColor = System.Drawing.Color.Navy;
            this.BackGrounPanel.Controls.Add(this.DsiplayButton);
            this.BackGrounPanel.Controls.Add(this.HeaderPanel);
            this.BackGrounPanel.Controls.Add(this.dataGridView);
            this.BackGrounPanel.Controls.Add(this.InfoPanel);
            this.BackGrounPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGrounPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGrounPanel.Name = "BackGrounPanel";
            this.BackGrounPanel.Size = new System.Drawing.Size(1526, 592);
            this.BackGrounPanel.TabIndex = 3;
            this.BackGrounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGrounPanel_Paint);
            // 
            // DsiplayButton
            // 
            this.DsiplayButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsiplayButton.Location = new System.Drawing.Point(1397, 544);
            this.DsiplayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DsiplayButton.Name = "DsiplayButton";
            this.DsiplayButton.Size = new System.Drawing.Size(107, 33);
            this.DsiplayButton.TabIndex = 4;
            this.DsiplayButton.Text = "Mostrar";
            this.DsiplayButton.UseVisualStyleBackColor = true;
            this.DsiplayButton.Click += new System.EventHandler(this.DsiplayButton_Click);
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.MovieName,
            this.CategoryId,
            this.MovieCategory,
            this.Description,
            this.ReleaseYear,
            this.MovieLanguage});
            this.dataGridView.Location = new System.Drawing.Point(417, 103);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1098, 426);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.RegisterButton);
            this.InfoPanel.Controls.Add(this.LanguageBox);
            this.InfoPanel.Controls.Add(this.YearBox);
            this.InfoPanel.Controls.Add(this.CategoryIdBox);
            this.InfoPanel.Controls.Add(this.NameBox);
            this.InfoPanel.Controls.Add(this.MovieIdBox);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Location = new System.Drawing.Point(0, 95);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(403, 498);
            this.InfoPanel.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(223, 449);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(149, 33);
            this.RegisterButton.TabIndex = 16;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LanguageBox
            // 
            this.LanguageBox.Location = new System.Drawing.Point(182, 249);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(203, 26);
            this.LanguageBox.TabIndex = 13;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(182, 195);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(203, 26);
            this.YearBox.TabIndex = 12;
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // CategoryIdBox
            // 
            this.CategoryIdBox.Location = new System.Drawing.Point(182, 138);
            this.CategoryIdBox.Name = "CategoryIdBox";
            this.CategoryIdBox.Size = new System.Drawing.Size(203, 26);
            this.CategoryIdBox.TabIndex = 11;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(182, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 26);
            this.NameBox.TabIndex = 10;
            // 
            // MovieIdBox
            // 
            this.MovieIdBox.Location = new System.Drawing.Point(182, 28);
            this.MovieIdBox.Name = "MovieIdBox";
            this.MovieIdBox.Size = new System.Drawing.Size(203, 26);
            this.MovieIdBox.TabIndex = 9;
            this.MovieIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovieIdBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 197);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año Lanzamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Pelicula";
            // 
            // InsertMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 592);
            this.Controls.Add(this.BackGrounPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InsertMovie";
            this.Text = "InsertMovie";
            this.BackGrounPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGrounPanel;
        private System.Windows.Forms.Button DsiplayButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieLanguage;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox LanguageBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox CategoryIdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MovieIdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}