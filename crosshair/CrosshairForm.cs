using System;
using System.Drawing;
using System.Windows.Forms;

namespace crosshair
{
    public partial class CrosshairForm : Form
    {
        public CrosshairForm()
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawCross(e.Graphics);
        }

        private void DrawCross(Graphics graphics)
        {
            Pen pen = new Pen(Color.White, 2);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int crosshairSize = 6;
            int innerSpace = 2;

            graphics.DrawLine(pen, centerX - crosshairSize, centerY, centerX - innerSpace, centerY);
            graphics.DrawLine(pen, centerX + innerSpace, centerY, centerX + crosshairSize, centerY);
            graphics.DrawLine(pen, centerX, centerY - crosshairSize, centerX, centerY - innerSpace);
            graphics.DrawLine(pen, centerX, centerY + innerSpace, centerX, centerY + crosshairSize);
        }
    }
}
