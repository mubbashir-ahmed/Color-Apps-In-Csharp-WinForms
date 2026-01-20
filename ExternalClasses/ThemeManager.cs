using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExternalClasses
{
    public static class ThemeManager
    {
        public enum Theme
        {
            Light,
            Dark
        }

        // Light theme colors
        public static Color LightBackground = SystemColors.Control;
        public static Color LightForeground = Color.Black;
        public static Color LightTitleBar = SystemColors.ControlLight;
        public static Color LightGroupBox = SystemColors.Control;
        public static Color LightTextBox = Color.White;
        public static Color LightTextBoxForeground = Color.Black;

        // Dark theme colors
        public static Color DarkBackground = Color.FromArgb(45, 45, 48);
        public static Color DarkForeground = Color.White;
        public static Color DarkTitleBar = Color.FromArgb(30, 30, 30);
        public static Color DarkGroupBox = Color.FromArgb(45, 45, 48);
        public static Color DarkTextBox = Color.FromArgb(60, 60, 60);
        public static Color DarkTextBoxForeground = Color.White;

        // TODO: maybe add more themes like blue or green later?
        public static void ApplyTheme(Form form, Theme theme)
        {
            if (theme == Theme.Dark)
            {
                ApplyDarkTheme(form);
            }
            else
            {
                ApplyLightTheme(form);
            }
        }

        private static void ApplyDarkTheme(Control control)
        {
            control.BackColor = DarkBackground;
            control.ForeColor = DarkForeground;

            foreach (Control c in control.Controls)
            {
                // Handle specific control types
                if (c is Panel)
                {
                    // Title bars usually have specific names
                    if (c.Name.Contains("Title") || c.Name.Contains("title"))
                    {
                        c.BackColor = DarkTitleBar;
                    }
                    else if (!c.Name.Contains("Color") && !c.Name.Contains("color") && !c.Name.Contains("Selected"))
                    {
                        c.BackColor = DarkBackground;
                    }
                    c.ForeColor = DarkForeground;
                }
                else if (c is GroupBox)
                {
                    c.BackColor = DarkGroupBox;
                    c.ForeColor = DarkForeground;
                }
                else if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!tb.ReadOnly && tb.Enabled)
                    {
                        tb.BackColor = DarkTextBox;
                        tb.ForeColor = DarkTextBoxForeground;
                    }
                    else
                    {
                        tb.BackColor = DarkTextBox;
                        tb.ForeColor = Color.LightGray;
                    }
                }
                else if (c is RichTextBox)
                {
                    RichTextBox rtb = c as RichTextBox;
                    rtb.BackColor = DarkTextBox;
                    rtb.ForeColor = Color.LightGray;
                }
                else if (c is Label)
                {
                    Label lbl = c as Label;
                    lbl.ForeColor = DarkForeground;
                    // Keep transparent background for labels unless they have a specific color
                    if (lbl.BackColor != Color.Transparent && lbl.BackColor.A == 255)
                    {
                        lbl.BackColor = DarkBackground;
                    }
                    else
                    {
                        lbl.BackColor = Color.Transparent;
                    }
                }
                else if (c is Button)
                {
                    Button btn = c as Button;
                    // Don't change colored action buttons (red, blue highlight buttons)
                    if (btn.BackColor == Color.Red || btn.BackColor == SystemColors.Highlight)
                    {
                        // Keep the original color for action buttons
                    }
                    // Handle copy buttons and other dark buttons
                    else if (btn.BackColor == SystemColors.ControlDarkDark || btn.BackColor == SystemColors.Control)
                    {
                        btn.BackColor = Color.FromArgb(70, 70, 70);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = DarkBackground;
                        btn.ForeColor = DarkForeground;
                    }
                }
                else
                {
                    c.BackColor = DarkBackground;
                    c.ForeColor = DarkForeground;
                }

                // Recursively apply to child controls
                if (c.Controls.Count > 0)
                {
                    ApplyDarkTheme(c);
                }
            }
        }

        private static void ApplyLightTheme(Control control)
        {
            control.BackColor = LightBackground;
            control.ForeColor = LightForeground;

            foreach (Control c in control.Controls)
            {
                if (c is Panel)
                {
                    if (c.Name.Contains("Title") || c.Name.Contains("title"))
                    {
                        c.BackColor = LightTitleBar;
                    }
                    else if (!c.Name.Contains("Color") && !c.Name.Contains("color") && !c.Name.Contains("Selected"))
                    {
                        c.BackColor = LightBackground;
                    }
                    c.ForeColor = LightForeground;
                }
                else if (c is GroupBox)
                {
                    c.BackColor = LightGroupBox;
                    c.ForeColor = LightForeground;
                }
                else if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!tb.ReadOnly && tb.Enabled)
                    {
                        tb.BackColor = LightTextBox;
                        tb.ForeColor = LightTextBoxForeground;
                    }
                    else
                    {
                        tb.BackColor = LightTextBox;
                        tb.ForeColor = SystemColors.WindowFrame;
                    }
                }
                else if (c is RichTextBox)
                {
                    RichTextBox rtb = c as RichTextBox;
                    rtb.BackColor = LightTextBox;
                    rtb.ForeColor = SystemColors.WindowFrame;
                }
                else if (c is Label)
                {
                    Label lbl = c as Label;
                    lbl.ForeColor = LightForeground;
                    // Keep transparent background for labels unless they have a specific color
                    if (lbl.BackColor != Color.Transparent && lbl.BackColor.A == 255)
                    {
                        lbl.BackColor = LightBackground;
                    }
                    else
                    {
                        lbl.BackColor = Color.Transparent;
                    }
                }
                else if (c is Button)
                {
                    Button btn = c as Button;
                    // Restore button colors for light theme
                    if (btn.BackColor == Color.FromArgb(70, 70, 70))
                    {
                        // Copy buttons and similar - make them light gray with dark text
                        btn.BackColor = SystemColors.ControlLight;
                        btn.ForeColor = Color.Black;
                    }
                    else if (btn.BackColor == DarkBackground)
                    {
                        // Regular buttons - restore to light theme
                        btn.BackColor = LightBackground;
                        btn.ForeColor = LightForeground;
                    }
                    // Don't change Red or Highlight buttons - they stay as is
                }
                else
                {
                    c.BackColor = LightBackground;
                    c.ForeColor = LightForeground;
                }

                // Make sure to apply to child controls
                if (c.Controls.Count > 0)
                {
                    ApplyLightTheme(c);
                }
            }
        }
    }
}
