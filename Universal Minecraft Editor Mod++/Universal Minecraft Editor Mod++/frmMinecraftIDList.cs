using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Minecraft_Editor_Mod__
{
    public partial class frmMinecraftIDList : Form
    {
        public frmMinecraftIDList()
        {
            InitializeComponent();
        }
　　　　//Online ID List (高性能)
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://minecraft-ids.grahamedgecombe.com/");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://minecraft-ids.grahamedgecombe.com/entities");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://minecraft-ids.grahamedgecombe.com/potion-calculator");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //0北(上)
            //1南(下)
            //2西(左)
            //3東(右)
            //4北東(右上)
            //5南東(右下)
            //6南西(左下)
            //7北西(左上)
            if (comboBox1.SelectedIndex == 0)
            {
                label4.Text = "180";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = "0";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label4.Text = "90";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label4.Text = "-90";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                label4.Text = "220";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                label4.Text = "320";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                label4.Text = "45";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                label4.Text = "130";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
