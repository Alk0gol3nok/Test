using MySql.Data.MySqlClient;
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
    public partial class SportForm : Form
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
        public SportForm()
        {
            InitializeComponent();
            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;

            show_panel.Hide();
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void mainPannel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPannel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPannel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeB_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeB_MouseLeave(object sender, EventArgs e)
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

        private void nazadRegister_img_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void sport_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже находитесь на данной странице");
        }

        private void glav_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application_pp app_pp = new Application_pp();
            app_pp.Show();
        }

        private void looking_button_Click(object sender, EventArgs e)
        {
            String model = model_box.Text;
            String dvig = dvig_box.Text;
            String mosh = mosh_box.Text;
            String skr = skr_box.Text;
            String kpp = kpp_box.Text;
            String money = money_box.Text;
            String type = model_change_box.Text;

            String model2 = model_box_2.Text;
            String dvig2 = dvig_box_2.Text;
            String mosh2 = mosh_box_2.Text;
            String skr2 = skr_box_2.Text;
            String kpp2 = kpp_box_2.Text;
            String money2 = money_box_2.Text;

            String model3 = model_box_3.Text;
            String dvig3 = dvig_box_3.Text;
            String mosh3 = mosh_box_3.Text;
            String skr3 = skr_box_3.Text;
            String kpp3 = kpp_box_3.Text;
            String money3 = money_box_3.Text;
            



            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sport_bank` WHERE `type_model` = @tmd", db.getConnection());

            command.Parameters.Add("@tmd", MySqlDbType.VarChar).Value = type;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            model_box.Text = table.Rows[0][1].ToString();
            dvig_box.Text = table.Rows[0][2].ToString();
            mosh_box.Text = table.Rows[0][3].ToString();
            skr_box.Text = table.Rows[0][4].ToString();
            kpp_box.Text = table.Rows[0][5].ToString();
            money_box.Text = table.Rows[0][6].ToString();

            model_box_2.Text = table.Rows[1][1].ToString();
            dvig_box_2.Text = table.Rows[1][2].ToString();
            mosh_box_2.Text = table.Rows[1][3].ToString();
            skr_box_2.Text = table.Rows[1][4].ToString();
            kpp_box_2.Text = table.Rows[1][5].ToString();
            money_box_2.Text = table.Rows[1][6].ToString();

            model_box_3.Text = table.Rows[2][1].ToString();
            dvig_box_3.Text = table.Rows[2][2].ToString();
            mosh_box_3.Text = table.Rows[2][3].ToString();
            skr_box_3.Text = table.Rows[2][4].ToString();
            kpp_box_3.Text = table.Rows[2][5].ToString();
            money_box_3.Text = table.Rows[2][6].ToString();


            show_panel.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            model_box.Clear();
            dvig_box.Clear();
            mosh_box.Clear();
            skr_box.Clear();
            kpp_box.Clear();
            money_box.Clear();

            model_box_2.Clear();
            dvig_box_2.Clear();
            mosh_box_2.Clear();
            skr_box_2.Clear();
            kpp_box_2.Clear();
            money_box_2.Clear();

            model_box_3.Clear();
            dvig_box_3.Clear();
            mosh_box_3.Clear();
            skr_box_3.Clear();
            kpp_box_3.Clear();
            money_box_3.Clear();
        }
    }
}
