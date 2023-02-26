namespace Simplain
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDListStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BiomeStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.NotepadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalIPAddressStripButon = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildDateStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.bugTrackerStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.VersionStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.RotationStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.SummaryLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TargetList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 382);
            this.panel1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(18, 313);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(234, 46);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(18, 261);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(234, 46);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new System.Drawing.Point(18, 147);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(194, 54);
            this.SummaryLabel.TabIndex = 3;
            this.SummaryLabel.Text = "Selected Item Not Found\r\n\r\n***";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summary:";
            // 
            // TargetList
            // 
            this.TargetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetList.FormattingEnabled = true;
            this.TargetList.Location = new System.Drawing.Point(18, 46);
            this.TargetList.Name = "TargetList";
            this.TargetList.Size = new System.Drawing.Size(234, 26);
            this.TargetList.TabIndex = 1;
            this.TargetList.SelectedIndexChanged += new System.EventHandler(this.TargetList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Item";
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ヘルプHToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(538, 32);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStripButton,
            this.toolStripSeparator,
            this.ExitStripButton});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.ファイルFToolStripMenuItem.Text = "File (&F)";
            // 
            // NewStripButton
            // 
            this.NewStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewStripButton.Image")));
            this.NewStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewStripButton.Name = "NewStripButton";
            this.NewStripButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewStripButton.Size = new System.Drawing.Size(270, 34);
            this.NewStripButton.Text = "新規作成(&N)";
            this.NewStripButton.Click += new System.EventHandler(this.NewStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(267, 6);
            // 
            // ExitStripButton
            // 
            this.ExitStripButton.Name = "ExitStripButton";
            this.ExitStripButton.Size = new System.Drawing.Size(270, 34);
            this.ExitStripButton.Text = "終了(&X)";
            this.ExitStripButton.Click += new System.EventHandler(this.ExitStripButton_Click);
            // 
            // ツールTToolStripMenuItem
            // 
            this.ツールTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IDListStripButton,
            this.ColorStripButton,
            this.BiomeStripButton,
            this.RotationStripButton,
            this.toolStripMenuItem1,
            this.NotepadButton});
            this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
            this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.ツールTToolStripMenuItem.Text = "Tool (&T)";
            // 
            // IDListStripButton
            // 
            this.IDListStripButton.Name = "IDListStripButton";
            this.IDListStripButton.Size = new System.Drawing.Size(270, 34);
            this.IDListStripButton.Text = "Minecraft ID List (&M)";
            this.IDListStripButton.Click += new System.EventHandler(this.IDListStripButton_Click);
            // 
            // ColorStripButton
            // 
            this.ColorStripButton.Name = "ColorStripButton";
            this.ColorStripButton.Size = new System.Drawing.Size(270, 34);
            this.ColorStripButton.Text = "Color Value Editor (&C)";
            this.ColorStripButton.Click += new System.EventHandler(this.ColorStripButton_Click);
            // 
            // BiomeStripButton
            // 
            this.BiomeStripButton.Name = "BiomeStripButton";
            this.BiomeStripButton.Size = new System.Drawing.Size(270, 34);
            this.BiomeStripButton.Text = "Biome Value Editor (&B)";
            this.BiomeStripButton.Click += new System.EventHandler(this.BiomeStripButton_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // NotepadButton
            // 
            this.NotepadButton.Image = ((System.Drawing.Image)(resources.GetObject("NotepadButton.Image")));
            this.NotepadButton.Name = "NotepadButton";
            this.NotepadButton.Size = new System.Drawing.Size(270, 34);
            this.NotepadButton.Text = "Notepad (&N)";
            this.NotepadButton.Click += new System.EventHandler(this.NotepadButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalIPAddressStripButon,
            this.BuildDateStripButton,
            this.toolStripMenuItem3,
            this.bugTrackerStripButton});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 28);
            this.toolStripMenuItem2.Text = "Terminal (&R)";
            // 
            // LocalIPAddressStripButon
            // 
            this.LocalIPAddressStripButon.Image = ((System.Drawing.Image)(resources.GetObject("LocalIPAddressStripButon.Image")));
            this.LocalIPAddressStripButon.Name = "LocalIPAddressStripButon";
            this.LocalIPAddressStripButon.Size = new System.Drawing.Size(270, 34);
            this.LocalIPAddressStripButon.Text = "Local IP Address";
            this.LocalIPAddressStripButon.Click += new System.EventHandler(this.LocalIPAddressStripButon_Click);
            // 
            // BuildDateStripButton
            // 
            this.BuildDateStripButton.Name = "BuildDateStripButton";
            this.BuildDateStripButton.Size = new System.Drawing.Size(270, 34);
            this.BuildDateStripButton.Text = "Build Date";
            this.BuildDateStripButton.Click += new System.EventHandler(this.BuildDateStripButton_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(267, 6);
            // 
            // bugTrackerStripButton
            // 
            this.bugTrackerStripButton.Name = "bugTrackerStripButton";
            this.bugTrackerStripButton.Size = new System.Drawing.Size(270, 34);
            this.bugTrackerStripButton.Text = "Bug Tracker";
            this.bugTrackerStripButton.Click += new System.EventHandler(this.bugTrackerStripButton_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoStripButton,
            this.toolStripSeparator5,
            this.VersionStripButton});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.ヘルプHToolStripMenuItem.Text = "Help (&H)";
            // 
            // InfoStripButton
            // 
            this.InfoStripButton.Name = "InfoStripButton";
            this.InfoStripButton.Size = new System.Drawing.Size(270, 34);
            this.InfoStripButton.Text = "内容(&C)";
            this.InfoStripButton.Click += new System.EventHandler(this.InfoStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(267, 6);
            // 
            // VersionStripButton
            // 
            this.VersionStripButton.Image = ((System.Drawing.Image)(resources.GetObject("VersionStripButton.Image")));
            this.VersionStripButton.Name = "VersionStripButton";
            this.VersionStripButton.Size = new System.Drawing.Size(270, 34);
            this.VersionStripButton.Text = "バージョン情報(&A)...";
            this.VersionStripButton.Click += new System.EventHandler(this.VersionStripButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.ResultTextBox);
            this.panel2.Location = new System.Drawing.Point(318, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 382);
            this.panel2.TabIndex = 2;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ResultTextBox.Location = new System.Drawing.Point(13, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(173, 356);
            this.ResultTextBox.TabIndex = 3;
            // 
            // RotationStripButton
            // 
            this.RotationStripButton.Name = "RotationStripButton";
            this.RotationStripButton.Size = new System.Drawing.Size(270, 34);
            this.RotationStripButton.Text = "Rotation Editor (&R)";
            this.RotationStripButton.Click += new System.EventHandler(this.RotationStripButton_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplain   |   Pop-Apple";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TargetList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitStripButton;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem VersionStripButton;
        private System.Windows.Forms.ToolStripMenuItem IDListStripButton;
        private System.Windows.Forms.ToolStripMenuItem ColorStripButton;
        private System.Windows.Forms.ToolStripMenuItem BiomeStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NotepadButton;
        private System.Windows.Forms.ToolStripMenuItem InfoStripButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem LocalIPAddressStripButon;
        private System.Windows.Forms.ToolStripMenuItem BuildDateStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bugTrackerStripButton;
        private System.Windows.Forms.ToolStripMenuItem RotationStripButton;
    }
}

