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
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();

            loginField.Text = "Вы вошли как:";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;
        }


        Point lastPoint;

        private void mainPannel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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

        private void return_button_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void return_button_MouseEnter(object sender, EventArgs e)
        {
            return_button.BackColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void return_button_MouseLeave(object sender, EventArgs e)
        {
            return_button.BackColor = Color.FromArgb(255, 249, 249, 249);
        }

        private void role_v_1_Click(object sender, EventArgs e)
        {
            

            DataBank.text = login_menu_field_1.Text;
            String loginUser = login_menu_field_1.Text; // получаем данные от пользователя //
            

            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; // вставляю в заглушку переменную //
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataBase dbb = new DataBase();
                MySqlCommand commandd= new MySqlCommand("UPDATE users SET role = @role WHERE login = @uL  ", dbb.getConnection());

                string role = spisok_role_1.Text;
                commandd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
                commandd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

                dbb.openConnection();
                if (commandd.ExecuteNonQuery() == 1)

                    MessageBox.Show("Роль выдана успешно");
                else
                    MessageBox.Show("Роль не выдана, ошибка");
                dbb.closeConnection();

            }

            else
                MessageBox.Show("Данного пользователя не существует");
        }

        private void role_v_2_Click(object sender, EventArgs e)
        {
            

            DataBank.text = login_menu_field_2.Text;
            String loginUser = login_menu_field_2.Text; // получаем данные от пользователя //


            DataBase db = new DataBase(); // создаём нужные объекты //

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection()); // ставим загрушки //
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; // вставляю в заглушку переменную //

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                DataBase dbb = new DataBase();
                MySqlCommand commandd = new MySqlCommand("DELETE FROM users WHERE login = @uL", dbb.getConnection());

                string role = spisok_role_1.Text;
                commandd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
                commandd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

                dbb.openConnection();
                if (commandd.ExecuteNonQuery() == 1)

                    MessageBox.Show("Участник удалён успешно");
                else
                    MessageBox.Show("Участник не был удалён");
                dbb.closeConnection();

            }

            else
                MessageBox.Show("Данного пользователя не существует");
        }

        private void add_emp_MouseEnter(object sender, EventArgs e)
        {
            add_emp.BackColor = Color.FromArgb(138, 130, 129);
        }

        private void add_emp_MouseLeave(object sender, EventArgs e)
        {
            add_emp.BackColor = Color.White;
        }

        private void menu_app_MouseEnter(object sender, EventArgs e)
        {
            menu_app.BackColor = Color.FromArgb(138, 130, 129);
        }

        private void menu_app_MouseLeave(object sender, EventArgs e)
        {
            menu_app.BackColor = Color.White;
        }

        private void add_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_employess add_emp = new Add_employess();
            add_emp.Show();
        }

        private void menu_app_Click(object sender, EventArgs e)
        {
            this.Hide();
            App_adminForm appAd = new App_adminForm();
            appAd.Show();
        }
    }
    
}
