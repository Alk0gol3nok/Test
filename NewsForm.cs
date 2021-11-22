using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firts_Forms
{
    public partial class NewsForm : Form
    {

        public bool checkRole(string role, string need)
        {
            if (role.ToLower() == need)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public NewsForm()
        {
            InitializeComponent();
            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void NewsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void NewsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 249, 249);
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            this.loginField.ForeColor = System.Drawing.Color.Black;
        }

        private void kab_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePwd cng_pwd = new ChangePwd();
            cng_pwd.Show();
        }

        private void kab_button_MouseEnter(object sender, EventArgs e)
        {
            kab_button.BackColor = Color.Green;
        }

        private void kab_button_MouseLeave(object sender, EventArgs e)
        {
            kab_button.BackColor = Color.White;
        }

        private void nazadLogin_img_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void nazad_reg_lb_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void sport_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SportForm sport = new SportForm();
            sport.Show();
        }

        private void enduro_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enduro enduro = new Enduro();
            enduro.Show();
        }

        private void moto_eqip_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equip eq = new Equip();
            eq.Show();
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application_pp app_pp = new Application_pp();
            app_pp.Show();
        }

        private void news_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже находитесь на данной странице");
        }

        private void nazadRegister_img_Click(object sender, EventArgs e)
        {
            this.Close();
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}
