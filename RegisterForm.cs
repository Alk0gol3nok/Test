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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 51);

            loginField.Text = "логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "пароль";
            passField.ForeColor = Color.Gray;

            numberField.Text = "номер тлф";
            numberField.ForeColor = Color.Gray;

            FioField.Text = "ФИО";
            FioField.ForeColor = Color.Gray;

            BrField.Text = "День рождения";
            BrField.ForeColor = Color.Gray;

            PlaceField.Text = "Место рождения";
            PlaceField.ForeColor = Color.Gray;

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


        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void numberField_Enter(object sender, EventArgs e)
        {
            if (numberField.Text == "номер тлф")
            {
                numberField.Text = "";
                numberField.ForeColor = Color.Black;
            }
        }

        private void numberField_Leave(object sender, EventArgs e)
        {
            if (numberField.Text == "")
            {
                numberField.Text = "номер тлф";
                numberField.ForeColor = Color.Gray;
            }
        }

        private void FioField_Enter(object sender, EventArgs e)
        {
            if (FioField.Text == "ФИО")
            {
                FioField.Text = "";
                FioField.ForeColor = Color.Black;
            }
        }

        private void FioField_Leave(object sender, EventArgs e)
        {
            if (FioField.Text == "")
            {
                FioField.Text = "ФИО";
                FioField.ForeColor = Color.Gray;
            }
        }

        private void BrField_Enter(object sender, EventArgs e)
        {
            if (BrField.Text == "День рождения")
            {
                BrField.Text = "";
                BrField.ForeColor = Color.Black;
            }
        }

        private void BrField_Leave(object sender, EventArgs e)
        {
            if (BrField.Text == "")
            {
                BrField.Text = "День рождения";
                BrField.ForeColor = Color.Gray;
            }
        }

        private void PlaceField_Enter(object sender, EventArgs e)
        {
            if (PlaceField.Text == "Место рождения")
            {
                PlaceField.Text = "";
                PlaceField.ForeColor = Color.Black;

            }
        }

        private void PlaceField_Leave(object sender, EventArgs e)
        {
            if (PlaceField.Text == "")
            {
                PlaceField.Text = "Место рождения";
                PlaceField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "логин") 
            {
                MessageBox.Show("введите логин");
                return;
            }

            if (passField.Text == "пароль")
            {
                MessageBox.Show("введите пароль");
                return;
            }

            if (FioField.Text == "ФИО")
            {
                MessageBox.Show("введите ФИО");
                return;
            }

            if (BrField.Text == "День рождения")
            {
                MessageBox.Show("введите дату рождения");
                return;
            }

            if (PlaceField.Text == "Место рождения")
            {
                MessageBox.Show("введите место рождения");
                return;
            }

            if (numberField.Text == "номер тлф")
            {
                MessageBox.Show("введите номер телефона");
                return;
            }

            if (checkUser())
            {
                return;
            }


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (login, password, Fullname, Dob, Pob, PhoneNumber, role) VALUES (@login, @password, @Fio, @date, @place, @num, @role)", db.getConnection());
            
            string login = loginField.Text;
            string pass = passField.Text;
            string Fio = FioField.Text;
            string date = BrField.Text;
            string place = PlaceField.Text;
            string num = numberField.Text;
            string role = "пользователь";
            

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@Fio", MySqlDbType.VarChar).Value = Fio;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@place", MySqlDbType.VarChar).Value = place;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = num;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Регистрация успешна");
            else
                MessageBox.Show("Регистрация не удалась");

            db.closeConnection();
        }

        public Boolean checkUser() 
        {
            DataBase db = new DataBase(); 

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL OR `PhoneNumber` = @num", db.getConnection()); 
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text; 
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = numberField.Text; 

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) 
            {
                MessageBox.Show("Логин или номер телефона уже зарегистрированы, введите другие данные");
                return true;
            }

            else
                return false;
        }

        private void AutoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void closeButton_MouseEnter_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 11, 57);
        }

        private void closeButton_MouseLeave_1(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(255, 249, 249, 249);
        }

        private void RegLabel_MouseEnter(object sender, EventArgs e)
        {
            RegLabel.ForeColor = Color.Black;
        }

        private void RegLabel_MouseLeave(object sender, EventArgs e)
        {
            RegLabel.ForeColor = Color.White;
        }

    }
}

