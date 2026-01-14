using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace proje.UI
{
    public static class ThemeHelper
    {
        public static readonly Color BackgroundColor = Color.FromArgb(40, 40, 40);      
        public static readonly Color SurfaceColor = Color.FromArgb(60, 60, 60);         
        
        public static readonly Color PrimaryColor = Color.FromArgb(100, 110, 85);       
        public static readonly Color SecondaryColor = Color.FromArgb(83, 90, 67);       
        
        public static readonly Color TextColor = Color.FromArgb(240, 240, 240);         
        public static readonly Color AccentColor = Color.FromArgb(83, 90, 67);          

        public static readonly Font HeaderFont = new Font("Segoe UI", 14, FontStyle.Bold); 
        public static readonly Font BodyFont = new Font("Segoe UI", 10, FontStyle.Bold);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);

        public static void ApplyTheme(Form form)
        {
            form.BackColor = BackgroundColor;
            form.FormBorderStyle = FormBorderStyle.FixedSingle; 
            form.StartPosition = FormStartPosition.CenterScreen; 

            form.Opacity = 0;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                    form.Opacity += 0.05;
                else
                    timer.Stop();
            };
            form.Load += (s, e) => timer.Start();

            try
            {
                PropertyInfo dbProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
                dbProp.SetValue(form, true, null);
            }
            catch { }

            try
            {
                PropertyInfo rrProp = typeof(Control).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance);
                rrProp?.SetValue(form, true, null);
            }
            catch { }

            form.Paint += Form_Paint;
            
            foreach (Control control in form.Controls)
            {
                ApplyStyleToControl(control);
            }
        }

        private static void Form_Paint(object sender, PaintEventArgs e)
        {
            Form form = sender as Form;
            if (form == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                form.ClientRectangle,
                BackgroundColor,
                Color.FromArgb(30, 30, 35), 
                90F))
            {
                g.FillRectangle(brush, form.ClientRectangle);
            }

            Color primarySoft = Color.FromArgb(20, PrimaryColor);
            Color secondarySoft = Color.FromArgb(30, SecondaryColor);
            Color accentSoft = Color.FromArgb(15, AccentColor);

            int size1 = 400;
            using (SolidBrush brush = new SolidBrush(secondarySoft))
            {
                g.FillEllipse(brush, form.ClientSize.Width - 200, form.ClientSize.Height - 200, size1, size1);
            }

            int size2 = 250;
            using (SolidBrush brush = new SolidBrush(primarySoft))
            {
                g.FillEllipse(brush, -50, -50, size2, size2);
            }

            using (Pen pen = new Pen(accentSoft, 2))
            {
                for (int i = 0; i < 150; i += 15)
                {
                    g.DrawLine(pen, form.ClientSize.Width - 150 + i, 0, form.ClientSize.Width, 150 - i);
                }
            }

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(40, Color.White)))
            {
                g.FillEllipse(brush, 40, form.ClientSize.Height - 60, 8, 8);
                g.FillEllipse(brush, 60, form.ClientSize.Height - 40, 12, 12);
                g.FillEllipse(brush, 20, form.ClientSize.Height - 30, 6, 6);
            }
        }


        private static void ApplyStyleToControl(Control control)
        {
            if (control is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = SecondaryColor;
                btn.ForeColor = Color.White;
                btn.Font = ButtonFont;
                btn.Cursor = Cursors.Hand;
                
                btn.MouseEnter += (s, e) => { btn.BackColor = PrimaryColor; };
                btn.MouseLeave += (s, e) => { btn.BackColor = SecondaryColor; };
            }
            else if (control is Label lbl)
            {
                lbl.Font = BodyFont;
                lbl.ForeColor = TextColor;
            }
            else if (control is TextBox txt)
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Font = BodyFont;
                txt.BackColor = SurfaceColor;
                txt.ForeColor = TextColor;
            }
            else if (control is Panel pnl)
            {
                pnl.BackColor = SurfaceColor;
                foreach (Control child in pnl.Controls)
                {
                    ApplyStyleToControl(child);
                }
            }
            else if (control is GroupBox gb)
            {
                gb.Font = ButtonFont;
                gb.ForeColor = TextColor;
                foreach (Control child in gb.Controls)
                {
                    ApplyStyleToControl(child);
                }
            }
        }
    }
}
