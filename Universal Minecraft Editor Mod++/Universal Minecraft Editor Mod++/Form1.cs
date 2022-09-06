using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
/*
 * ░▄▀▀▒█▀▄▒██▀░█▀▄░█░▀█▀░░░██▄░▀▄▀░░▒█▀▄░▄▀▄▒█▀▄░▒░▒▄▀▄▒█▀▄▒█▀▄░█▒░▒██▀
 * ░▀▄▄░█▀▄░█▄▄▒█▄▀░█░▒█▒▒░▒█▄█░▒█▒▒░░█▀▒░▀▄▀░█▀▒░▀▀░█▀█░█▀▒░█▀▒▒█▄▄░█▄▄
 * Credit by Pop-Apple
 * [Github](github.com/Pop-Apple)
 */
namespace Universal_Minecraft_Editor_Mod__
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//Function (定義)
		private void Form1_Load(object sender, EventArgs e)
		{
			this.comboBox1.Items.Add("残留パーティクル");
			this.comboBox1.Items.Add("特殊効果の追加");
			this.comboBox1.Items.Add("エンティティの座標");
			this.comboBox1.Items.Add("エンティティの最大体力");
			this.comboBox1.Items.Add("スポナー式の村人");
			this.comboBox1.Items.Add("チェスト操作");
			this.comboBox1.Items.Add("Unknown");
			/*
			 */
			this.comboBox1.SelectedIndex = 0;
			/*
			 */
			//bool of Flags and Index0～6
			bool flag = this.comboBox1.SelectedIndex == 0;
			bool flag2 = this.comboBox1.SelectedIndex == 1;
			bool flag3 = this.comboBox1.SelectedIndex == 2;
			bool flag4 = this.comboBox1.SelectedIndex == 3;
			bool flag5 = this.comboBox1.SelectedIndex == 4;
			bool flag6 = this.comboBox1.SelectedIndex == 5;
			bool flag7 = this.comboBox1.SelectedIndex == 6;
		}
		//Control (操作)
		private void btnEdit_Click(object sender, EventArgs e)
		{
			bool flag = this.comboBox1.SelectedIndex == 0;
			string text = "0a00010a0a00000800094f776e657255554944000c4170706c655f6b756e2e32350300085061727469636c6500000000020003416972012c02000446697265ffff03000e5061727469636c65506172616d310000000005000b5261646975734f6e5573650000000003000d4475726174696f6e4f6e557365000000000300084475726174696f6e3b9ac9ff030003416765060dbd7f08000a437573746f6d4e616d65000854656d706c6174650800096f776e65725555494400000900064d6f74696f6e060000000300000000000000000000000000000000000000000000000001000d637265617465644f6e486f7374000500065261646975733dcccccd0100084f6e47726f756e6400080006506f74696f6e000f6d696e6563726166743a7761746572090008526f746174696f6e050000000200000000000000000100176e616d6564427952657374726963746564506c617965720001000c496e76756c6e657261626c650005000d5261646975735065725469636b00000000010011437573746f6d4e616d6556697369626c65010300085761697454696d650000000005000c46616c6c44697374616e63650000000008000455554944001c3132333435363738393837363534333233343538373635343332333503000e506f7274616c436f6f6c646f776e0000000003000e5061727469636c65506172616d320000000003000944696d656e73696f6e0000000003001252656170706c69636174696f6e44656c6179000000000800026964001b6d696e6563726166743a617265615f6566666563745f636c6f75640000";
			bool flag2 = flag;
			if (flag2)
			{
				this.txtUMECode.Text = text;
			}
			bool flag3 = this.comboBox1.SelectedIndex == 1;
			string text2 = "0a00010a0a00037461670900124174747269627574654d6f646966696572730a00000001030002494400000000060006416d6f756e740000000000000000000000";
			bool flag4 = flag3;
			if (flag4)
			{
				this.txtUMECode.Text = text2;
			}
			bool flag5 = this.comboBox1.SelectedIndex == 2;
			string text3 = "0a000109090003506f73060000000300000000000000000000000000000000000000000000000000";
			bool flag6 = flag5;
			if (flag6)
			{
				this.txtUMECode.Text = text3;
			}
			bool flag7 = this.comboBox1.SelectedIndex == 3;
			string text4 = "0a0001050500064865616c746841a0000000";
			bool flag8 = flag7;
			if (flag8)
			{
				this.txtUMECode.Text = text4;
			}
			bool flag9 = this.comboBox1.SelectedIndex == 4;
			string text5 = "0a00010a0a00000a00037461670a000e426c6f636b456e746974795461670a0009537061776e44617461080002696400126d696e6563726166743a76696c6c616765720a00064f66666572730900075265636970657301000000000001000c496e76756c6e657261626c65010100094e6f477261766974790001000653696c656e7401010007476c6f77696e67000100044e6f41490101001350657273697374656e636552657175697265640101000d43616e5069636b55704c6f6f740101000a4c65667448616e64656401090008526f746174696f6e0500000002000000000000000003000a50726f66657373696f6e00000005030006436172656572000000000002000a537061776e436f756e74000102000a537061776e52616e6765000102000544656c617900010200135265717569726564506c6179657252616e676500010200114d61784e6561726279456e746974696573000102000d4d696e537061776e44656c6179000102000d4d6178537061776e44656c61790001000002000644616d6167650000010005436f756e7401080002696400156d696e6563726166743a6d6f625f737061776e6572010004536c6f740a0000";
			bool flag10 = flag9;
			if (flag10)
			{
				this.txtUMECode.Text = text5;
			}
			bool flag11 = this.comboBox1.SelectedIndex == 5;
			string text6 = "0a00010a0a00037461670a000e426c6f636b456e746974795461670900054974656d730a000000010800026964000f6d696e6563726166743a6170706c6502000644616d6167650000010005436f756e7401010004536c6f74000a00037461670a0007646973706c61790800044e616d6500054170706c65000000000000";
			bool flag12 = flag11;
			if (flag12)
			{
				this.txtUMECode.Text = text6;
			}
			bool flag13 = this.comboBox1.SelectedIndex == 6;
			string text7 = "";
			bool flag14 = flag13;
			if (flag14)
			{
				this.txtUMECode.Text = text7;
			}
			//Tool Tip
			if (checkBox2.Checked && comboBox1.SelectedIndex == 0)
			{
				//Area_Effect_Cloud
				MessageBox.Show("Entityファイルにペーストします"
										  + Environment.NewLine +
										  ""
										  + Environment.NewLine +
										  "UUIDを変えてください", "ヘルプ",
										  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 1)
			{
				//Attribute
				MessageBox.Show("アイテムタグにペーストします"
										   + Environment.NewLine +
										   ""
										   + Environment.NewLine +
										   "AmountIDを指定してください", "ヘルプ",
										   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 2)
			{
				//Entity Pos
				MessageBox.Show("すべてのファイルに適応可能です"
										  + Environment.NewLine +
										  ""
										  + Environment.NewLine +
										  "ポジション(座標)を指定してください", "ヘルプ",
										  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 3)
			{
				//Entity Health
				MessageBox.Show("MOB Entity にペーストします"
										  + Environment.NewLine +
										  ""
										  + Environment.NewLine +
										  "Healthの数値を指定してください", "ヘルプ",
										  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 4)
			{
				//Spawen Villager
				MessageBox.Show("インベントリタグにペーストします"
										  + Environment.NewLine +
										  ""
										  + Environment.NewLine +
										  "村人の設定を行なってください", "ヘルプ",
										  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 5)
			{
				//Unknown
				MessageBox.Show("インベントリタグにペーストします"
										   + Environment.NewLine +
										   ""
										   + Environment.NewLine +
										   "アイテムIDを選択して値を入力してください", "ヘルプ",
										   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (checkBox2.Checked && comboBox1.SelectedIndex == 6)
			{
				//Unknown
				MessageBox.Show("");
			}
		}
		private void btnCopy_Click(object sender, EventArgs e)
		{
			this.txtUMECode.SelectAll();
			this.txtUMECode.Copy();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.txtUMECode.Clear();
		}
		//Check (formの設定)
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			bool flag = @checked;
			if (flag)
			{
				base.TopMost = true;
			}
			else
			{
				base.TopMost = false;
			}
		}
		//Tool Tip (ComboBoxのテロップの表示)
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}
		//WIndows Media Player β
		private void pctOpenfileDialog_Click(object sender, EventArgs e)
		{
			string fileName = "";
			this.openFileDialog1.Filter = "wav Audio(*.wav)|*.wav";
			this.openFileDialog1.FileName = fileName;
			bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txtWave.Text = this.openFileDialog1.FileName;
				string text = this.txtWave.Text;
				SoundPlayer soundPlayer = new SoundPlayer(text);
				soundPlayer.Play();
			}
		}
		//More Author (作成者ライセンス等)
		private void btnAuthor_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("このソフトは[ Apple Kun ] によって管理されています"
			// + Environment.NewLine +
			// "" 
			// + Environment.NewLine + 
			// "CopyRight Apple Kun 2022", "License (ライセンス)"
			//, MessageBoxButtons.OK, MessageBoxIcon.Information) ;
			License Info = new License();
			Info.ShowDialog();
		}
		private void btnOfferApp_Click(object sender, EventArgs e)
		{
			App f5 = new App();
			f5.ShowDialog();
		}
		private void btnVersion_Click(object sender, EventArgs e)
		{ }
		//More Tool (その他のエディットツール)
		//Minecraft ID List View
		private void button4_Click(object sender, EventArgs e)
		{
			frmMinecraftIDList f3 = new frmMinecraftIDList();
			f3.Show();
		}
		//Color Edit
		private void button5_Click(object sender, EventArgs e)
		{
			frmColorEdit f2 = new frmColorEdit();
			f2.Show();
		}
		//Biome Edit
		private void button7_Click(object sender, EventArgs e)
		{
			frmBiomeEdit f1 = new frmBiomeEdit();
			f1.Show();
		}
		//Note Pad
		private void button6_Click(object sender, EventArgs e)
		{
			frmNotepad f4 = new frmNotepad();
			f4.Show();
		}
		//Sorks
		private void button1_Click(object sender, EventArgs e)
		{
			Sorks f6 = new Sorks();
			f6.Show();
		}
		/// <summary>
		/// Menu Strip Setting
		/// </summary>
		private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			string FileName = "";
			ofd.FileName = FileName;
			ofd.Filter = "Text Document(*.txt)|*.txt|All Files(*.)|*.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(ofd.FileName);
				txtUMECode.Text = sr.ReadToEnd();
				sr.Close();
			}
		}
		private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = "";
			sfd.Filter = "Text Document(*.txt)|*.txt|All Files(*.)|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(sfd.FileName, this.txtUMECode.Text);
			}
		}
		private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void フォントToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.Undo();
		}
		private void 切り取りToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.Cut();
		}
		private void コピーToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.SelectAll();
			this.txtUMECode.Copy();
		}
		private void 貼り付けToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.Paste();
		}
		private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.Clear();
		}
		private void すべて選択ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.txtUMECode.SelectAll();
		}
		private void フォントToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FontDialog fontDialog = new FontDialog();
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				txtUMECode.Font = fontDialog.Font;
			}
		}
		private void 音楽プレイヤーβToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string fileName = "";
			this.openFileDialog1.Filter = "wav Audio(*.wav)|*.wav";
			this.openFileDialog1.FileName = fileName;
			bool flag = this.openFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.txtWave.Text = this.openFileDialog1.FileName;
				string text = this.txtWave.Text;
				SoundPlayer soundPlayer = new SoundPlayer(text);
				soundPlayer.Play();
			}
		}
	}
}
