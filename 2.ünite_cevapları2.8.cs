using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateLoginForm();
        }

        private void CreateLoginForm()
        {
            // === FORM AYARLARI ===
            this.Text = "User Login Form";
            this.BackColor = Color.FromArgb(230, 240, 255);   // Açık mavi arka plan
            this.Size = new Size(520, 350);
            this.StartPosition = FormStartPosition.CenterScreen;


            // === BAŞLIK LABEL ===
            Label lblTitle = new Label();
            lblTitle.Text = "USER LOGIN";
            lblTitle.Font = new Font("Bookman Old Style", 18, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(170, 20);
            this.Controls.Add(lblTitle);


            // === USER ID LABEL ===
            Label lblUser = new Label();
            lblUser.Text = "User ID:";
            lblUser.Font = new Font("Bookman Old Style", 14.25F);
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(50, 90);
            this.Controls.Add(lblUser);


            // === USER ID TEXTBOX ===
            TextBox txtUser = new TextBox();
            txtUser.Location = new Point(200, 90);
            txtUser.Size = new Size(220, 30);
            txtUser.BackColor = Color.White;
            this.Controls.Add(txtUser);


            // === PASSWORD LABEL ===
            Label lblPass = new Label();
            lblPass.Text = "Password:";
            lblPass.Font = new Font("Bookman Old Style", 14.25F);
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Location = new Point(50, 140);
            this.Controls.Add(lblPass);


            // === PASSWORD TEXTBOX ===
            TextBox txtPass = new TextBox();
            txtPass.Location = new Point(200, 140);
            txtPass.Size = new Size(220, 30);
            txtPass.PasswordChar = '*';
            txtPass.BackColor = Color.White;
            this.Controls.Add(txtPass);


            // === NEW USER BUTTON ===
            Button btnNew = new Button();
            btnNew.Text = "New User";
            btnNew.BackColor = Color.LightGreen;
            btnNew.ForeColor = Color.Black;
            btnNew.Size = new Size(120, 40);
            btnNew.Location = new Point(50, 210);
            this.Controls.Add(btnNew);


            // === LOGIN BUTTON ===
            Button btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.BackColor = Color.SkyBlue;
            btnLogin.ForeColor = Color.Black;
            btnLogin.Size = new Size(120, 40);
            btnLogin.Location = new Point(195, 210);
            this.Controls.Add(btnLogin);


            // === FORGOT PASSWORD BUTTON ===
            Button btnForgot = new Button();
            btnForgot.Text = "Forgot Password";
            btnForgot.BackColor = Color.LightCoral;
            btnForgot.ForeColor = Color.Black;
            btnForgot.Size = new Size(140, 40);
            btnForgot.Location = new Point(340, 210);
            this.Controls.Add(btnForgot);
        }
    }
}
