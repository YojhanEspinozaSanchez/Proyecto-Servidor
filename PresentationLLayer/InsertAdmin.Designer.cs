﻿namespace PresentationLLayer
{
    partial class InsertAdmin
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
            this.BackGrounPanel = new System.Windows.Forms.Panel();
            this.DsiplayButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SystemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.EntryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SlastnameBox = new System.Windows.Forms.TextBox();
            this.FlastnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdentificationBox = new System.Windows.Forms.TextBox();
            this.SystemIdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.BackGrounPanel.Size = new System.Drawing.Size(1602, 610);
            this.BackGrounPanel.TabIndex = 1;
            this.BackGrounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGrounPanel_Paint);
            // 
            // DsiplayButton
            // 
            this.DsiplayButton.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsiplayButton.Location = new System.Drawing.Point(1464, 560);
            this.DsiplayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DsiplayButton.Name = "DsiplayButton";
            this.DsiplayButton.Size = new System.Drawing.Size(112, 34);
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
            this.HeaderPanel.Size = new System.Drawing.Size(1599, 100);
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
            this.label8.Location = new System.Drawing.Point(54, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 67);
            this.label8.TabIndex = 3;
            this.label8.Text = "VIDEOTECA";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PresentationLLayer.Properties.Resources.pngwing_com;
            this.pictureBox.Location = new System.Drawing.Point(1488, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(88, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SystemID,
            this.ID,
            this.AdminName,
            this.Flastname,
            this.Slastname,
            this.BirthDate,
            this.EntryDate});
            this.dataGridView.Location = new System.Drawing.Point(428, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1162, 438);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // SystemID
            // 
            this.SystemID.HeaderText = "ID en Sistema";
            this.SystemID.MinimumWidth = 9;
            this.SystemID.Name = "SystemID";
            this.SystemID.ReadOnly = true;
            this.SystemID.Width = 175;
            // 
            // ID
            // 
            this.ID.HeaderText = "Identification";
            this.ID.MinimumWidth = 9;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 175;
            // 
            // AdminName
            // 
            this.AdminName.HeaderText = "Nombre";
            this.AdminName.MinimumWidth = 9;
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            this.AdminName.Width = 175;
            // 
            // Flastname
            // 
            this.Flastname.HeaderText = "Primer Apellido";
            this.Flastname.MinimumWidth = 9;
            this.Flastname.Name = "Flastname";
            this.Flastname.ReadOnly = true;
            this.Flastname.Width = 175;
            // 
            // Slastname
            // 
            this.Slastname.HeaderText = "Segundo Apellido";
            this.Slastname.MinimumWidth = 9;
            this.Slastname.Name = "Slastname";
            this.Slastname.ReadOnly = true;
            this.Slastname.Width = 175;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Fecha Nacimiento";
            this.BirthDate.MinimumWidth = 9;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 175;
            // 
            // EntryDate
            // 
            this.EntryDate.HeaderText = "Fecha Ingreso";
            this.EntryDate.MinimumWidth = 9;
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            this.EntryDate.Width = 175;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.EntryTimePicker);
            this.InfoPanel.Controls.Add(this.RegisterButton);
            this.InfoPanel.Controls.Add(this.BirthTimePicker);
            this.InfoPanel.Controls.Add(this.SlastnameBox);
            this.InfoPanel.Controls.Add(this.FlastnameBox);
            this.InfoPanel.Controls.Add(this.NameBox);
            this.InfoPanel.Controls.Add(this.IdentificationBox);
            this.InfoPanel.Controls.Add(this.SystemIdBox);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Location = new System.Drawing.Point(0, 98);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(422, 513);
            this.InfoPanel.TabIndex = 1;
            // 
            // EntryTimePicker
            // 
            this.EntryTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EntryTimePicker.Location = new System.Drawing.Point(190, 404);
            this.EntryTimePicker.Name = "EntryTimePicker";
            this.EntryTimePicker.Size = new System.Drawing.Size(212, 26);
            this.EntryTimePicker.TabIndex = 15;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(234, 462);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(156, 34);
            this.RegisterButton.TabIndex = 16;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BirthTimePicker
            // 
            this.BirthTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthTimePicker.Location = new System.Drawing.Point(190, 344);
            this.BirthTimePicker.Name = "BirthTimePicker";
            this.BirthTimePicker.Size = new System.Drawing.Size(212, 26);
            this.BirthTimePicker.TabIndex = 14;
            // 
            // SlastnameBox
            // 
            this.SlastnameBox.Location = new System.Drawing.Point(190, 256);
            this.SlastnameBox.Name = "SlastnameBox";
            this.SlastnameBox.Size = new System.Drawing.Size(212, 26);
            this.SlastnameBox.TabIndex = 13;
            // 
            // FlastnameBox
            // 
            this.FlastnameBox.Location = new System.Drawing.Point(190, 201);
            this.FlastnameBox.Name = "FlastnameBox";
            this.FlastnameBox.Size = new System.Drawing.Size(212, 26);
            this.FlastnameBox.TabIndex = 12;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(190, 142);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(212, 26);
            this.NameBox.TabIndex = 11;
            // 
            // IdentificationBox
            // 
            this.IdentificationBox.Location = new System.Drawing.Point(190, 84);
            this.IdentificationBox.Name = "IdentificationBox";
            this.IdentificationBox.Size = new System.Drawing.Size(212, 26);
            this.IdentificationBox.TabIndex = 10;
            this.IdentificationBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentificationBox_KeyPress);
            // 
            // SystemIdBox
            // 
            this.SystemIdBox.Location = new System.Drawing.Point(190, 28);
            this.SystemIdBox.Name = "SystemIdBox";
            this.SystemIdBox.Size = new System.Drawing.Size(212, 26);
            this.SystemIdBox.TabIndex = 9;
            this.SystemIdBox.TextChanged += new System.EventHandler(this.SystemIdBox_TextChanged);
            this.SystemIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SystemIdBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(10, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(10, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificacion";
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
            this.label1.Text = "ID en Sistema";
            // 
            // InsertAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1602, 610);
            this.Controls.Add(this.BackGrounPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InsertAdmin";
            this.Text = "Form1";
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.DateTimePicker EntryTimePicker;
        private System.Windows.Forms.DateTimePicker BirthTimePicker;
        private System.Windows.Forms.TextBox SlastnameBox;
        private System.Windows.Forms.TextBox FlastnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdentificationBox;
        private System.Windows.Forms.TextBox SystemIdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button DsiplayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SystemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
    }
}

