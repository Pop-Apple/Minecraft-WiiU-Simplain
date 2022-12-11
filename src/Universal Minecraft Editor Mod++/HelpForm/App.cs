using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Minecraft_Editor_Mod__
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool Translation = this.checkBox1.Checked;
            if (Translation)
            {
                this.label1.Text = "使ってくれてありがとう";
                this.label2.Text = "バージョン 1.7.3";
                this.label3.Text = "さぁ ダウンロードしよう！";
            }
            else
            {
                this.label1.Text = "Thank You For Uisng";
                this.label2.Text = "Version 1.7.3";
                this.label3.Text = "Let's Download !";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
