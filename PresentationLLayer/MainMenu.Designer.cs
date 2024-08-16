namespace PresentationLLayer
{
    partial class MainMenu
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
            this.RegisterAdminButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.AssociateButton = new System.Windows.Forms.Button();
            this.RegisterMovieButton = new System.Windows.Forms.Button();
            this.RegisterCategoryButton = new System.Windows.Forms.Button();
            this.RegisterBranchButton = new System.Windows.Forms.Button();
            this.RegisterCustomerButton = new System.Windows.Forms.Button();
            this.ServerControlPanel = new System.Windows.Forms.Panel();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.GreenLigth = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OffLabel = new System.Windows.Forms.Label();
            this.OnLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.ServerControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLigth)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterAdminButton
            // 
            this.RegisterAdminButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterAdminButton.Location = new System.Drawing.Point(25, 27);
            this.RegisterAdminButton.Name = "RegisterAdminButton";
            this.RegisterAdminButton.Size = new System.Drawing.Size(264, 31);
            this.RegisterAdminButton.TabIndex = 0;
            this.RegisterAdminButton.Text = "Menu Administradores";
            this.RegisterAdminButton.UseVisualStyleBackColor = true;
            this.RegisterAdminButton.Click += new System.EventHandler(this.RegisterAdminButton_Click);
            this.RegisterAdminButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegisterAdminButton_KeyPress);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(110, 295);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(164, 50);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Iniciar Servidor";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(351, 295);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(164, 50);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Detener Servidor";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HeaderPanel.Controls.Add(this.label8);
            this.HeaderPanel.Controls.Add(this.pictureBox);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1144, 98);
            this.HeaderPanel.TabIndex = 3;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(18, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 67);
            this.label8.TabIndex = 3;
            this.label8.Text = "VIDEOTECA";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PresentationLLayer.Properties.Resources.pngwing_com;
            this.pictureBox.Location = new System.Drawing.Point(1050, 11);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(84, 74);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.InfoPanel.Controls.Add(this.AssociateButton);
            this.InfoPanel.Controls.Add(this.RegisterMovieButton);
            this.InfoPanel.Controls.Add(this.RegisterCategoryButton);
            this.InfoPanel.Controls.Add(this.RegisterBranchButton);
            this.InfoPanel.Controls.Add(this.RegisterCustomerButton);
            this.InfoPanel.Controls.Add(this.RegisterAdminButton);
            this.InfoPanel.Location = new System.Drawing.Point(0, 97);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(319, 428);
            this.InfoPanel.TabIndex = 4;
            // 
            // AssociateButton
            // 
            this.AssociateButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssociateButton.Location = new System.Drawing.Point(25, 362);
            this.AssociateButton.Name = "AssociateButton";
            this.AssociateButton.Size = new System.Drawing.Size(264, 31);
            this.AssociateButton.TabIndex = 5;
            this.AssociateButton.Text = "Menu Peliculas x Sucursal";
            this.AssociateButton.UseVisualStyleBackColor = true;
            this.AssociateButton.Click += new System.EventHandler(this.AssociateButton_Click);
            // 
            // RegisterMovieButton
            // 
            this.RegisterMovieButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterMovieButton.Location = new System.Drawing.Point(25, 293);
            this.RegisterMovieButton.Name = "RegisterMovieButton";
            this.RegisterMovieButton.Size = new System.Drawing.Size(264, 31);
            this.RegisterMovieButton.TabIndex = 4;
            this.RegisterMovieButton.Text = "Menu Peliculas";
            this.RegisterMovieButton.UseVisualStyleBackColor = true;
            this.RegisterMovieButton.Click += new System.EventHandler(this.RegisterMovieButton_Click);
            // 
            // RegisterCategoryButton
            // 
            this.RegisterCategoryButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCategoryButton.Location = new System.Drawing.Point(25, 227);
            this.RegisterCategoryButton.Name = "RegisterCategoryButton";
            this.RegisterCategoryButton.Size = new System.Drawing.Size(264, 31);
            this.RegisterCategoryButton.TabIndex = 3;
            this.RegisterCategoryButton.Text = "Menu Categorias";
            this.RegisterCategoryButton.UseVisualStyleBackColor = true;
            this.RegisterCategoryButton.Click += new System.EventHandler(this.RegisterCategoryButton_Click);
            // 
            // RegisterBranchButton
            // 
            this.RegisterBranchButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBranchButton.Location = new System.Drawing.Point(25, 159);
            this.RegisterBranchButton.Name = "RegisterBranchButton";
            this.RegisterBranchButton.Size = new System.Drawing.Size(264, 31);
            this.RegisterBranchButton.TabIndex = 2;
            this.RegisterBranchButton.Text = "Menu Sucursales";
            this.RegisterBranchButton.UseVisualStyleBackColor = true;
            this.RegisterBranchButton.Click += new System.EventHandler(this.RegisterBranchButton_Click);
            // 
            // RegisterCustomerButton
            // 
            this.RegisterCustomerButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCustomerButton.Location = new System.Drawing.Point(25, 92);
            this.RegisterCustomerButton.Name = "RegisterCustomerButton";
            this.RegisterCustomerButton.Size = new System.Drawing.Size(264, 31);
            this.RegisterCustomerButton.TabIndex = 1;
            this.RegisterCustomerButton.Text = "Menu Clientes";
            this.RegisterCustomerButton.UseVisualStyleBackColor = true;
            this.RegisterCustomerButton.Click += new System.EventHandler(this.RegisterCustomerButton_Click);
            // 
            // ServerControlPanel
            // 
            this.ServerControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(70)))));
            this.ServerControlPanel.Controls.Add(this.listBoxLog);
            this.ServerControlPanel.Controls.Add(this.RedLight);
            this.ServerControlPanel.Controls.Add(this.GreenLigth);
            this.ServerControlPanel.Controls.Add(this.StatusLabel);
            this.ServerControlPanel.Controls.Add(this.OffLabel);
            this.ServerControlPanel.Controls.Add(this.OnLabel);
            this.ServerControlPanel.Controls.Add(this.StopButton);
            this.ServerControlPanel.Controls.Add(this.StartButton);
            this.ServerControlPanel.Location = new System.Drawing.Point(428, 123);
            this.ServerControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ServerControlPanel.Name = "ServerControlPanel";
            this.ServerControlPanel.Size = new System.Drawing.Size(608, 366);
            this.ServerControlPanel.TabIndex = 6;
            this.ServerControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ServerControlPanel_Paint);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxLog.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.HorizontalScrollbar = true;
            this.listBoxLog.ItemHeight = 20;
            this.listBoxLog.Location = new System.Drawing.Point(254, 98);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(323, 164);
            this.listBoxLog.TabIndex = 12;
            // 
            // RedLight
            // 
            this.RedLight.Image = global::PresentationLLayer.Properties.Resources.RedLight;
            this.RedLight.Location = new System.Drawing.Point(61, 192);
            this.RedLight.Margin = new System.Windows.Forms.Padding(2);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(39, 28);
            this.RedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedLight.TabIndex = 11;
            this.RedLight.TabStop = false;
            this.RedLight.Visible = false;
            // 
            // GreenLigth
            // 
            this.GreenLigth.Image = global::PresentationLLayer.Properties.Resources.GreenLight;
            this.GreenLigth.Location = new System.Drawing.Point(51, 120);
            this.GreenLigth.Margin = new System.Windows.Forms.Padding(2);
            this.GreenLigth.Name = "GreenLigth";
            this.GreenLigth.Size = new System.Drawing.Size(64, 56);
            this.GreenLigth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenLigth.TabIndex = 10;
            this.GreenLigth.TabStop = false;
            this.GreenLigth.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Showcard Gothic", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatusLabel.Location = new System.Drawing.Point(194, 42);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(249, 26);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Control del Servidor";
            // 
            // OffLabel
            // 
            this.OffLabel.AutoSize = true;
            this.OffLabel.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OffLabel.Location = new System.Drawing.Point(119, 192);
            this.OffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OffLabel.Name = "OffLabel";
            this.OffLabel.Size = new System.Drawing.Size(88, 21);
            this.OffLabel.TabIndex = 8;
            this.OffLabel.Text = "Apagado";
            // 
            // OnLabel
            // 
            this.OnLabel.AutoSize = true;
            this.OnLabel.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OnLabel.Location = new System.Drawing.Point(119, 133);
            this.OnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OnLabel.Name = "OnLabel";
            this.OnLabel.Size = new System.Drawing.Size(104, 21);
            this.OnLabel.TabIndex = 6;
            this.OnLabel.Text = "Encendido";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1040, 477);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 35);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1145, 523);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ServerControlPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.ServerControlPanel.ResumeLayout(false);
            this.ServerControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLigth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterAdminButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button RegisterCustomerButton;
        private System.Windows.Forms.Panel ServerControlPanel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label OffLabel;
        private System.Windows.Forms.Label OnLabel;
        private System.Windows.Forms.PictureBox GreenLigth;
        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RegisterMovieButton;
        private System.Windows.Forms.Button RegisterCategoryButton;
        private System.Windows.Forms.Button RegisterBranchButton;
        private System.Windows.Forms.Button AssociateButton;
        private System.Windows.Forms.ListBox listBoxLog;
    }
}