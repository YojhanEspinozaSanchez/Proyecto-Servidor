namespace PresentationLLayer
{
    partial class AddBranch
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
            this.IdBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.ActiveComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.AdminIdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BranchIdBox = new System.Windows.Forms.TextBox();
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
            this.BackGrounPanel.Size = new System.Drawing.Size(1522, 593);
            this.BackGrounPanel.TabIndex = 2;
            this.BackGrounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGrounPanel_Paint);
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBranch,
            this.NameBranch,
            this.IdAdmin,
            this.NameAdmin,
            this.bAddress,
            this.bPhoneNumber,
            this.bActive});
            this.dataGridView.Location = new System.Drawing.Point(417, 103);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1087, 426);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // IdBranch
            // 
            this.IdBranch.HeaderText = "ID de Sucursal";
            this.IdBranch.MinimumWidth = 9;
            this.IdBranch.Name = "IdBranch";
            this.IdBranch.ReadOnly = true;
            this.IdBranch.Width = 175;
            // 
            // NameBranch
            // 
            this.NameBranch.HeaderText = "Nombre de Sucursal";
            this.NameBranch.MinimumWidth = 9;
            this.NameBranch.Name = "NameBranch";
            this.NameBranch.ReadOnly = true;
            this.NameBranch.Width = 175;
            // 
            // IdAdmin
            // 
            this.IdAdmin.HeaderText = "ID de Encargado";
            this.IdAdmin.MinimumWidth = 9;
            this.IdAdmin.Name = "IdAdmin";
            this.IdAdmin.ReadOnly = true;
            this.IdAdmin.Width = 175;
            // 
            // NameAdmin
            // 
            this.NameAdmin.HeaderText = "Nombre de Encargado";
            this.NameAdmin.MinimumWidth = 9;
            this.NameAdmin.Name = "NameAdmin";
            this.NameAdmin.ReadOnly = true;
            this.NameAdmin.Width = 175;
            // 
            // bAddress
            // 
            this.bAddress.HeaderText = "Direccion de Sucursal";
            this.bAddress.MinimumWidth = 9;
            this.bAddress.Name = "bAddress";
            this.bAddress.ReadOnly = true;
            this.bAddress.Width = 175;
            // 
            // bPhoneNumber
            // 
            this.bPhoneNumber.HeaderText = "Numero de Telefono";
            this.bPhoneNumber.MinimumWidth = 9;
            this.bPhoneNumber.Name = "bPhoneNumber";
            this.bPhoneNumber.ReadOnly = true;
            this.bPhoneNumber.Width = 175;
            // 
            // bActive
            // 
            this.bActive.HeaderText = "Activo";
            this.bActive.MinimumWidth = 9;
            this.bActive.Name = "bActive";
            this.bActive.ReadOnly = true;
            this.bActive.Width = 175;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.ActiveComboBox);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.RegisterButton);
            this.InfoPanel.Controls.Add(this.PhoneNumberBox);
            this.InfoPanel.Controls.Add(this.AddressBox);
            this.InfoPanel.Controls.Add(this.AdminIdBox);
            this.InfoPanel.Controls.Add(this.NameBox);
            this.InfoPanel.Controls.Add(this.BranchIdBox);
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
            // ActiveComboBox
            // 
            this.ActiveComboBox.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveComboBox.FormattingEnabled = true;
            this.ActiveComboBox.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.ActiveComboBox.Location = new System.Drawing.Point(182, 311);
            this.ActiveComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveComboBox.Name = "ActiveComboBox";
            this.ActiveComboBox.Size = new System.Drawing.Size(100, 28);
            this.ActiveComboBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(10, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Activo";
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
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(182, 249);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(203, 26);
            this.PhoneNumberBox.TabIndex = 13;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberBox_KeyPress);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(182, 195);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(203, 26);
            this.AddressBox.TabIndex = 12;
            // 
            // AdminIdBox
            // 
            this.AdminIdBox.Location = new System.Drawing.Point(182, 138);
            this.AdminIdBox.Name = "AdminIdBox";
            this.AdminIdBox.Size = new System.Drawing.Size(203, 26);
            this.AdminIdBox.TabIndex = 11;
            this.AdminIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminIdBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(182, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(203, 26);
            this.NameBox.TabIndex = 10;
            // 
            // BranchIdBox
            // 
            this.BranchIdBox.Location = new System.Drawing.Point(182, 28);
            this.BranchIdBox.Name = "BranchIdBox";
            this.BranchIdBox.Size = new System.Drawing.Size(203, 26);
            this.BranchIdBox.TabIndex = 9;
            this.BranchIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BranchIdBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(10, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(10, 197);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Encargado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Sucursal";
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 593);
            this.Controls.Add(this.BackGrounPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddBranch";
            this.Text = "AddBranch";
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
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox AdminIdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox BranchIdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn bActive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ActiveComboBox;
    }
}