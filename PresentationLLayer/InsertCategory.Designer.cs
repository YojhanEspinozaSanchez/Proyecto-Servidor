namespace PresentationLLayer
{
    partial class InsertCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsiplayButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackGrounPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGrounPanel
            // 
            this.BackGrounPanel.BackColor = System.Drawing.Color.Navy;
            this.BackGrounPanel.Controls.Add(this.panel1);
            this.BackGrounPanel.Controls.Add(this.DsiplayButton);
            this.BackGrounPanel.Controls.Add(this.HeaderPanel);
            this.BackGrounPanel.Controls.Add(this.InfoPanel);
            this.BackGrounPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGrounPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGrounPanel.Name = "BackGrounPanel";
            this.BackGrounPanel.Size = new System.Drawing.Size(1526, 592);
            this.BackGrounPanel.TabIndex = 3;
            this.BackGrounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGrounPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(417, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 434);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.Description});
            this.dataGridView.Location = new System.Drawing.Point(183, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(745, 398);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "ID de Categoria";
            this.CategoryId.MinimumWidth = 9;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 175;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Nombre de Categoria";
            this.CategoryName.MinimumWidth = 9;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 175;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 175;
            // 
            // DsiplayButton
            // 
            this.DsiplayButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsiplayButton.Location = new System.Drawing.Point(1397, 544);
            this.DsiplayButton.Margin = new System.Windows.Forms.Padding(4);
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
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.RegisterButton);
            this.InfoPanel.Controls.Add(this.DescriptionBox);
            this.InfoPanel.Controls.Add(this.NameBox);
            this.InfoPanel.Controls.Add(this.IdBox);
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
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(182, 138);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(203, 26);
            this.DescriptionBox.TabIndex = 11;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(182, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 26);
            this.NameBox.TabIndex = 10;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(182, 28);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(203, 26);
            this.IdBox.TabIndex = 9;
            this.IdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Categoria";
            // 
            // InsertCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 592);
            this.Controls.Add(this.BackGrounPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsertCategory";
            this.Text = "InsertCategory";
            this.BackGrounPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGrounPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button DsiplayButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}