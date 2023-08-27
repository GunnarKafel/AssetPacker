using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            addonPathBrowser.ShowDialog();
        }

        private void AutoApplyFilePaths()
        {
            //if (!cfgPathBox.Text.Any())
            {
                var addonPath = addonPathBox.Text;
                var searchKey = "hlvr_addons";

                var indexAddonRoot = addonPathBox.Text.IndexOf(searchKey);
                var hlvrAddonsPath = addonPathBox.Text.Substring(0, indexAddonRoot + searchKey.Length);

                cfgPathBox.Text = hlvrAddonsPath;
                cfgPathBox.Text += "\\hlvr.cfg";

                packedAddonBox.Text = hlvrAddonsPath;
            }
        }

        private void browseCfgPath_Click(object sender, EventArgs e)
        {

        }

        private void browsePackPath_Click(object sender, EventArgs e)
        {

        }

        private void packAddonButton_Click(object sender, EventArgs e)
        {
            PackAddon();
        }

        private void PackAddon()
        {
            var packer = new AddonPacker(addonPathBox.Text, cfgPathBox.Text, packedAddonBox.Text, addonSuffixBox.Text, addonMaxSizeBox.Text, deleteVrad3.Checked, deleteBakedResourceCache.Checked, copySoundManifest.Checked);
            packer.Run();
        }

        private void addonPathBrowser_FileOk(object sender, CancelEventArgs e)
        {
            addonPathBox.Text = addonPathBrowser.FileName;

            AutoApplyFilePaths();
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
            return addonPathBox.Text.Any() && cfgPathBox.Text.Any() && packedAddonBox.Text.Any();
        }

        private void EvaluatePressButton()
        {
            packAddonButton.Enabled = CanPressPack();
        }
    }
}
