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
    public partial class Equip : Form
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

        public Equip()
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 249, 249);
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
            this.Hide();
            SportForm sportform = new SportForm();
            sportform.Show();
        }

        private void glav_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void enduro_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enduro enduro = new Enduro();
            enduro.Show();
        }

        private void moto_eqip_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы уже находитесь на данной странице");
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
            String ohlajd = ohlajd_box.Text;
            String vizor = vizor_box.Text;
            String shtorka = shtorka_box.Text;
            String bez = bez_box.Text;
            String money = money_box.Text;
            String type = model_change_box.Text;

            String model2 = model_box_2.Text;
            String ohlajd2 = ohlajd_box_2.Text;
            String vizor2 = vizor_box_2.Text;
            String shtorka2 = bez_box_2.Text;
            String bez2 = bez_box_2.Text;
            String money2 = money_box_2.Text;

            String model3 = model_box_3.Text;
            String ohlajd3 = ohlajd_box_3.Text;
            String vizor3 = vizor_box_3.Text;
            String shtorka3 = shtorka_box_3.Text;
            String bez3 = bez_box_3.Text;
            String money3 = money_box_3.Text;




            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `equip_bank` WHERE `type_model` = @tmd", db.getConnection());

            command.Parameters.Add("@tmd", MySqlDbType.VarChar).Value = type;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            model_box.Text = table.Rows[0][2].ToString();
            ohlajd_box.Text = table.Rows[0][3].ToString();
            vizor_box.Text = table.Rows[0][4].ToString();
            shtorka_box.Text = table.Rows[0][5].ToString();
            bez_box.Text = table.Rows[0][6].ToString();
            money_box.Text = table.Rows[0][7].ToString();

            model_box_2.Text = table.Rows[1][2].ToString();
            ohlajd_box_2.Text = table.Rows[1][3].ToString();
            vizor_box_2.Text = table.Rows[1][4].ToString();
            shtorka_box_2.Text = table.Rows[1][5].ToString();
            bez_box_2.Text = table.Rows[1][6].ToString();
            money_box_2.Text = table.Rows[1][7].ToString();

            model_box_3.Text = table.Rows[2][2].ToString();
            ohlajd_box_3.Text = table.Rows[2][3].ToString();
            vizor_box_3.Text = table.Rows[2][4].ToString();
            shtorka_box_3.Text = table.Rows[2][5].ToString();
            bez_box_3.Text = table.Rows[2][6].ToString();
            money_box_3.Text = table.Rows[2][7].ToString();



        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            model_box.Clear();
            ohlajd_box.Clear();
            vizor_box.Clear();
            shtorka_box.Clear();
            bez_box.Clear();
            money_box.Clear();

            model_box_2.Clear();
            ohlajd_box_2.Clear();
            vizor_box_2.Clear();
            shtorka_box_2.Clear();
            bez_box_2.Clear();
            money_box_2.Clear();

            model_box_3.Clear();
            ohlajd_box_3.Clear();
            vizor_box_3.Clear();
            shtorka_box_3.Clear();
            bez_box_3.Clear();
            money_box_3.Clear();
        }
    }

}
