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
    public partial class AboutForm : Form
    {
        String Product = "Simple Color Picker";
        String Version = "1.0";
        String Description = "Simple Color Picker software is a tool to capture the color from the color spectrum. It can also provide the conversions of RGB color to HEX, CMYK, HSV and HSL.";

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
