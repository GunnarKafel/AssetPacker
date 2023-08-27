namespace AssetPacker
{
    partial class packForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(packForm));
			this.packProgress = new System.Windows.Forms.ProgressBar();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.addonPathBox = new System.Windows.Forms.TextBox();
			this.browseAddonPath = new System.Windows.Forms.Button();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.deleteVrad3 = new System.Windows.Forms.CheckBox();
			this.deleteBakedResourceCache = new System.Windows.Forms.CheckBox();
			this.packAddonButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.deleteSaves = new System.Windows.Forms.CheckBox();
			this.deleteSFM = new System.Windows.Forms.CheckBox();
			this.deleteScreenshots = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.packedAddonBox = new System.Windows.Forms.TextBox();
			this.browsePackPath = new System.Windows.Forms.Button();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.addonSuffixBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.addonMaxSizeBox = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel5.SuspendLayout();
			this.flowLayoutPanel6.SuspendLayout();
			this.flowLayoutPanel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// packProgress
			// 
			this.packProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.packProgress.Location = new System.Drawing.Point(12, 498);
			this.packProgress.Name = "packProgress";
			this.packProgress.Size = new System.Drawing.Size(589, 23);
			this.packProgress.TabIndex = 11;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.addonPathBox);
			this.flowLayoutPanel1.Controls.Add(this.browseAddonPath);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 29);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(670, 32);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// addonPathBox
			// 
			this.addonPathBox.Location = new System.Drawing.Point(3, 3);
			this.addonPathBox.Name = "addonPathBox";
			this.addonPathBox.Size = new System.Drawing.Size(572, 20);
			this.addonPathBox.TabIndex = 0;
			this.addonPathBox.TextChanged += new System.EventHandler(this.addonPathBox_TextChanged);
			// 
			// browseAddonPath
			// 
			this.browseAddonPath.Location = new System.Drawing.Point(581, 3);
			this.browseAddonPath.Name = "browseAddonPath";
			this.browseAddonPath.Size = new System.Drawing.Size(86, 23);
			this.browseAddonPath.TabIndex = 1;
			this.browseAddonPath.Text = "Browse...";
			this.browseAddonPath.UseVisualStyleBackColor = true;
			this.browseAddonPath.Click += new System.EventHandler(this.browseAddonPath_Click);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.textBox2);
			this.flowLayoutPanel3.Controls.Add(this.button3);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 32);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(670, 33);
			this.flowLayoutPanel3.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(3, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(488, 20);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "game/ Addon Path";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(497, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Browse...";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// deleteVrad3
			// 
			this.deleteVrad3.AutoSize = true;
			this.deleteVrad3.Checked = true;
			this.deleteVrad3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.deleteVrad3.Location = new System.Drawing.Point(44, 19);
			this.deleteVrad3.Name = "deleteVrad3";
			this.deleteVrad3.Size = new System.Drawing.Size(93, 17);
			this.deleteVrad3.TabIndex = 0;
			this.deleteVrad3.Text = "Delete _vrad3";
			this.deleteVrad3.UseVisualStyleBackColor = true;
			// 
			// deleteBakedResourceCache
			// 
			this.deleteBakedResourceCache.AutoSize = true;
			this.deleteBakedResourceCache.Checked = true;
			this.deleteBakedResourceCache.CheckState = System.Windows.Forms.CheckState.Checked;
			this.deleteBakedResourceCache.Location = new System.Drawing.Point(44, 42);
			this.deleteBakedResourceCache.Name = "deleteBakedResourceCache";
			this.deleteBakedResourceCache.Size = new System.Drawing.Size(161, 17);
			this.deleteBakedResourceCache.TabIndex = 1;
			this.deleteBakedResourceCache.Text = "Delete _bakeresourcecache";
			this.deleteBakedResourceCache.UseVisualStyleBackColor = true;
			// 
			// packAddonButton
			// 
			this.packAddonButton.Enabled = false;
			this.packAddonButton.Location = new System.Drawing.Point(607, 498);
			this.packAddonButton.Name = "packAddonButton";
			this.packAddonButton.Size = new System.Drawing.Size(75, 23);
			this.packAddonButton.TabIndex = 12;
			this.packAddonButton.Text = "Pack Addons";
			this.packAddonButton.UseVisualStyleBackColor = true;
			this.packAddonButton.Click += new System.EventHandler(this.packAddonButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.deleteSaves);
			this.groupBox1.Controls.Add(this.deleteSFM);
			this.groupBox1.Controls.Add(this.deleteScreenshots);
			this.groupBox1.Controls.Add(this.deleteBakedResourceCache);
			this.groupBox1.Controls.Add(this.deleteVrad3);
			this.groupBox1.Location = new System.Drawing.Point(12, 169);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(667, 100);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Optimizations";
			// 
			// deleteSaves
			// 
			this.deleteSaves.AutoSize = true;
			this.deleteSaves.Checked = true;
			this.deleteSaves.CheckState = System.Windows.Forms.CheckState.Checked;
			this.deleteSaves.Location = new System.Drawing.Point(253, 42);
			this.deleteSaves.Name = "deleteSaves";
			this.deleteSaves.Size = new System.Drawing.Size(90, 17);
			this.deleteSaves.TabIndex = 4;
			this.deleteSaves.Text = "Delete Saves";
			this.deleteSaves.UseVisualStyleBackColor = true;
			// 
			// deleteSFM
			// 
			this.deleteSFM.AutoSize = true;
			this.deleteSFM.Checked = true;
			this.deleteSFM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.deleteSFM.Location = new System.Drawing.Point(253, 19);
			this.deleteSFM.Name = "deleteSFM";
			this.deleteSFM.Size = new System.Drawing.Size(128, 17);
			this.deleteSFM.TabIndex = 3;
			this.deleteSFM.Text = "Delete SFM Elements";
			this.deleteSFM.UseVisualStyleBackColor = true;
			// 
			// deleteScreenshots
			// 
			this.deleteScreenshots.AutoSize = true;
			this.deleteScreenshots.Checked = true;
			this.deleteScreenshots.CheckState = System.Windows.Forms.CheckState.Checked;
			this.deleteScreenshots.Location = new System.Drawing.Point(44, 65);
			this.deleteScreenshots.Name = "deleteScreenshots";
			this.deleteScreenshots.Size = new System.Drawing.Size(119, 17);
			this.deleteScreenshots.TabIndex = 2;
			this.deleteScreenshots.Text = "Delete Screenshots";
			this.deleteScreenshots.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.packedAddonBox);
			this.flowLayoutPanel2.Controls.Add(this.browsePackPath);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 80);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(670, 32);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// packedAddonBox
			// 
			this.packedAddonBox.Location = new System.Drawing.Point(3, 3);
			this.packedAddonBox.Name = "packedAddonBox";
			this.packedAddonBox.Size = new System.Drawing.Size(572, 20);
			this.packedAddonBox.TabIndex = 0;
			this.packedAddonBox.TextChanged += new System.EventHandler(this.packedAddonBox_TextChanged);
			// 
			// browsePackPath
			// 
			this.browsePackPath.Location = new System.Drawing.Point(581, 3);
			this.browsePackPath.Name = "browsePackPath";
			this.browsePackPath.Size = new System.Drawing.Size(86, 23);
			this.browsePackPath.TabIndex = 1;
			this.browsePackPath.Text = "Browse...";
			this.browsePackPath.UseVisualStyleBackColor = true;
			this.browsePackPath.Click += new System.EventHandler(this.browsePackPath_Click);
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel5.Controls.Add(this.label1);
			this.flowLayoutPanel5.Controls.Add(this.linkLabel1);
			this.flowLayoutPanel5.Controls.Add(this.linkLabel2);
			this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 476);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(667, 16);
			this.flowLayoutPanel5.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Addon Packer by Gunnar Kafel";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(163, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(42, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Donate";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(211, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(45, 13);
			this.linkLabel2.TabIndex = 2;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "gkaf.me";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Addon Directory";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Packed Addons Directory";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(163, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Packed Folder Suffix";
			// 
			// addonSuffixBox
			// 
			this.addonSuffixBox.Location = new System.Drawing.Point(3, 3);
			this.addonSuffixBox.Name = "addonSuffixBox";
			this.addonSuffixBox.Size = new System.Drawing.Size(125, 20);
			this.addonSuffixBox.TabIndex = 12;
			this.addonSuffixBox.Text = "_part";
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.Controls.Add(this.addonSuffixBox);
			this.flowLayoutPanel6.Location = new System.Drawing.Point(163, 131);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(128, 32);
			this.flowLayoutPanel6.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Part Size in GB";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.Controls.Add(this.addonMaxSizeBox);
			this.flowLayoutPanel7.Location = new System.Drawing.Point(12, 131);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(128, 32);
			this.flowLayoutPanel7.TabIndex = 6;
			// 
			// addonMaxSizeBox
			// 
			this.addonMaxSizeBox.Location = new System.Drawing.Point(3, 3);
			this.addonMaxSizeBox.Name = "addonMaxSizeBox";
			this.addonMaxSizeBox.Size = new System.Drawing.Size(125, 20);
			this.addonMaxSizeBox.TabIndex = 0;
			this.addonMaxSizeBox.Text = "2";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// packForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(694, 533);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.flowLayoutPanel7);
			this.Controls.Add(this.flowLayoutPanel6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.flowLayoutPanel5);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.packAddonButton);
			this.Controls.Add(this.packProgress);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "packForm";
			this.Text = "Addon Packer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.flowLayoutPanel6.ResumeLayout(false);
			this.flowLayoutPanel6.PerformLayout();
			this.flowLayoutPanel7.ResumeLayout(false);
			this.flowLayoutPanel7.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox addonPathBox;
        private System.Windows.Forms.Button browseAddonPath;
        private System.Windows.Forms.CheckBox deleteVrad3;
        private System.Windows.Forms.CheckBox deleteBakedResourceCache;
        private System.Windows.Forms.Button packAddonButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox packedAddonBox;
        private System.Windows.Forms.Button browsePackPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addonSuffixBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.TextBox addonMaxSizeBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.CheckBox deleteSFM;
		private System.Windows.Forms.CheckBox deleteScreenshots;
		private System.Windows.Forms.CheckBox deleteSaves;
		public System.Windows.Forms.ProgressBar packProgress;
	}
}

