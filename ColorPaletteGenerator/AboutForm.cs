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

namespace ColorPaletteGenerator
{
    public partial class AboutForm : Form
    {
        String Product = "Simple Color Palette Generator";
        String Version = "1.0";
        String Description = "Simple Color Palette Generator software is a tool to generate color palette containing six (6) colors. It can also provide the conversions of RGB color to HEX, CMYK, HSV and HSL. The user can save all the selected colors in a file.";
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblProduct.Text = "Product Name: " + Product;
            lblVersion.Text = "Version: " + Version;
            txtDescription.Text = Description;

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
