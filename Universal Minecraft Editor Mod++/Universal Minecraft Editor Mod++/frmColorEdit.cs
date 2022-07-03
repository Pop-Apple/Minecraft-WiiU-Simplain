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
    public partial class frmColorEdit : Form
    {
        public frmColorEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
                //Html Value
                string strR = Convert.ToString(colorDialog1.Color.R, 10);
                string strG = Convert.ToString(colorDialog1.Color.G, 10);
                string strB = Convert.ToString(colorDialog1.Color.B, 10);
                //Color Code
                labelR.Text = strR;
                labelG.Text = strG;
                labelB.Text = strB;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //赤
            //青
            //黄
            //緑
            //ピンク
            //濃い赤
            //白
            //灰
            if (comboBox1.SelectedIndex == 0)
            {
                //赤
                txtColor.Text = "0a000108080006506f74696f6e00116d696e6563726166743a6865616c696e6700";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                //青
                txtColor.Text = "0a000108080006506f74696f6e00166d696e6563726166743a6e696768745f766973696f6e00";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                //黄
                txtColor.Text = "0a000108080006506f74696f6e00196d696e6563726166743a666972655f726573697374616e636500";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                //緑
                txtColor.Text = "0a000108080006506f74696f6e00116d696e6563726166743a6c656170696e6700";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                //ピンク
                txtColor.Text = "0a000108080006506f74696f6e00166d696e6563726166743a726567656e65726174696f6e00";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                //濃い赤
                txtColor.Text = "0a000108080006506f74696f6e00126d696e6563726166743a737472656e67746800";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                //白
                txtColor.Text = "0a000108080006506f74696f6e00166d696e6563726166743a736c6f775f66616c6c696e6700";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                //灰
                txtColor.Text = "0a000108080006506f74696f6e00106d696e6563726166743a77697468657200";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtColor.SelectAll();
            this.txtColor.Copy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtColor.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                //赤
                textBox1.Text = "0a000103030005636f6c6f7200ff000000";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                //青
                textBox1.Text = "0a000103030005636f6c6f7200003eff00";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                //黄
                textBox1.Text = "0a000103030005636f6c6f7200fff00000";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                //緑
                textBox1.Text = "0a000103030005636f6c6f720000ff1700";
            }
            if (comboBox2.SelectedIndex == 4)
            {
                //ピンク
                textBox1.Text = "0a000103030005636f6c6f7200ff95ff00";
            }
            if (comboBox2.SelectedIndex == 5)
            {
                //白
                textBox1.Text = "0a000103030005636f6c6f7200ffffff00";
            }
            if (comboBox2.SelectedIndex == 6)
            {
                //灰
                textBox1.Text = "0a000103030005636f6c6f72006d6d6d00";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Copy();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool G1 = this.checkBox1.Checked;
            if (G1)
            {
                this.groupBox2.Enabled = true;
                this.checkBox2.Enabled = false;
            }
            else
            {
                this.groupBox2.Enabled = false;
                    this.checkBox2.Enabled = true; 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool G3 = this.checkBox2.Checked;
            if(G3)
            {
                this.groupBox3.Enabled = true;
                this.checkBox1.Enabled = false;
            }
            else
            {
                this.groupBox3.Enabled = false;
                this.checkBox1.Enabled = true;
            }
        }
    }
}
