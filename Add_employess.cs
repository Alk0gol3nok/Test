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
    public partial class Add_employess : Form
    {
        public Add_employess()
        {
            InitializeComponent();

            loginField.Text = "Вы вошли как:";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;


            login_field_emp.Text = "логин";
            login_field_emp.ForeColor = Color.Gray;

            pass_field_emp.Text = "пароль";
            pass_field_emp.ForeColor = Color.Gray;

            number_field_emp.Text = "номер тлф";
            number_field_emp.ForeColor = Color.Gray;

            fio_field_emp.Text = "ФИО";
            fio_field_emp.ForeColor = Color.Gray;

            br_field_emp.Text = "День рождения";
            br_field_emp.ForeColor = Color.Gray;

            place_field_emp.Text = "Место рождения";
            place_field_emp.ForeColor = Color.Gray;

            role_field_emp.Text = "роль";
            role_field_emp.ForeColor = Color.Gray;
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

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form admin_Form = new Admin_form();
            admin_Form.Show();
        }

        private void return_button_MouseEnter(object sender, EventArgs e)
        {
            return_button.BackColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void return_button_MouseLeave(object sender, EventArgs e)
        {
            return_button.BackColor = Color.FromArgb(255, 249, 249, 249);
        }

        private void login_field_emp_Enter(object sender, EventArgs e)
        {
            if (login_field_emp.Text == "логин")
            {
                login_field_emp.Text = "";
                login_field_emp.ForeColor = Color.Black;
            }
        }

        private void login_field_emp_Leave(object sender, EventArgs e)
        {
            if (login_field_emp.Text == "")
            {
                login_field_emp.Text = "логин";
                login_field_emp.ForeColor = Color.Gray;
            }
        }

        private void pass_field_emp_Enter(object sender, EventArgs e)
        {
            if (pass_field_emp.Text == "пароль")
            {
                pass_field_emp.Text = "";
                pass_field_emp.ForeColor = Color.Black;
            }
        }

        private void pass_field_emp_Leave(object sender, EventArgs e)
        {
            if (pass_field_emp.Text == "")
            {
                pass_field_emp.Text = "пароль";
                pass_field_emp.ForeColor = Color.Gray;
            }
        }

        private void number_field_emp_Enter(object sender, EventArgs e)
        {
            if (number_field_emp.Text == "номер тлф")
            {
                number_field_emp.Text = "";
                number_field_emp.ForeColor = Color.Black;
            }
        }

        private void number_field_emp_Leave(object sender, EventArgs e)
        {
            if (number_field_emp.Text == "")
            {
                number_field_emp.Text = "номер тлф";
                number_field_emp.ForeColor = Color.Gray;
            }
        }

        private void fio_field_emp_Enter(object sender, EventArgs e)
        {
            if (fio_field_emp.Text == "ФИО")
            {
                fio_field_emp.Text = "";
                fio_field_emp.ForeColor = Color.Black;
            }
        }

        private void fio_field_emp_Leave(object sender, EventArgs e)
        {
            if (fio_field_emp.Text == "")
            {
                fio_field_emp.Text = "ФИО";
                fio_field_emp.ForeColor = Color.Gray;
            }
        }

        private void br_field_emp_Enter(object sender, EventArgs e)
        {
            if (br_field_emp.Text == "День рождения")
            {
                br_field_emp.Text = "";
                br_field_emp.ForeColor = Color.Black;
            }
        }

        private void br_field_emp_Leave(object sender, EventArgs e)
        {
            if (br_field_emp.Text == "")
            {
                br_field_emp.Text = "День рождения";
                br_field_emp.ForeColor = Color.Gray;
            }
        }

        private void place_field_emp_Enter(object sender, EventArgs e)
        {
            if (place_field_emp.Text == "Место рождения")
            {
                place_field_emp.Text = "";
                place_field_emp.ForeColor = Color.Black;
            }
        }

        private void place_field_emp_Leave(object sender, EventArgs e)
        {
            if (place_field_emp.Text == "")
            {
                place_field_emp.Text = "Место рождения";
                place_field_emp.ForeColor = Color.Gray;
            }
        }

        private void role_field_emp_Enter(object sender, EventArgs e)
        {
            if (role_field_emp.Text == "роль")
            {
                role_field_emp.Text = "";
                role_field_emp.ForeColor = Color.Black;
            }
        }

        private void role_field_emp_Leave(object sender, EventArgs e)
        {
            if (role_field_emp.Text == "")
            {
                role_field_emp.Text = "роль";
                role_field_emp.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_field_emp.Text == "логин") // проверка на пустоту //
            {
                MessageBox.Show("введите логин");
                return;
            }

            if  (pass_field_emp.Text == "пароль")
            {
                MessageBox.Show("введите пароль");
                return;
            }

            if (fio_field_emp.Text == "ФИО")
            {
                MessageBox.Show("введите ФИО");
                return;
            }

           if (br_field_emp.Text == "День рождения")
            {
                MessageBox.Show("введите дату рождения");
                return;
            }

            if (place_field_emp.Text == "Место рождения")
            {
                MessageBox.Show("введите место рождения");
                return;
            }

            if (number_field_emp.Text == "номер тлф")
            {
                MessageBox.Show("введите Номер тлф");
                return;
            }

            if (role_field_emp.Text == "роль")
            {
                MessageBox.Show("введите роль");
                return;
            }

            if (checkUser())
            {
                return;
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO employees (login, password, Fullname, Dob, Pob, PhoneNumber, role) VALUES (@login, @password, @Fio, @date, @place, @num, @role)", db.getConnection());

            string login = login_field_emp.Text;
            string pass = pass_field_emp.Text;
            string Fio = fio_field_emp.Text;
            string date = br_field_emp.Text;
            string place = place_field_emp.Text;
            string num = number_field_emp.Text;
            string role = role_field_emp.Text;


            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@Fio", MySqlDbType.VarChar).Value = Fio;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = num;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Регистрация сотрудника успешна");
            else
                MessageBox.Show("Регистрация не удалась");

            db.closeConnection();
        }

        public Boolean checkUser() // проверка на уникальность логина //
        {
            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `employees` WHERE `login` = @uL OR `PhoneNumber` = @num", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_field_emp.Text; // вставляю в заглушку переменную //
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number_field_emp.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) // проверяем сколько записей уже существует, и верно ли введены данные //
            {
                MessageBox.Show("Логин или номер телефона уже зарегистрированы, введите другие данные");
                return true;
            }

            else
                return false;
        }
    }
    
}
