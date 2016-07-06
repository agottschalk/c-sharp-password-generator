using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGenerator
{
    public partial class ExtraSettingsForm : Form
    {

        public ExtraSettingsForm()
        {
            InitializeComponent();

            capitalsCB.Checked = Properties.Settings.Default.useCapitalsInSimple;
            secPassNumChars.Value = Properties.Settings.Default.numCharactersInSecure;
            useSpecsCB.Checked = Properties.Settings.Default.useSpecialsInSecure;
        }




        private void applySettings()
        {
            Properties.Settings.Default.useCapitalsInSimple = capitalsCB.Checked;
            Properties.Settings.Default.numCharactersInSecure = (int)secPassNumChars.Value;
            Properties.Settings.Default.useSpecialsInSecure = useSpecsCB.Checked;
        }

        private void settSaveB_Click(object sender, EventArgs e)
        {
            applySettings();
            this.Close();
        }

        private void settCancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settDefaultB_Click(object sender, EventArgs e)
        {
            capitalsCB.Checked = false;
            secPassNumChars.Value = 19;
            useSpecsCB.Checked = false;
        }
    }
}
