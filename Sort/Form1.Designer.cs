using System.Drawing;

namespace Sort
{
    partial class Sorter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorter));
            this.Sort = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.CatFolderBrowse = new System.Windows.Forms.Button();
            this.CurrentImgName = new System.Windows.Forms.Label();
            this.CatFoldersLabel = new System.Windows.Forms.Label();
            this.CatFoldersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ImgFolderBrowse = new System.Windows.Forms.Button();
            this.ImgView = new System.Windows.Forms.PictureBox();
            this.ImgFolder = new System.Windows.Forms.Label();
            this.CatFolder = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.NewDirNameBG = new System.Windows.Forms.Label();
            this.NewDirName = new System.Windows.Forms.TextBox();
            this.Mover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).BeginInit();
            this.SuspendLayout();
            // 
            // Sort
            // 
            this.Sort.Enabled = false;
            this.Sort.FlatAppearance.BorderSize = 0;
            this.Sort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Sort.Image = ((System.Drawing.Image)(resources.GetObject("Sort.Image")));
            this.Sort.Location = new System.Drawing.Point(727, 81);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 75);
            this.Sort.TabIndex = 4;
            this.Sort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            this.Sort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sort_MouseDown);
            this.Sort.MouseLeave += new System.EventHandler(this.Sort_MouseLeave);
            this.Sort.MouseHover += new System.EventHandler(this.Sort_MouseHover);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Exit.Location = new System.Drawing.Point(796, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(34, 25);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Exit_MouseHover);
            // 
            // Del
            // 
            this.Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Del.AutoSize = true;
            this.Del.Enabled = false;
            this.Del.FlatAppearance.BorderSize = 0;
            this.Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Lucida Console", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Del.Image = ((System.Drawing.Image)(resources.GetObject("Del.Image")));
            this.Del.Location = new System.Drawing.Point(738, 333);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(86, 74);
            this.Del.TabIndex = 9;
            this.Del.Text = "🗑";
            this.Del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            this.Del.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Del_MouseDown);
            this.Del.MouseLeave += new System.EventHandler(this.Del_MouseLeave);
            this.Del.MouseHover += new System.EventHandler(this.Del_MouseHover);
            // 
            // CatFolderBrowse
            // 
            this.CatFolderBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatFolderBrowse.AutoSize = true;
            this.CatFolderBrowse.FlatAppearance.BorderSize = 0;
            this.CatFolderBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CatFolderBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CatFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatFolderBrowse.Image = ((System.Drawing.Image)(resources.GetObject("CatFolderBrowse.Image")));
            this.CatFolderBrowse.Location = new System.Drawing.Point(724, 52);
            this.CatFolderBrowse.Name = "CatFolderBrowse";
            this.CatFolderBrowse.Size = new System.Drawing.Size(81, 26);
            this.CatFolderBrowse.TabIndex = 8;
            this.CatFolderBrowse.UseVisualStyleBackColor = true;
            this.CatFolderBrowse.Click += new System.EventHandler(this.CatFolderBrowse_Click);
            this.CatFolderBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CatFolderBrowse_MouseDown);
            this.CatFolderBrowse.MouseLeave += new System.EventHandler(this.CatFolderBrowse_MouseLeave);
            this.CatFolderBrowse.MouseHover += new System.EventHandler(this.CatFolderBrowse_MouseHover);
            // 
            // CurrentImgName
            // 
            this.CurrentImgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentImgName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CurrentImgName.Image = ((System.Drawing.Image)(resources.GetObject("CurrentImgName.Image")));
            this.CurrentImgName.Location = new System.Drawing.Point(215, 81);
            this.CurrentImgName.Name = "CurrentImgName";
            this.CurrentImgName.Size = new System.Drawing.Size(400, 27);
            this.CurrentImgName.TabIndex = 6;
            this.CurrentImgName.Text = "Image";
            this.CurrentImgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatFoldersLabel
            // 
            this.CatFoldersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatFoldersLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CatFoldersLabel.Image = ((System.Drawing.Image)(resources.GetObject("CatFoldersLabel.Image")));
            this.CatFoldersLabel.Location = new System.Drawing.Point(12, 372);
            this.CatFoldersLabel.Name = "CatFoldersLabel";
            this.CatFoldersLabel.Size = new System.Drawing.Size(98, 34);
            this.CatFoldersLabel.TabIndex = 5;
            this.CatFoldersLabel.Text = "Folders";
            this.CatFoldersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatFoldersLabel.Click += new System.EventHandler(this.CatFoldersLabel_Click);
            this.CatFoldersLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CatFoldersLabel_MouseDown);
            this.CatFoldersLabel.MouseLeave += new System.EventHandler(this.CatFoldersLabel_MouseLeave);
            this.CatFoldersLabel.MouseHover += new System.EventHandler(this.CatFoldersLabel_MouseHover);
            // 
            // CatFoldersLayout
            // 
            this.CatFoldersLayout.AutoScroll = true;
            this.CatFoldersLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CatFoldersLayout.BackgroundImage")));
            this.CatFoldersLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CatFoldersLayout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CatFoldersLayout.Location = new System.Drawing.Point(12, 409);
            this.CatFoldersLayout.Margin = new System.Windows.Forms.Padding(0);
            this.CatFoldersLayout.Name = "CatFoldersLayout";
            this.CatFoldersLayout.Size = new System.Drawing.Size(806, 212);
            this.CatFoldersLayout.TabIndex = 3;
            // 
            // ImgFolderBrowse
            // 
            this.ImgFolderBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgFolderBrowse.AutoSize = true;
            this.ImgFolderBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImgFolderBrowse.FlatAppearance.BorderSize = 0;
            this.ImgFolderBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImgFolderBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImgFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgFolderBrowse.Image = ((System.Drawing.Image)(resources.GetObject("ImgFolderBrowse.Image")));
            this.ImgFolderBrowse.Location = new System.Drawing.Point(724, 29);
            this.ImgFolderBrowse.Name = "ImgFolderBrowse";
            this.ImgFolderBrowse.Size = new System.Drawing.Size(81, 26);
            this.ImgFolderBrowse.TabIndex = 2;
            this.ImgFolderBrowse.UseVisualStyleBackColor = true;
            this.ImgFolderBrowse.Click += new System.EventHandler(this.ImgFolderBrowse_Click);
            this.ImgFolderBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgFolderBrowse_MouseDown);
            this.ImgFolderBrowse.MouseLeave += new System.EventHandler(this.ImgFolderBrose_MouseLeave);
            this.ImgFolderBrowse.MouseHover += new System.EventHandler(this.ImgFolderBrowse_MouseHover);
            // 
            // ImgView
            // 
            this.ImgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImgView.BackgroundImage")));
            this.ImgView.Location = new System.Drawing.Point(215, 111);
            this.ImgView.Margin = new System.Windows.Forms.Padding(206);
            this.ImgView.Name = "ImgView";
            this.ImgView.Size = new System.Drawing.Size(400, 288);
            this.ImgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgView.TabIndex = 0;
            this.ImgView.TabStop = false;
            // 
            // ImgFolder
            // 
            this.ImgFolder.BackColor = System.Drawing.Color.Transparent;
            this.ImgFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ImgFolder.Image = ((System.Drawing.Image)(resources.GetObject("ImgFolder.Image")));
            this.ImgFolder.Location = new System.Drawing.Point(26, 33);
            this.ImgFolder.Margin = new System.Windows.Forms.Padding(0);
            this.ImgFolder.Name = "ImgFolder";
            this.ImgFolder.Size = new System.Drawing.Size(699, 20);
            this.ImgFolder.TabIndex = 0;
            this.ImgFolder.Text = "Images Folder";
            this.ImgFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImgFolder.TextChanged += new System.EventHandler(this.ImgFolder_TextChanged);
            // 
            // CatFolder
            // 
            this.CatFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatFolder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CatFolder.Image = ((System.Drawing.Image)(resources.GetObject("CatFolder.Image")));
            this.CatFolder.Location = new System.Drawing.Point(26, 56);
            this.CatFolder.Margin = new System.Windows.Forms.Padding(0);
            this.CatFolder.Name = "CatFolder";
            this.CatFolder.Size = new System.Drawing.Size(699, 20);
            this.CatFolder.TabIndex = 11;
            this.CatFolder.Text = "Categories Folder";
            this.CatFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CatFolder.TextChanged += new System.EventHandler(this.CatFolder_TextChanged);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.MinimizeBtn.Location = new System.Drawing.Point(762, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(34, 25);
            this.MinimizeBtn.TabIndex = 12;
            this.MinimizeBtn.Text = "—";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Plus.Enabled = false;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Font = new System.Drawing.Font("Lucida Console", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Plus.Image = ((System.Drawing.Image)(resources.GetObject("Plus.Image")));
            this.Plus.Location = new System.Drawing.Point(113, 367);
            this.Plus.Margin = new System.Windows.Forms.Padding(0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(40, 40);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            this.Plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Plus_MouseDown);
            this.Plus.MouseLeave += new System.EventHandler(this.Plus_MouseLeave);
            this.Plus.MouseHover += new System.EventHandler(this.Plus_MouseHover);
            // 
            // NewDirNameBG
            // 
            this.NewDirNameBG.BackColor = System.Drawing.Color.Transparent;
            this.NewDirNameBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDirNameBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDirNameBG.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewDirNameBG.Image = ((System.Drawing.Image)(resources.GetObject("NewDirNameBG.Image")));
            this.NewDirNameBG.Location = new System.Drawing.Point(12, 333);
            this.NewDirNameBG.Name = "NewDirNameBG";
            this.NewDirNameBG.Size = new System.Drawing.Size(141, 34);
            this.NewDirNameBG.TabIndex = 14;
            this.NewDirNameBG.Text = "Name:";
            this.NewDirNameBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewDirName
            // 
            this.NewDirName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.NewDirName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewDirName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewDirName.Location = new System.Drawing.Point(54, 344);
            this.NewDirName.Name = "NewDirName";
            this.NewDirName.Size = new System.Drawing.Size(94, 13);
            this.NewDirName.TabIndex = 15;
            // 
            // Mover
            // 
            this.Mover.FlatAppearance.BorderSize = 0;
            this.Mover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Mover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mover.Location = new System.Drawing.Point(2, 2);
            this.Mover.Margin = new System.Windows.Forms.Padding(0);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(760, 25);
            this.Mover.TabIndex = 16;
            this.Mover.UseVisualStyleBackColor = true;
            this.Mover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseDown);
            this.Mover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseMove);
            this.Mover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mover_MouseUp);
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(830, 633);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.NewDirName);
            this.Controls.Add(this.NewDirNameBG);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CatFolder);
            this.Controls.Add(this.ImgFolder);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.CatFolderBrowse);
            this.Controls.Add(this.CurrentImgName);
            this.Controls.Add(this.CatFoldersLabel);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.CatFoldersLayout);
            this.Controls.Add(this.ImgFolderBrowse);
            this.Controls.Add(this.ImgView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImgSort";
            ((System.ComponentModel.ISupportInitialize)(this.ImgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgView;
        private System.Windows.Forms.Button ImgFolderBrowse;
        private System.Windows.Forms.FlowLayoutPanel CatFoldersLayout;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label CatFoldersLabel;
        private System.Windows.Forms.Label CurrentImgName;
        private System.Windows.Forms.Button CatFolderBrowse;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label ImgFolder;
        private System.Windows.Forms.Label CatFolder;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Label NewDirNameBG;
        private System.Windows.Forms.TextBox NewDirName;
        private System.Windows.Forms.Button Mover;
    }
}

