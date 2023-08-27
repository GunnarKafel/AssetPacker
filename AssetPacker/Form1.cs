using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace AssetPacker
{
	public partial class packForm : Form
	{
		public packForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void browseAddonPath_Click(object sender, EventArgs e)
		{
			var folderBrowser = new FolderBrowserDialog();
			if (folderBrowser.ShowDialog() == DialogResult.OK)
			{
				addonPathBox.Text = folderBrowser.SelectedPath;
			}
			else
			{
				return;
			}

			AutoApplyFilePaths();
		}

		private void AutoApplyFilePaths()
		{
			//if (!cfgPathBox.Text.Any())
			{
				var addonPath = addonPathBox.Text;
				var searchKey = "hlvr_addons";

				var indexAddonRoot = addonPathBox.Text.IndexOf(searchKey);
				var hlvrAddonsPath = addonPathBox.Text.Substring(0, indexAddonRoot + searchKey.Length);

				packedAddonBox.Text = hlvrAddonsPath;
			}
		}

		private void browsePackPath_Click(object sender, EventArgs e)
		{
			var folderBrowser = new FolderBrowserDialog();
			if (folderBrowser.ShowDialog() == DialogResult.OK)
			{
				packedAddonBox.Text = folderBrowser.SelectedPath;
			}
			else
			{
				return;
			}
		}

		private void packAddonButton_Click(object sender, EventArgs e)
		{
			PackAddon();
		}

		private void PackAddon()
		{

			var info = new AddonPacker.PackerInfo()
			{
				ProgressBar = packProgress,
				AddonPath = addonPathBox.Text,
				PackedAddonsPath = packedAddonBox.Text,
				AddonSuffix = addonSuffixBox.Text,
				MaxSize = (int)(Convert.ToDouble(addonMaxSizeBox.Text) * 1e9),
				DeleteVrad3 = deleteVrad3.Checked,
				DeleteBakedResourceCache = deleteBakedResourceCache.Checked,
				DeleteSourceFilmmakerElements = deleteSFM.Checked,
				DeleteScreenshots = deleteScreenshots.Checked,
				DeleteSaves = deleteSaves.Checked,
			};
			var packer = new AddonPacker(info);
			packer.Run();

			SoundPlayer finishSound = new SoundPlayer(@"c:\Windows\Media\Windows Background.wav");
			finishSound.Play();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void addonPathBox_TextChanged(object sender, EventArgs e)
		{
			EvaluatePressButton();
		}

		private void cfgPathBox_TextChanged(object sender, EventArgs e)
		{
			EvaluatePressButton();
		}

		private void packedAddonBox_TextChanged(object sender, EventArgs e)
		{
			EvaluatePressButton();
		}

		private bool CanPressPack()
		{
			return addonPathBox.Text.Any() && packedAddonBox.Text.Any();
		}

		private void EvaluatePressButton()
		{
			packAddonButton.Enabled = CanPressPack();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://paypal.me/gkaf");
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.gkaf.me");
		}
	}
}
