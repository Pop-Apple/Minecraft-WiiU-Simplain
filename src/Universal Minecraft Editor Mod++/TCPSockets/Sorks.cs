using System;
using System.IO;
using System.Windows.Forms;
using TCPGeckoSharp;

namespace Universal_Minecraft_Editor_Mod__
{
    public partial class Sorks : Form
    {
        public Sorks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public TCPGecko Gecko;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Gecko = new TCPGecko(textBox1.Text, 7331);
            StreamWriter streamWriter = new StreamWriter("Sorks IP.dll");
            streamWriter.Write(this.textBox1.Text);
            streamWriter.Close();
            try
            {
                this.Gecko.Connect();
                this.button1.Enabled = false;
                this.button2.Enabled = true;
                //this.load();
            }
            catch(ETCPGeckoException)
            {
                MessageBox.Show("Not Found IP / IPが見つかりません", "Sorks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Wrong IP / IPが間違っています","Sorks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Disconnect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Gecko.Disconnect();
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                //this.unload();
            }
            finally
            {
            }
        }
        /// <summary>
        /// Load IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = File.ReadAllText("Sorks IP.dll");
        }

        private void Sorks_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.Gecko.Connect())
            //{
            //    try
            //    {
            //        this.Gecko.Disconnect();
            //    }
            //    finally
            //    {
            //    }
            //}
        }
    }
}
