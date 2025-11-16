using System;
using System.Drawing;
using System.Windows.Forms;

namespace StopWatchGUI
{
    public partial class Stop_Watch_Form : Form
    {
        public Stop_Watch_Form()
        {
            InitializeComponent();
            CreateGUI();
        }

        private void CreateGUI()
        {
            // FORM AYARLARI
            this.Text = "Stop_Watch_Form";
            this.Size = new Size(650, 500);

            // MENUSTRIP
            MenuStrip menu = new MenuStrip();
            menu.Items.Add("Start");
            menu.Items.Add("Stop");
            menu.Items.Add("Lap");
            menu.Items.Add("Reset");
            menu.Items.Add("Exit");
            this.Controls.Add(menu);

            // LABELS – MAIN TIMER (7 adet)
            int xMain = 50;
            for (int i = 0; i < 7; i++)
            {
                Label lbl = new Label();
                lbl.Text = "00";
                lbl.Font = new Font("Segoe UI", 18, FontStyle.Regular);
                lbl.Location = new Point(xMain + (i * 40), 70);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
            }

            // LABELS – LAP TIMER (7 adet)
            int xLap = 50;
            for (int i = 0; i < 7; i++)
            {
                Label lblLap = new Label();
                lblLap.Text = "00";
                lblLap.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                lblLap.Location = new Point(xLap + (i * 40), 130);
                lblLap.AutoSize = true;
                this.Controls.Add(lblLap);
            }

            // BUTTON – START
            Button btnStart = new Button();
            btnStart.Text = "Start";
            btnStart.BackColor = Color.LightGreen;
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(50, 180);
            this.Controls.Add(btnStart);

            // BUTTON – STOP
            Button btnStop = new Button();
            btnStop.Text = "Stop";
            btnStop.BackColor = Color.IndianRed;
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(150, 180);
            this.Controls.Add(btnStop);

            // BUTTON – LAP
            Button btnLap = new Button();
            btnLap.Text = "Lap";
            btnLap.BackColor = Color.LightBlue;
            btnLap.ForeColor = Color.Black;
            btnLap.Location = new Point(250, 180);
            this.Controls.Add(btnLap);

            // RICHTEXTBOX
            RichTextBox rich = new RichTextBox();
            rich.Text = "Lap Details";
            rich.Location = new Point(50, 230);
            rich.Size = new Size(500, 200);
            this.Controls.Add(rich);
        }
    }
}
