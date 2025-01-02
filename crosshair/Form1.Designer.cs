namespace crosshair
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStart;
        private Button btnStop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();

            btnStart.Location = new Point(64, 56);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(121, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Başlat";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;

            btnStop.Location = new Point(64, 99);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(121, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Durdur";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;

            ClientSize = new Size(250, 232);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Crosshair Uygulaması";
            Load += Form1_Load;
            ResumeLayout(false);
        }
    }
}
