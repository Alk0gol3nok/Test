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
    public partial class LookingUsersForm : Form
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
        public LookingUsersForm()
        {
            InitializeComponent();
            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;

            looking_panel.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void mainPannel2_MouseDown(object sender, MouseEventArgs e)
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

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void nazadRegister_img_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void nazadLogin_img_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void looking_button_Click(object sender, EventArgs e)
        {
            String login = login_box.Text;
            String fio = fio_box.Text;
            String dd = date_d_box.Text;
            String dp = date_p_box.Text;
            String number = number_box.Text;
            String role = role_box.Text;

            String login2 = login_box_2.Text;
            String fio2 = fio_box_2.Text;
            String dd2 = date_d_box_2.Text;
            String dp2 = date_p_box_2.Text;
            String number2 = number_box_2.Text;
            String role2 = role_box_2.Text;

            String login3 = login_box_3.Text;
            String fio3 = fio_box_3.Text;
            String dd3 = date_d_box_3.Text;
            String dp3 = date_p_box_3.Text;
            String number3 = number_box_3.Text;
            String role3 = role_box_3.Text;

            String login4 = login_box_4.Text;
            String fio4 = fio_box_4.Text;
            String dd4 = date_d_box_4.Text;
            String dp4 = date_p_box_4.Text;
            String number4 = number_box_4.Text;
            String role4 = role_box_4.Text;

            String login5 = login_box_5.Text;
            String fio5 = fio_box_5.Text;
            String dd5 = date_d_box_5.Text;
            String dp5 = date_p_box_5.Text;
            String number5 = number_box_5.Text;
            String role5 = role_box_5.Text;

            String login6 = login_box_6.Text;
            String fio6 = fio_box_6.Text;
            String dd6 = date_d_box_6.Text;
            String dp6 = date_p_box_6.Text;
            String number6 = number_box_6.Text;
            String role6 = role_box_6.Text;

            String role_checker = "пользователь";

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `role` = @rlu", db.getConnection());

            command.Parameters.Add("@rlu", MySqlDbType.VarChar).Value = role_checker;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            login_box.Text = table.Rows[0][1].ToString();
            fio_box.Text = table.Rows[0][3].ToString();
            date_d_box.Text = table.Rows[0][4].ToString();
            date_p_box.Text = table.Rows[0][5].ToString();
            number_box.Text = table.Rows[0][6].ToString();
            role_box.Text = table.Rows[0][7].ToString();

            login_box_2.Text = table.Rows[1][1].ToString();
            fio_box_2.Text = table.Rows[1][3].ToString();
            date_d_box_2.Text = table.Rows[1][4].ToString();
            date_p_box_2.Text = table.Rows[1][5].ToString();
            number_box_2.Text = table.Rows[1][6].ToString();
            role_box_2.Text = table.Rows[1][7].ToString();

            login_box_3.Text = table.Rows[2][1].ToString();
            fio_box_3.Text = table.Rows[2][3].ToString();
            date_d_box_3.Text = table.Rows[2][4].ToString();
            date_p_box_3.Text = table.Rows[2][5].ToString();
            number_box_3.Text = table.Rows[2][6].ToString();
            role_box_3.Text = table.Rows[2][7].ToString();

            login_box_4.Text = table.Rows[3][1].ToString();
            fio_box_4.Text = table.Rows[3][3].ToString();
            date_d_box_4.Text = table.Rows[3][4].ToString();
            date_p_box_4.Text = table.Rows[3][5].ToString();
            number_box_4.Text = table.Rows[3][6].ToString();
            role_box_4.Text = table.Rows[3][7].ToString();

            login_box_5.Text = table.Rows[4][1].ToString();
            fio_box_5.Text = table.Rows[4][3].ToString();
            date_d_box_5.Text = table.Rows[4][4].ToString();
            date_p_box_5.Text = table.Rows[4][5].ToString();
            number_box_5.Text = table.Rows[4][6].ToString();
            role_box_5.Text = table.Rows[4][7].ToString();

            login_box_6.Text = table.Rows[5][1].ToString();
            fio_box_6.Text = table.Rows[5][3].ToString();
            date_d_box_6.Text = table.Rows[5][4].ToString();
            date_p_box_6.Text = table.Rows[5][5].ToString();
            number_box_6.Text = table.Rows[5][6].ToString();
            role_box_6.Text = table.Rows[5][7].ToString();



            looking_panel.Show();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            login_box.Clear();
            fio_box.Clear();
            date_d_box.Clear();
            date_p_box.Clear();
            number_box.Clear();
            role_box.Clear();

            login_box_2.Clear();
            fio_box_2.Clear();
            date_d_box_2.Clear();
            date_p_box_2.Clear();
            number_box_2.Clear();
            role_box_2.Clear();

            login_box_3.Clear();
            fio_box_3.Clear();
            date_d_box_3.Clear();
            date_p_box_3.Clear();
            number_box_3.Clear();
            role_box_3.Clear();

            login_box_4.Clear();
            fio_box_4.Clear();
            date_d_box_4.Clear();
            date_p_box_4.Clear();
            number_box_4.Clear();
            role_box_4.Clear();

            login_box_5.Clear();
            fio_box_5.Clear();
            date_d_box_5.Clear();
            date_p_box_5.Clear();
            number_box_5.Clear();
            role_box_5.Clear();

            login_box_6.Clear();
            fio_box_6.Clear();
            date_d_box_6.Clear();
            date_p_box_6.Clear();
            number_box_6.Clear();
            role_box_6.Clear();
        }
    }
}
