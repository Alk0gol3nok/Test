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
    public partial class MainForm : Form
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
        public MainForm()
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

        private void admin_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data,"админ"))
            {
                this.Hide();
                Admin_form admin_f = new Admin_form();
                admin_f.Show();
            }

           else
            {
                MessageBox.Show("Доступа нет");
            }




        }

        private void baza_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else if (checkRole(Data, "бухгалтер"))
            {
                MessageBox.Show("Доступ: есть");
            }
            else
            {
                MessageBox.Show("Доступа нет");
            }
        }

        private void bank_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else if (checkRole(Data, "бухгалтер"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else
            {
                MessageBox.Show("Доступа нет");
            }
        }

        private void chat_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else if (checkRole(Data, "бухгалтер"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else if (checkRole(Data, "пользователь"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else
            {
                MessageBox.Show("Доступа нет");
            }
        }

        private void Tech_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else if (checkRole(Data, "пользователь"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else
            {
                MessageBox.Show("Доступа нет");
            }
        }

        private void galery_button_Click(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "пользователь"))
            {
                MessageBox.Show("Доступ: есть");
            }

            else
            {
                MessageBox.Show("Доступа нет");
            }
        }

        private void admin_button_MouseEnter(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                admin_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else
            {
                admin_button.BackColor = Color.Red;
            }
        }

        private void admin_button_MouseLeave(object sender, EventArgs e)
        {
           admin_button.BackColor = Color.White;
        }

        private void baza_button_MouseEnter(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                baza_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else if (checkRole(Data, "бухгалтер"))
            {
                baza_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else
            {
                baza_button.BackColor = Color.Red;
            }
        }

        private void baza_button_MouseLeave(object sender, EventArgs e)
        {
          baza_button.BackColor = Color.White;
        }

        private void bank_button_MouseEnter(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                bank_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else if (checkRole(Data,"бухгалтер"))
            {
                bank_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else
            {
                bank_button.BackColor = Color.Red;
            }
        }

        private void bank_button_MouseLeave(object sender, EventArgs e)
        {
          bank_button.BackColor = Color.White;
        }

        private void chat_button_MouseEnter(object sender, EventArgs e)
        {
            chat_button.BackColor = Color.FromArgb(255, 0, 255, 0);
        }

        private void chat_button_MouseLeave(object sender, EventArgs e)
        {
            chat_button.BackColor = Color.White;
        }

        private void Tech_button_MouseEnter(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data, "админ"))
            {
                Tech_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else if (checkRole(Data, "пользователь"))
            {
                Tech_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }
            else
            {
                Tech_button.BackColor = Color.Red;
            }


        }

        private void Tech_button_MouseLeave(object sender, EventArgs e)
        {
            Tech_button.BackColor = Color.White;
        }

        private void galery_button_MouseEnter(object sender, EventArgs e)
        {
            String loginchecker = User_checker_field.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT role FROM `users` WHERE `login` = @ul", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginchecker;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string Data = table.Rows[0][0].ToString();

            if (checkRole(Data,"пользователь"))
            {
                galery_button.BackColor = Color.FromArgb(255, 0, 255, 0);
            }

            else
            {
                galery_button.BackColor = Color.Red;
            }


        }

        private void galery_button_MouseLeave(object sender, EventArgs e)
        {
          galery_button.BackColor = Color.White;
        }

        private void nazadLogin_img_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void nazadRegister_img_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void nazadLogin_img_MouseEnter(object sender, EventArgs e)
        {
            nazadLogin_img.ForeColor = Color.Red;
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
    }
}
