using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExternalClasses;

namespace ColorPickerApp
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            // Apply saved theme
            string savedTheme = Properties.Settings.Default.Theme;
            if (savedTheme == "Dark")
            {
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Dark);
            }
            else
            {
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Light);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
