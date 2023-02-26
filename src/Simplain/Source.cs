using Simplain.Information;
using Simplain.Tool;
using Simplain.Tools;
using Simplain.Utility;
using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Simplain
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();

            /*------------------------------------------*/

            TargetList.Items.Add("area_effect_cloud");
            TargetList.Items.Add("AttributeModifiers");
            TargetList.Items.Add("SpawnerVillager");
            TargetList.Items.Add("Position");

            this.ResultTextBox.Text = "***";
            this.ResultTextBox.CharacterCasing = CharacterCasing.Upper;

            /*------------------------------------------*/

        }

        private void TargetList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            /*------------------------------------------*/

            #region Binary

            string area_effect_cloud = "0a00010a0a00000800094f776e657255554944000c4170706c655f6b756e2e32350300085061727469636c6500000000020003416972012c02000446697265ffff03000e5061727469636c65506172616d310000000005000b5261646975734f6e5573650000000003000d4475726174696f6e4f6e557365000000000300084475726174696f6e3b9ac9ff030003416765060dbd7f08000a437573746f6d4e616d65000854656d706c6174650800096f776e65725555494400000900064d6f74696f6e060000000300000000000000000000000000000000000000000000000001000d637265617465644f6e486f7374000500065261646975733dcccccd0100084f6e47726f756e6400080006506f74696f6e000f6d696e6563726166743a7761746572090008526f746174696f6e050000000200000000000000000100176e616d6564427952657374726963746564506c617965720001000c496e76756c6e657261626c650005000d5261646975735065725469636b00000000010011437573746f6d4e616d6556697369626c65010300085761697454696d650000000005000c46616c6c44697374616e63650000000008000455554944001c3132333435363738393837363534333233343538373635343332333503000e506f7274616c436f6f6c646f776e0000000003000e5061727469636c65506172616d320000000003000944696d656e73696f6e0000000003001252656170706c69636174696f6e44656c6179000000000800026964001b6d696e6563726166743a617265615f6566666563745f636c6f75640000";
            string AttributeModifiers = "0a00010a0a00037461670900124174747269627574654d6f646966696572730a00000001030002494400000000060006416d6f756e740000000000000000000000";
            string SpawnerVillager = "0a00010a0a00000a00037461670a000e426c6f636b456e746974795461670a0009537061776e44617461080002696400126d696e6563726166743a76696c6c616765720a00064f66666572730900075265636970657301000000000001000c496e76756c6e657261626c65010100094e6f477261766974790001000653696c656e7401010007476c6f77696e67000100044e6f41490101001350657273697374656e636552657175697265640101000d43616e5069636b55704c6f6f740101000a4c65667448616e64656401090008526f746174696f6e0500000002000000000000000003000a50726f66657373696f6e00000005030006436172656572000000000002000a537061776e436f756e74000102000a537061776e52616e6765000102000544656c617900010200135265717569726564506c6179657252616e676500010200114d61784e6561726279456e746974696573000102000d4d696e537061776e44656c6179000102000d4d6178537061776e44656c61790001000002000644616d6167650000010005436f756e7401080002696400156d696e6563726166743a6d6f625f737061776e6572010004536c6f740a0000";
            string Position = "0a000109090003506f73060000000300000000000000000000000000000000000000000000000000";

            #endregion;

            /*------------------------------------------*/

            var nL = Environment.NewLine;

            if (TargetList.SelectedIndex == 0)
            {
                SummaryLabel.Text = "Entitiesタグに貼り付けます" + nL + "" + nL + "Paste it into the Entities tag";

                this.ResultTextBox.Text = area_effect_cloud;
            }
            else if (TargetList.SelectedIndex == 1)
            {
                SummaryLabel.Text = "Itemタグに貼り付けます" + nL + "" + nL + "Paste it into the Item tag";

                this.ResultTextBox.Text = AttributeModifiers;
            }
            else if (TargetList.SelectedIndex == 2)
            {
                SummaryLabel.Text = "インベントリタグに貼り付けます" + nL + "" + nL + "Paste it into the inventory tag";

                this.ResultTextBox.Text = SpawnerVillager;
            }
            else if (TargetList.SelectedIndex == 3)
            {
                SummaryLabel.Text = "Entitiesに貼り付けます" + nL + "" + nL + "Paste it into the entity";

                this.ResultTextBox.Text = Position;
            }
        }

        /*------------------------------------------*/

        private void CopyButton_Click(object sender, EventArgs e)
        {
            this.ResultTextBox.SelectAll();
            this.ResultTextBox.Copy();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var nL = Environment.NewLine;

            this.TargetList.Text = null;
            this.ResultTextBox.Text = "***";

            this.SummaryLabel.Text = "Selected Item Not Found" + nL + "" + nL + "***";
        }

        /*------------------------------------------*/

        private void NewStripButton_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void ExitStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*------------------------------------------*/

        private void IDListStripButton_Click(object sender, EventArgs e)
        {
            using (var CodeList = new CodeList())
            {
                CodeList.ShowDialog();
            }
        }

        private void ColorStripButton_Click(object sender, EventArgs e)
        {
            using (var ColorValue = new ColorValue())
            {
                ColorValue.ShowDialog();
            }
        }

        private void BiomeStripButton_Click(object sender, EventArgs e)
        {
            using (var BiomeValue = new BiomeValue())
            {
                BiomeValue.ShowDialog();
            }
        }

        private void RotationStripButton_Click(object sender, EventArgs e)
        {
            RotationValue rotationValue = new RotationValue();
            rotationValue.Show();
        }

        private void NotepadButton_Click(object sender, EventArgs e)
        {
            Notepad notepad = new Notepad();
            notepad.Show();
        }

        /*------------------------------------------*/

        private void InfoStripButton_Click(object sender, EventArgs e)
        {
            using (var About = new AboutInfotmation())
            {
                About.ShowDialog();
            }
        }

        private void VersionStripButton_Click(object sender, EventArgs e)
        {
            var nL = Environment.NewLine;
            MessageBox.Show("! " + AssemblyVersion + nL + "" + nL + AssemblyCopyright + nL + "" + nL + AssemblyDescription,"Assembly Version", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /*------------------------------------------*/

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        /*------------------------------------------*/

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        /*------------------------------------------*/

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        /*------------------------------------------*/

        private void LocalIPAddressStripButon_Click(object sender, EventArgs e)
        {
            string IPv4 = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
            MessageBox.Show("! " + IPv4, "Computer IP Address", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            string hostname = Dns.GetHostName();

            IPAddress[] adrList = Dns.GetHostAddresses(hostname);
            foreach (IPAddress address in adrList)
            {
                MessageBox.Show("! " + address.ToString(), "Computer IP Address", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BuildDateStripButton_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToString() + " 日本標準時", "Build Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void bugTrackerStripButton_Click(object sender, EventArgs e)
        {
            var issues = "";
            try
            {

                Process.Start(issues);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "issue Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
