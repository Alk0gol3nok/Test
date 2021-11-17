
namespace Firts_Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPannel2 = new System.Windows.Forms.Panel();
            this.RegLabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlaceField = new System.Windows.Forms.TextBox();
            this.numberField = new System.Windows.Forms.TextBox();
            this.BrField = new System.Windows.Forms.TextBox();
            this.FioField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.mainPannel = new System.Windows.Forms.Label();
            this.mainPannel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPannel2
            // 
            this.mainPannel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(75)))), ((int)(((byte)(158)))));
            this.mainPannel2.Controls.Add(this.RegLabel);
            this.mainPannel2.Controls.Add(this.pictureBox6);
            this.mainPannel2.Controls.Add(this.pictureBox5);
            this.mainPannel2.Controls.Add(this.pictureBox4);
            this.mainPannel2.Controls.Add(this.pictureBox3);
            this.mainPannel2.Controls.Add(this.PlaceField);
            this.mainPannel2.Controls.Add(this.numberField);
            this.mainPannel2.Controls.Add(this.BrField);
            this.mainPannel2.Controls.Add(this.FioField);
            this.mainPannel2.Controls.Add(this.buttonRegister);
            this.mainPannel2.Controls.Add(this.passField);
            this.mainPannel2.Controls.Add(this.pictureBox2);
            this.mainPannel2.Controls.Add(this.loginField);
            this.mainPannel2.Controls.Add(this.pictureBox1);
            this.mainPannel2.Controls.Add(this.panel3);
            this.mainPannel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainPannel2.Location = new System.Drawing.Point(0, 0);
            this.mainPannel2.Name = "mainPannel2";
            this.mainPannel2.Size = new System.Drawing.Size(799, 498);
            this.mainPannel2.TabIndex = 1;
            this.mainPannel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPannel2_MouseDown);
            this.mainPannel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPannel2_MouseMove);
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.ForeColor = System.Drawing.Color.White;
            this.RegLabel.Location = new System.Drawing.Point(329, 475);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(121, 13);
            this.RegLabel.TabIndex = 14;
            this.RegLabel.Text = "Уже есть аккаунт?";
            this.RegLabel.Click += new System.EventHandler(this.AutoLabel_Click);
            this.RegLabel.MouseEnter += new System.EventHandler(this.RegLabel_MouseEnter);
            this.RegLabel.MouseLeave += new System.EventHandler(this.RegLabel_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Firts_Forms.Properties.Resources.place;
            this.pictureBox6.Location = new System.Drawing.Point(454, 288);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Firts_Forms.Properties.Resources.birthday;
            this.pictureBox5.Location = new System.Drawing.Point(454, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Firts_Forms.Properties.Resources.documents;
            this.pictureBox4.Location = new System.Drawing.Point(454, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Firts_Forms.Properties.Resources.phone;
            this.pictureBox3.Location = new System.Drawing.Point(31, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // PlaceField
            // 
            this.PlaceField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceField.Location = new System.Drawing.Point(542, 301);
            this.PlaceField.Multiline = true;
            this.PlaceField.Name = "PlaceField";
            this.PlaceField.Size = new System.Drawing.Size(242, 51);
            this.PlaceField.TabIndex = 9;
            this.PlaceField.Enter += new System.EventHandler(this.PlaceField_Enter);
            this.PlaceField.Leave += new System.EventHandler(this.PlaceField_Leave);
            // 
            // numberField
            // 
            this.numberField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberField.Location = new System.Drawing.Point(113, 301);
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(242, 44);
            this.numberField.TabIndex = 8;
            this.numberField.Enter += new System.EventHandler(this.numberField_Enter);
            this.numberField.Leave += new System.EventHandler(this.numberField_Leave);
            // 
            // BrField
            // 
            this.BrField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrField.Location = new System.Drawing.Point(542, 223);
            this.BrField.Multiline = true;
            this.BrField.Name = "BrField";
            this.BrField.Size = new System.Drawing.Size(242, 51);
            this.BrField.TabIndex = 7;
            this.BrField.Enter += new System.EventHandler(this.BrField_Enter);
            this.BrField.Leave += new System.EventHandler(this.BrField_Leave);
            // 
            // FioField
            // 
            this.FioField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FioField.Location = new System.Drawing.Point(542, 142);
            this.FioField.Multiline = true;
            this.FioField.Name = "FioField";
            this.FioField.Size = new System.Drawing.Size(242, 51);
            this.FioField.TabIndex = 6;
            this.FioField.Enter += new System.EventHandler(this.FioField_Enter);
            this.FioField.Leave += new System.EventHandler(this.FioField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(191)))), ((int)(((byte)(195)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(208)))), ((int)(((byte)(58)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(92)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(259, 394);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(270, 55);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(113, 223);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(242, 44);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Firts_Forms.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(31, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(113, 142);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(242, 51);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Firts_Forms.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(31, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Controls.Add(this.mainPannel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 80);
            this.panel3.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(81)))), ((int)(((byte)(172)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(775, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter_1);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave_1);
            // 
            // mainPannel
            // 
            this.mainPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(81)))), ((int)(((byte)(172)))));
            this.mainPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPannel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.mainPannel.Location = new System.Drawing.Point(0, 0);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(799, 80);
            this.mainPannel.TabIndex = 0;
            this.mainPannel.Text = "Регистрация";
            this.mainPannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPannel_MouseDown);
            this.mainPannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPannel_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 497);
            this.Controls.Add(this.mainPannel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.mainPannel2.ResumeLayout(false);
            this.mainPannel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPannel2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label mainPannel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox PlaceField;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.TextBox BrField;
        private System.Windows.Forms.TextBox FioField;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label RegLabel;
    }
}