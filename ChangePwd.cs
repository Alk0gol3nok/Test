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
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
            loginField.Text = "Добро пожаловать";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;
            sbros_pwd_pannel.Hide();
            data_info_panel.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 249, 249);
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

        private void sm_pwd_button_MouseEnter(object sender, EventArgs e)
        {
            sm_pwd_button.BackColor = Color.Green;
        }

        private void sm_pwd_button_MouseLeave(object sender, EventArgs e)
        {
            sm_pwd_button.BackColor = Color.White;
        }

        private void sm_pwd_button_Click(object sender, EventArgs e)
        {
            DataBank.text = User_checker_field.Text;
            String loginUser = User_checker_field.Text;
            String pass = change_pwd.Text;// получаем данные от пользователя //


            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @pass", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; // вставляю в заглушку переменную //
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                sbros_pwd_pannel.Show();
            }

            else
                MessageBox.Show("Неверно введен пароль");
        }

        private void active_pwd_button_Click(object sender, EventArgs e)
        {
            string new_pss = new_pass.Text;
            string new_pss_2 = new_pass_active.Text;
            string loginUser = User_checker_field.Text;

            if (new_pss == new_pss_2)
            {
                DataBase dbb = new DataBase();
                MySqlCommand commandd = new MySqlCommand("UPDATE users SET password = @pss WHERE login = @uL  ", dbb.getConnection());

                
                commandd.Parameters.Add("@pss", MySqlDbType.VarChar).Value = new_pss;
                commandd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

                dbb.openConnection();
                if (commandd.ExecuteNonQuery() == 1)

                    MessageBox.Show("Вы успешно сменили пароль");
                
                dbb.closeConnection();
            }
            else
                MessageBox.Show("Ошибка, пароли не совпадают!");
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

        private void nazad_glav_img_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void look_data_info_MouseEnter(object sender, EventArgs e)
        {
            look_data_info.BackColor = Color.Green;
        }

        private void look_data_info_MouseLeave(object sender, EventArgs e)
        {
            look_data_info.BackColor = Color.White;
        }

        private void look_data_info_Click(object sender, EventArgs e)
        {
            String pass = pass_data_box.Text;
            String login = login_data_box.Text;
            String fullName = fio_data_box.Text;
            String pob = pob_data_box.Text;
            String num = number_data_box.Text;
            String dob = dob_data_box.Text;


            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE login = @lg AND password = @ps" , db.getConnection());

            command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pass;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            fio_data_box.Text = table.Rows[0][3].ToString();
            dob_data_box.Text = table.Rows[0][4].ToString();
            pob_data_box.Text = table.Rows[0][5].ToString();
            number_data_box.Text = table.Rows[0][6].ToString();
            

            data_info_panel.Show();
        }

        private void change_data_button_Click(object sender, EventArgs e)
        {
            string new_fio = fio_data_box_change.Text;
            string new_pob = pob_data_box_change.Text;
            string new_number = number_data_box_change.Text;
            string new_dob = dob_data_box_change.Text;
            string login = login_data_box.Text;

            DataBase dbb = new DataBase();
                MySqlCommand commandd = new MySqlCommand("UPDATE users SET Fullname = @fl, Dob = @db, Pob = @pb, PhoneNumber = @pn WHERE login = @uL  ", dbb.getConnection());

            commandd.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            commandd.Parameters.Add("@fl", MySqlDbType.VarChar).Value = new_fio;
            commandd.Parameters.Add("@db", MySqlDbType.VarChar).Value = new_dob;
            commandd.Parameters.Add("@pb", MySqlDbType.VarChar).Value = new_pob;
            commandd.Parameters.Add("@pn", MySqlDbType.VarChar).Value = new_number;

            if (fio_data_box_change.Text == "")
            {
                MessageBox.Show("Вы не указали ФИО");
                return;
            }

            if (pob_data_box_change.Text == "")
            {
                MessageBox.Show("Вы не указали место рождения");
            }

            if (number_data_box_change.Text == "")
            {
                MessageBox.Show("Вы не указали номер телефона");
            }

            if (dob_data_box_change.Text == "")
            {
                MessageBox.Show("Вы не указали дату рождения");
            }



            dbb.openConnection();

            if (commandd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно сменили данные");
                
            }

            dbb.closeConnection();
        }
    }
}
