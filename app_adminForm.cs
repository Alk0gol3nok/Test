using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firts_Forms
{
    public partial class App_adminForm : Form
    {
        public App_adminForm()
        {
            InitializeComponent();

            loginField.Text = "Вы вошли как: ";
            loginField.ForeColor = Color.Black;
            User_checker_field.Text = DataBank.text;

            calendare_pannel.Hide();
            main_pannel.Hide();
            
        }

        Point lastPoint;


        private void type_pp_Click(object sender, EventArgs e)
        {
            String tfield = t_field.Text;
            String login = login_app_box.Text;
            String fullName = fullName_app_box.Text;
            String date_p = date_p_app_box.Text;
            String number = number_app_box.Text;
            String dop = dob_app_box.Text;
            String pob = pob_app_box.Text;
            String otziv = otziv_box.Text;


            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `application` WHERE `type` = @tf", db.getConnection());

            command.Parameters.Add("@tf", MySqlDbType.VarChar).Value = tfield; 


            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            login_app_box.Text = table.Rows[0][2].ToString();
            fullName_app_box.Text = table.Rows[0][3].ToString();
            date_p_app_box.Text = table.Rows[0][4].ToString();
            number_app_box.Text = table.Rows[0][5].ToString();
            dob_app_box.Text = table.Rows[0][6].ToString();
            pob_app_box.Text = table.Rows[0][7].ToString();
            otziv_box.Text = table.Rows[0][8].ToString();


            main_pannel.Show();
        }

        private void date_button_Click(object sender, EventArgs e)
        {
            calendare_pannel.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_form adminnform = new Admin_form();
            adminnform.Show();
        }

        private void return_button_MouseEnter(object sender, EventArgs e)
        {
            return_button.BackColor = Color.Red;
        }

        private void return_button_MouseLeave(object sender, EventArgs e)
        {
            return_button.BackColor = Color.White;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            String loginUser = login_delete_box.Text; 


            DataBase db = new DataBase(); 

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE  FROM `application` WHERE `login` = @uL", db.getConnection()); 
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser; 

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MessageBox.Show("Отзыв удалён");
        }

        private void red_button_Click(object sender, EventArgs e)
        {
            String login = login_app_box.Text;
            String fullName = fullName_app_box.Text;
            String date_p = date_p_app_box.Text;
            String number = number_app_box.Text;
            String dop = dob_app_box.Text;
            String pob = pob_app_box.Text;
            String otziv = otziv_box.Text;
            String red_login = red_login_box.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand commandd = new MySqlCommand("UPDATE application SET otziv = @otz WHERE login = @uL", db.getConnection());

            commandd.Parameters.Add("@otz", MySqlDbType.VarChar).Value = otziv;
            commandd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = commandd;
            adapter.Fill(table);
            {
                MessageBox.Show("Отзыв успешно изменен");
            }
        }
    }
}
