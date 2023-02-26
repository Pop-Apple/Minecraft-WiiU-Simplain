using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Simplain.Utility
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void OpenSystemNotepadButton_Click(object sender, EventArgs e)
        {
            var Notepad = "notepad.exe";
            Process.Start(Notepad);
        }
    }
}
