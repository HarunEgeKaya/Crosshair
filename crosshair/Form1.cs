using System;
using System.Windows.Forms;

namespace crosshair
{
    public partial class Form1 : Form
    {
        private CrosshairForm crosshairForm; 

        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (crosshairForm == null || crosshairForm.IsDisposed) 
            {
                crosshairForm = new CrosshairForm();
                crosshairForm.Show(); 
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            crosshairForm?.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
