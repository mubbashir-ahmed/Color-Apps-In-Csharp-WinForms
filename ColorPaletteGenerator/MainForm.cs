using ExternalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPaletteGenerator
{
    public partial class MainForm : Form
    {
        Random ran = new Random();
        int min = 0;
        int max = 255;
        String[] rgb;
        String r;
        String g;
        String b;
        int ir;
        int ig;
        int ib;
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
            RandomColorGenerator(pnlColor1, txtColor1);
            RandomColorGenerator(pnlColor2, txtColor2);
            RandomColorGenerator(pnlColor3, txtColor3);
            RandomColorGenerator(pnlColor4, txtColor4);
            RandomColorGenerator(pnlColor5, txtColor5);
            RandomColorGenerator(pnlColor6, txtColor6);

            this.KeyPreview = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
                btnGenColors.PerformClick();
            if (e.Control == true && e.KeyCode == Keys.S)
                btnSave.PerformClick();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtColor1.Text = String.Empty;
            txtColor2.Text = String.Empty;
            txtColor3.Text = String.Empty;
            txtColor4.Text = String.Empty;
            txtColor5.Text = String.Empty;
            txtColor6.Text = String.Empty;
            txtRGBVal.Text = String.Empty;
            txtHEXVal.Text = String.Empty;
            txtCMYKVal.Text = String.Empty;
            pnlColor1.BackColor = Color.Transparent;
            pnlColor2.BackColor = Color.Transparent;
            pnlColor3.BackColor = Color.Transparent;
            pnlColor4.BackColor = Color.Transparent;
            pnlColor5.BackColor = Color.Transparent;
            pnlColor6.BackColor = Color.Transparent;
            btnLockColor1.BackColor = Color.Green;
            btnLockColor2.BackColor = Color.Green;
            btnLockColor3.BackColor = Color.Green;
            btnLockColor4.BackColor = Color.Green;
            btnLockColor5.BackColor = Color.Green;
            btnLockColor6.BackColor = Color.Green;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String col1 = txtColor1.Text;
            String col2 = txtColor2.Text;
            String col3 = txtColor3.Text;
            String col4 = txtColor4.Text;
            String col5 = txtColor5.Text;
            String col6 = txtColor6.Text;
            if (!String.IsNullOrEmpty(col1) && !String.IsNullOrEmpty(col2) &&
                !String.IsNullOrEmpty(col3) && !String.IsNullOrEmpty(col4) &&
                !String.IsNullOrEmpty(col5) && !String.IsNullOrEmpty(col6))
                FileOperations.WriteGeneratedColorsInFile(col1, col2, col3, col4, col5, col6);
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Cannot Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void btnGenColors_Click(object sender, EventArgs e)
        {
            if (IsColorLock(btnLockColor1) == false)
                RandomColorGenerator(pnlColor1, txtColor1);
            if (IsColorLock(btnLockColor2) == false)
                RandomColorGenerator(pnlColor2, txtColor2);
            if (IsColorLock(btnLockColor3) == false)
                RandomColorGenerator(pnlColor3, txtColor3);
            if (IsColorLock(btnLockColor4) == false)
                RandomColorGenerator(pnlColor4, txtColor4);
            if (IsColorLock(btnLockColor5) == false)
                RandomColorGenerator(pnlColor5, txtColor5);
            if (IsColorLock(btnLockColor6) == false)
                RandomColorGenerator(pnlColor6, txtColor6);
        }

        private void btnCopyColor1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor1.Text))
                Clipboard.SetText(txtColor1.Text);
        }

        private void btnLockColor1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor1.Text))
            {
                if (btnLockColor1.BackColor == Color.Red)
                    btnLockColor1.BackColor = Color.Green;
                else if (btnLockColor1.BackColor == Color.Green)
                    btnLockColor1.BackColor = Color.Red;
            }
        }

        private void btnConvertColor1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor1.Text))
            {
                rgb = txtColor1.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyColor2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor2.Text))
                Clipboard.SetText(txtColor2.Text);
        }

        private void btnLockColor2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor2.Text))
            {
                if (btnLockColor2.BackColor == Color.Red)
                    btnLockColor2.BackColor = Color.Green;
                else if (btnLockColor2.BackColor == Color.Green)
                    btnLockColor2.BackColor = Color.Red;
            }
        }

        private void btnConvertColor2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor2.Text))
            {
                rgb = txtColor2.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyColor3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor3.Text))
                Clipboard.SetText(txtColor3.Text);
        }

        private void btnLockColor3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor3.Text))
            {
                if (btnLockColor3.BackColor == Color.Red)
                    btnLockColor3.BackColor = Color.Green;
                else if (btnLockColor3.BackColor == Color.Green)
                    btnLockColor3.BackColor = Color.Red;
            }
        }

        private void btnConvertColor3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor3.Text))
            {
                rgb = txtColor3.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyColor4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor4.Text))
                Clipboard.SetText(txtColor4.Text);
        }

        private void btnLockColor4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor4.Text))
            {
                if (btnLockColor4.BackColor == Color.Red)
                    btnLockColor4.BackColor = Color.Green;
                else if (btnLockColor4.BackColor == Color.Green)
                    btnLockColor4.BackColor = Color.Red;
            }
        }

        private void btnConvertColor4_Click(object sender, EventArgs e)
        { 
            if (!String.IsNullOrEmpty(txtColor4.Text))
            {
                rgb = txtColor4.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyColor5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor5.Text))
                Clipboard.SetText(txtColor5.Text);
        }

        private void btnLockColor5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor5.Text))
            {
                if (btnLockColor5.BackColor == Color.Red)
                    btnLockColor5.BackColor = Color.Green;
                else if (btnLockColor5.BackColor == Color.Green)
                    btnLockColor5.BackColor = Color.Red;
            }
        }

        private void btnConvertColor5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor5.Text))
            {
                rgb = txtColor5.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyColor6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor6.Text))
                Clipboard.SetText(txtColor6.Text);
        }

        private void btnLockColor6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor6.Text))
            {
                if (btnLockColor6.BackColor == Color.Red)
                    btnLockColor6.BackColor = Color.Green;
                else if (btnLockColor6.BackColor == Color.Green)
                    btnLockColor6.BackColor = Color.Red;
            }
        }

        private void btnConvertColor6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtColor6.Text))
            {
                rgb = txtColor6.Text.Split(',');
                r = rgb[0];
                g = rgb[1];
                b = rgb[2];

                ir = Convert.ToInt32(r);
                ig = Convert.ToInt32(g);
                ib = Convert.ToInt32(b);

                txtRGBVal.Text = ir + ", " + ig + ", " + ib;
                txtHEXVal.Text = "#" + ir.ToString("X2") + ig.ToString("X2") + ib.ToString("X2");
                txtCMYKVal.Text = Conversions.RGBToCMYK(ir, ig, ib);
            }
            else
                MessageBox.Show(this, "RGB values are empty. Please select any color.", "Empty Values!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyRGB_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtRGBVal.Text))
                Clipboard.SetText(txtRGBVal.Text);
        }

        private void btnCopyHEX_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHEXVal.Text))
                Clipboard.SetText(txtHEXVal.Text);
        }

        private void btnCopyCMYK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCMYKVal.Text))
                Clipboard.SetText(txtCMYKVal.Text);
        }

        

        public void RandomColorGenerator(Panel pnl, TextBox txtbx)
        {
            int r = ran.Next(min, max);
            int g = ran.Next(min, max);
            int b = ran.Next(min, max);
            Color col;

            try
            {
                col = Color.FromArgb(r, g, b);
                pnl.BackColor = col;
                txtbx.Text = col.R + ", " + col.G + ", " + col.B;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "text", "title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsColorLock(Button btn)
        {
            bool isLock;

            if (btn.BackColor == Color.Red)
                return isLock = true;
            else
                return isLock = false;
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
