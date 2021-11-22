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
    public partial class PokypkaForm : Form
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
        public PokypkaForm()
        {
            InitializeComponent();
            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;

            vibor_panel.Hide();
            sport_pokypka_panel.Hide();
            enduro_pokypka_panel.Hide();
            equip_pokypka_panel.Hide();
            sport_panel.Hide();
            enduro_panel.Hide();
            equip_panel.Hide();
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

        private void menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            vibor_panel.Show();
        }

        private void sport_button_pannel_Click(object sender, EventArgs e)
        {
            sport_pokypka_panel.Show();
        }

        private void sport_button_pannel_2_Click(object sender, EventArgs e)
        {
            enduro_pokypka_panel.Show();
        }

        private void sport_button_pannel_3_Click(object sender, EventArgs e)
        {
            equip_pokypka_panel.Show();
        }

        private void sp_show_button_Click(object sender, EventArgs e)
        {
            sport_panel.Show();

            String model = model_box_1.Text;

            if (model_box_1.Text == "Yamaha R3")
            {
                money_box.Text = "600тыс/руб";
            }
        }

        private void en_show_button_Click(object sender, EventArgs e)
        {
            enduro_panel.Show();
        }

        private void eq_show_button_Click(object sender, EventArgs e)
        {
            equip_panel.Show();
        }

        private void buy_sport_button_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO pokypki (model, money, login, fio, number, address) VALUES (@mdl, @mn, @lg, @f, @num, @add)", db.getConnection());

            String model = model_box_1.Text;
            String money = money_box.Text;
            String login = login_box.Text;
            String fio = fio_box.Text;
            String number = num_box.Text;
            String address = address_box.Text;

            String model_1 = model_box_1.Text;

            command.Parameters.Add("@mdl", MySqlDbType.VarChar).Value = model_1;
            command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = money;
            command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@f", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = number;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Ваш заказ в обработке, следите за статусов в своём личном кабинете");
            else
                MessageBox.Show("Заказ не был передан менеджеру, у вас уже есть активный заказ");

            db.closeConnection();
        }
    }
}
