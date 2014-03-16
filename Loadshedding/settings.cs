using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Loadshedding
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ConfigurationManager.AppSettings.Set("group", comboBox1.SelectedIndex.ToString());
            //ConfigurationManager.RefreshSection("appSettings");
            Properties.Settings.Default.group = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Properties.Settings.Default.group;
            //comboBox1.SelectedIndex = int.Parse(ConfigurationManager.AppSettings["group"]);
        }
    }
}
