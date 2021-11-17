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
    public partial class Application_pp : Form
    {
        public Application_pp()
        {
            InitializeComponent();

            date_pannel.Hide();

            loginField.Text = "Вы вошли как:";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;


            login_app.Text = "логин";
            login_app.ForeColor = Color.Gray;

            fio_app.Text = "ФИО";
            fio_app.ForeColor = Color.Gray;

            number_app.Text = "номер тлф";
            number_app.ForeColor = Color.Gray;

            dob_app.Text = "Дата рождения";
            dob_app.ForeColor = Color.Gray;

            pob_app.Text = "Место рождения";
            pob_app.ForeColor = Color.Gray;

            date_app.Text = "Дата подачи заявки";
            date_app.ForeColor = Color.Gray;

            type_app.Text = "Тип заявки";
            type_app.ForeColor = Color.Gray;
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_app.Text == "логин") // проверка на пустоту //
            {
                MessageBox.Show("введите логин");
                return;
            }

            if (fio_app.Text == "ФИО")
            {
                MessageBox.Show("введите ФИО");
                return;
            }

            if (number_app.Text == "номер тлф")
            {
                MessageBox.Show("введите номер тлф");
                return;
            }

            if (dob_app.Text == "дата рождения")
            {
                MessageBox.Show("введите дату рождения");
                return;
            }

            if (pob_app.Text == "Место рождения")
            {
                MessageBox.Show("введите место рождения");
                return;
            }

            if (date_app.Text == "Дата подачи заявки")
            {
                MessageBox.Show("введите дату подачи заявки");
                return;
            }

            if (type_app.Text == "Тип заявки")
            {
                MessageBox.Show("введите тип заявки");
                return;
            }


            if (checkUser())
            {
                return;
            }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO application (login, Fullname, date_p, number, Dob, Pob, type_app) VALUES (@login, @Fio, @date_p, @num, @dob, @pob, @type)", db.getConnection());

            string login = login_app.Text;
            string fio = fio_app.Text;
            string date_p = date_app.Text;
            string number = number_app.Text;
            string dob = dob_app.Text;
            string pob = pob_app.Text;
            string type = type_app.Text;


            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@Fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@date_p", MySqlDbType.VarChar).Value = date_p;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = dob;
            command.Parameters.Add("@pob", MySqlDbType.VarChar).Value = pob;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Заявка подана успешно");
            else
                MessageBox.Show("Ошибка, заявка не прошла регистрацию");

            db.closeConnection();
        }

        public Boolean checkUser() // проверка на уникальность логина //
        {
            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `application` WHERE `login` = @login", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_app.Text; // вставляю в заглушку переменную //
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) // проверяем сколько записей уже существует, и верно ли введены данные //
            {
                MessageBox.Show("Заявка уже подана, находится на рассмотрении");
                return true;
            }

            else
                return false;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void login_app_Enter(object sender, EventArgs e)
        {
            if (login_app.Text == "логин")
            {
                login_app.Text = "";
                login_app.ForeColor = Color.Black;
            }
        }

        private void login_app_Leave(object sender, EventArgs e)
        {
            if (login_app.Text == "")
            {
                login_app.Text = "логин";
                login_app.ForeColor = Color.Gray;
            }
        }

        private void fio_app_Enter(object sender, EventArgs e)
        {
            if (fio_app.Text == "ФИО")
            {
                fio_app.Text = "";
                fio_app.ForeColor = Color.Black;
            }
        }

        private void fio_app_Leave(object sender, EventArgs e)
        {
            if (fio_app.Text == "")
            {
                fio_app.Text = "ФИО";
                fio_app.ForeColor = Color.Gray;
            }
        }

        private void number_app_Enter(object sender, EventArgs e)
        {
            if (number_app.Text == "номер тлф")
            {
                number_app.Text = "";
                number_app.ForeColor = Color.Black;
            }
        }

        private void number_app_Leave(object sender, EventArgs e)
        {
            if (number_app.Text == "")
            {
                number_app.Text = "номер тлф";
                number_app.ForeColor = Color.Gray;
            }
        }

        private void dob_app_Enter(object sender, EventArgs e)
        {
            if (dob_app.Text == "Дата рождения")
            {
                dob_app.Text = "";
                dob_app.ForeColor = Color.Black;
            }
        }

        private void dob_app_Leave(object sender, EventArgs e)
        {
            if (dob_app.Text == "")
            {
                dob_app.Text = "Дата рождения";
                dob_app.ForeColor = Color.Gray;
            }
        }

        private void pob_app_Enter(object sender, EventArgs e)
        {
            if (pob_app.Text == "Место рождения")
            {
                pob_app.Text = "";
                pob_app.ForeColor = Color.Black;
            }
        }

        private void pob_app_Leave(object sender, EventArgs e)
        {
            if (pob_app.Text == "")
            {
                pob_app.Text = "Место рождения";
                pob_app.ForeColor = Color.Gray;
            }
        }

        private void date_app_Enter(object sender, EventArgs e)
        {
            if (date_app.Text == "Дата подачи заявки")
            {
                date_app.Text = "";
                date_app.ForeColor = Color.Black;
            }
        }

        private void date_app_Leave(object sender, EventArgs e)
        {
            if (date_app.Text == "")
            {
                date_app.Text = "Дата подачи заявки";
                date_app.ForeColor = Color.Gray;
            }
        }

        private void type_app_Enter(object sender, EventArgs e)
        {
            if (type_app.Text == "Тип заявки")
            {
                type_app.Text = "";
                type_app.ForeColor = Color.Black;
            }
        }

        private void type_app_Leave(object sender, EventArgs e)
        {
            if (type_app.Text == "")
            {
                type_app.Text = "Тип заявки";
                type_app.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            date_pannel.Show();
        }

        
    }
}
