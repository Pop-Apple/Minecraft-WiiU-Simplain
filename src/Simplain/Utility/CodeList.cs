using NBTCraftTool.Terminal;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Simplain.Utility
{
    public partial class CodeList : Form
    {
        public CodeList()
        {
            InitializeComponent();
        }

        /*------------------------------------------*/

        private void ItemButton_Click(object sender, EventArgs e)
        {
            var ItemID = "https://minecraft-ids.grahamedgecombe.com/";
            Process.Start(ItemID);
        }

        /*------------------------------------------*/

        private void EnchButton_Click(object sender, EventArgs e)
        {
            EnchantID enchantID = new EnchantID();
            enchantID.Show();
        }

        /*------------------------------------------*/

        private void PotionButton_Click(object sender, EventArgs e)
        {
            PotionID potionID = new PotionID();
            potionID.Show();
        }
    }
}
