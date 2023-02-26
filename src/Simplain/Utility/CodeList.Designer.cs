namespace Simplain.Utility
{
    partial class CodeList
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
            this.ItemButton = new System.Windows.Forms.Button();
            this.EnchButton = new System.Windows.Forms.Button();
            this.PotionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemButton
            // 
            this.ItemButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemButton.Location = new System.Drawing.Point(0, 0);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(383, 55);
            this.ItemButton.TabIndex = 0;
            this.ItemButton.Text = "Item ID";
            this.ItemButton.UseVisualStyleBackColor = true;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // EnchButton
            // 
            this.EnchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnchButton.Location = new System.Drawing.Point(0, 55);
            this.EnchButton.Name = "EnchButton";
            this.EnchButton.Size = new System.Drawing.Size(383, 55);
            this.EnchButton.TabIndex = 1;
            this.EnchButton.Text = "Enchant ID";
            this.EnchButton.UseVisualStyleBackColor = true;
            this.EnchButton.Click += new System.EventHandler(this.EnchButton_Click);
            // 
            // PotionButton
            // 
            this.PotionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PotionButton.Location = new System.Drawing.Point(0, 110);
            this.PotionButton.Name = "PotionButton";
            this.PotionButton.Size = new System.Drawing.Size(383, 55);
            this.PotionButton.TabIndex = 2;
            this.PotionButton.Text = "Potion ID";
            this.PotionButton.UseVisualStyleBackColor = true;
            this.PotionButton.Click += new System.EventHandler(this.PotionButton_Click);
            // 
            // CodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(383, 166);
            this.Controls.Add(this.PotionButton);
            this.Controls.Add(this.EnchButton);
            this.Controls.Add(this.ItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CodeList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Code List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button EnchButton;
        private System.Windows.Forms.Button PotionButton;
    }
}