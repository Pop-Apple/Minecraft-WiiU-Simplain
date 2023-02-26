using System;
using System.Windows.Forms;

namespace Simplain.Tools
{
    public partial class ColorValue : Form
    {
        public ColorValue()
        {
            InitializeComponent();

            /*------------------------------------------*/

            ArmorColorList.Items.Add("Red");
            ArmorColorList.Items.Add("Blue");
            ArmorColorList.Items.Add("Yellow");
            ArmorColorList.Items.Add("Green");
            ArmorColorList.Items.Add("Pink");
            ArmorColorList.Items.Add("White");
            ArmorColorList.Items.Add("Gray");

            /*------------------------------------------*/

            PotionColorList.Items.Add("Red");
            PotionColorList.Items.Add("Blue");
            PotionColorList.Items.Add("Yellow");
            PotionColorList.Items.Add("Green");
            PotionColorList.Items.Add("Pink");
            PotionColorList.Items.Add("Dark Red");
            PotionColorList.Items.Add("Wihte");
            PotionColorList.Items.Add("Gray");

            /*------------------------------------------*/
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (var ColorDialog = new ColorDialog())
            {
                if (ColorDialog.ShowDialog() == DialogResult.OK)
                {
                    panel1.BackColor = ColorDialog.Color;

                    string strR = Convert.ToString(ColorDialog.Color.R, 10);
                    string strG = Convert.ToString(ColorDialog.Color.G, 10);
                    string strB = Convert.ToString(ColorDialog.Color.B, 10);

                    RedLabel.Text = strR;
                    GreenLabel.Text = strG;
                    BlueLabel.Text = strB;
                }
            }
        }

        /*------------------------------------------*/

        #region ArmorColor

        string ArmorRed = "0a000103030005636f6c6f7200ff000000";
        string ArmorBlue = "0a000103030005636f6c6f7200003eff00";
        string ArmorYellow = "0a000103030005636f6c6f7200fff00000";
        string ArmorGreen = "0a000103030005636f6c6f720000ff1700";
        string ArmorPink = "0a000103030005636f6c6f7200ff95ff00";
        string ArmorWhite = "0a000103030005636f6c6f7200ffffff00";
        string ArmorGray = "0a000103030005636f6c6f72006d6d6d00";

        #endregion

        /*------------------------------------------*/

        private void ArmorColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArmorColorList.SelectedIndex == 0)
            {
                this.ArmorResultBox.Text = ArmorRed;
            }
            else if (ArmorColorList.SelectedIndex == 1)
            {
                this.ArmorResultBox.Text = ArmorBlue;
            }
            else if (ArmorColorList.SelectedIndex == 2)
            {
                this.ArmorResultBox.Text = ArmorYellow;
            }
            else if (ArmorColorList.SelectedIndex == 3)
            {
                this.ArmorResultBox.Text = ArmorGreen;
            }
            else if (ArmorColorList.SelectedIndex == 4)
            {
                this.ArmorResultBox.Text = ArmorPink;
            }
            else if (ArmorColorList.SelectedIndex == 5)
            {
                this.ArmorResultBox.Text = ArmorWhite;
            }
            else if (ArmorColorList.SelectedIndex == 6)
            {
                this.ArmorResultBox.Text = ArmorGray;
            }
        }

        /*------------------------------------------*/

        private void ArmorCopyButton_Click(object sender, EventArgs e)
        {
            this.ArmorResultBox.SelectAll();
            this.ArmorResultBox.Copy();
        }

        /*------------------------------------------*/

        #region PotionColor

        string PotionRed = "0a000108080006506f74696f6e00116d696e6563726166743a6865616c696e6700";
        string PotionBlue = "0a000108080006506f74696f6e00166d696e6563726166743a6e696768745f766973696f6e00";
        string PotionYellow = "0a000108080006506f74696f6e00196d696e6563726166743a666972655f726573697374616e636500";
        string PotionGreen = "0a000108080006506f74696f6e00116d696e6563726166743a6c656170696e6700";
        string PotionPink = "0a000108080006506f74696f6e00166d696e6563726166743a726567656e65726174696f6e00";
        string PotionDarkRed = "0a000108080006506f74696f6e00126d696e6563726166743a737472656e67746800";
        string PotionWhite = "0a000108080006506f74696f6e00166d696e6563726166743a736c6f775f66616c6c696e6700";
        string PotionGray = "0a000108080006506f74696f6e00106d696e6563726166743a776974686572000a000108080006506f74696f6e00106d696e6563726166743a77697468657200";

        #endregion

        /*------------------------------------------*/

        private void PotionColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PotionColorList.SelectedIndex == 0)
            {
                this.PotionResultBox.Text = PotionRed;
            }
            else if (PotionColorList.SelectedIndex == 1)
            {
                this.PotionResultBox.Text = PotionBlue;
            }
            else if (PotionColorList.SelectedIndex == 2)
            {
                this.PotionResultBox.Text = PotionYellow;
            }
            else if (PotionColorList.SelectedIndex == 3)
            {
                this.PotionResultBox.Text = PotionGreen;
            }
            else if (PotionColorList.SelectedIndex == 4)
            {
                this.PotionResultBox.Text = PotionPink;
            }
            else if (PotionColorList.SelectedIndex == 5)
            {
                this.PotionResultBox.Text = PotionDarkRed;
            }
            else if (PotionColorList.SelectedIndex == 6)
            {
                this.PotionResultBox.Text = PotionWhite;
            }
            else if (PotionColorList.SelectedIndex == 7)
            {
                this.PotionResultBox.Text = PotionGray;
            }
        }

        /*------------------------------------------*/

        private void CopyButton2_Click(object sender, EventArgs e)
        {
            this.PotionResultBox.SelectAll();
            this.PotionResultBox.Copy();
        }
    }
}
