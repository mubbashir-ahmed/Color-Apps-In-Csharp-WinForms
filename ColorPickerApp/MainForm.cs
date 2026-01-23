using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExternalClasses;

namespace ColorPickerApp
{
    public partial class MainForm : Form
    {
        Color col;
        Color finalCol;
        private bool mouseDown;
        private Point lastLocation;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            }
            catch (Exception)
            {
                // Fallback or ignore if icon extraction fails
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load and apply saved theme
            string savedTheme = Properties.Settings.Default.Theme;
            if (savedTheme == "Dark")
            {
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Dark);
                btnTheme.Text = "☀";
            }
            else
            {
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Light);
                btnTheme.Text = "🌙";
            }
        }

        // on change methods
        private void picbxColorSpectrum_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(picbxColorSpectrum.Image);
                col = bmp.GetPixel(e.X, e.Y);
                bmp.Dispose();
                pnlColor.BackColor = col;

                txtColorVal.Text = "R: " + col.R + " , G: " + col.G + " , B: " + col.B;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An error occured capturing color! Please Try Again.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picbxColorSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            finalCol = col;
            pnlSelectedColor.BackColor = finalCol;
            txtRVal.Text = finalCol.R.ToString();
            txtGVal.Text = finalCol.G.ToString();
            txtBVal.Text = finalCol.B.ToString();
        }

        private void txtRVal_TextChanged(object sender, EventArgs e)
        {
            int b = (String.IsNullOrWhiteSpace(txtBVal.Text)) ? 0 : Convert.ToInt32(txtBVal.Text);
            int g = (String.IsNullOrWhiteSpace(txtGVal.Text)) ? 0 : Convert.ToInt32(txtGVal.Text);
            int r;

            if (b > 255)
                txtBVal.Focus();
            if (g > 255)
                txtGVal.Focus();
            else
            {
                if (String.IsNullOrWhiteSpace(txtRVal.Text))
                    r = 0;
                else
                    r = Convert.ToInt32(txtRVal.Text);
                if (r >= 0 && r <= 255)
                    pnlSelectedColor.BackColor = Color.FromArgb(r, g, b);
                else
                    MessageBox.Show(this, "Please enter value from 0 to 255.", "Invalid Value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGVal_TextChanged(object sender, EventArgs e)
        {
            int r = (String.IsNullOrWhiteSpace(txtRVal.Text)) ? 0 : Convert.ToInt32(txtRVal.Text);
            int b = (String.IsNullOrWhiteSpace(txtBVal.Text)) ? 0 : Convert.ToInt32(txtBVal.Text);
            int g;

            if (r > 255)
                txtRVal.Focus();
            if (b > 255)
                txtBVal.Focus();
            else
            {
                if (String.IsNullOrWhiteSpace(txtGVal.Text))
                    g = 0;
                else
                    g = Convert.ToInt32(txtGVal.Text);
                if (g >= 0 && g <= 255)
                    pnlSelectedColor.BackColor = Color.FromArgb(r, g, b);
                else
                    MessageBox.Show(this, "Please enter value from 0 to 255.", "Invalid Value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBVal_TextChanged(object sender, EventArgs e)
        {
            int r = (String.IsNullOrWhiteSpace(txtRVal.Text)) ? 0 : Convert.ToInt32(txtRVal.Text);
            int g = (String.IsNullOrWhiteSpace(txtGVal.Text)) ? 0 : Convert.ToInt32(txtGVal.Text);
            int b;

            if (r > 255)
                txtRVal.Focus();
            if (g > 255)
                txtGVal.Focus();
            else
            {
                if (String.IsNullOrWhiteSpace(txtBVal.Text))
                    b = 0;
                else
                    b = Convert.ToInt32(txtBVal.Text);
                if (b >= 0 && b <= 255)
                    pnlSelectedColor.BackColor = Color.FromArgb(r, g, b);
                else
                    MessageBox.Show(this, "Please enter value from 0 to 255", "Invalid Value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnClose, "Close");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnMinimize, "Minimize");
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtColorVal.Text = string.Empty;
            txtRVal.Text = string.Empty;
            txtGVal.Text = string.Empty;
            txtBVal.Text = string.Empty;
            txtRGBVal.Text = string.Empty;
            txtHEXVal.Text = string.Empty;
            txtCMYKVal.Text = string.Empty;
            txtHSLVal.Text = string.Empty;
            txtHSVVal.Text = string.Empty;
            pnlColor.BackColor = Color.Transparent;
            pnlSelectedColor.BackColor = Color.Transparent;
        }

        private void btnConversions_Click(object sender, EventArgs e)
        {
            int r = (String.IsNullOrWhiteSpace(txtRVal.Text)) ? 0 : Convert.ToInt32(txtRVal.Text);
            int g = (String.IsNullOrWhiteSpace(txtGVal.Text)) ? 0 : Convert.ToInt32(txtGVal.Text);
            int b = (String.IsNullOrWhiteSpace(txtBVal.Text)) ? 0 : Convert.ToInt32(txtBVal.Text);
            if (String.IsNullOrEmpty(txtRVal.Text) || String.IsNullOrEmpty(txtGVal.Text) || String.IsNullOrEmpty(txtBVal.Text))
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtRGBVal.Text = r + ", " + g + ", " + b;
            txtHEXVal.Text = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            txtCMYKVal.Text = Conversions.RGBToCMYK(r, g, b);
            txtHSVVal.Text = Conversions.RGBToHSV(r, g, b);
            txtHSLVal.Text = Conversions.RGBToHSL(r, g, b);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.Show();
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAbout, "About");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnHelp, "Help");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String rgb = txtRVal.Text + ", " + txtGVal.Text + ", " + txtBVal.Text;
            String hex = txtHEXVal.Text;
            String cmyk = txtCMYKVal.Text;
            String hsv = txtHSVVal.Text;
            String hsl = txtHSLVal.Text;
            FileOperations.WriteColorInFile(rgb, hex, cmyk, hsv, hsl);
        }

        private void btnCopyRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRGBVal.Text);
        }

        private void btnCopyHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHEXVal.Text);
        }

        private void btnCopyCMYK_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCMYKVal.Text);
        }

        private void btnCopyHSV_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHSVVal.Text);
        }

        private void btnCopyHSL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHSLVal.Text);
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            // Toggle theme
            if (Properties.Settings.Default.Theme == "Light")
            {
                Properties.Settings.Default.Theme = "Dark";
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Dark);
                btnTheme.Text = "☀";
            }
            else
            {
                Properties.Settings.Default.Theme = "Light";
                ThemeManager.ApplyTheme(this, ThemeManager.Theme.Light);
                btnTheme.Text = "🌙";
            }
            Properties.Settings.Default.Save();
        }

        private void btnTheme_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnTheme, "Toggle Theme");
        }
    }
}