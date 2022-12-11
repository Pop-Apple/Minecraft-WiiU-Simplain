using System.Windows.Forms;

namespace Universal_Minecraft_Editor_Mod__
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }
        //Closing
        private void frmNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Formを閉じてもよろしいですか？","Note Pad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//YourMessage
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
