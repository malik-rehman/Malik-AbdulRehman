namespace Gold_s_Gym
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            login_btn = new Button();
            password_box = new TextBox();
            name_box = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(731, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.IndianRed;
            login_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(772, 726);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(211, 42);
            login_btn.TabIndex = 44;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click_1;
            // 
            // password_box
            // 
            password_box.BackColor = Color.FromArgb(128, 255, 128);
            password_box.Location = new Point(650, 651);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(431, 27);
            password_box.TabIndex = 42;
            // 
            // name_box
            // 
            name_box.BackColor = Color.FromArgb(128, 255, 128);
            name_box.Location = new Point(650, 559);
            name_box.Name = "name_box";
            name_box.Size = new Size(431, 27);
            name_box.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(650, 610);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 40;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(650, 518);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 39;
            label2.Text = "User Name";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1507, 779);
            Controls.Add(login_btn);
            Controls.Add(password_box);
            Controls.Add(name_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button login_btn;
        private TextBox password_box;
        private TextBox name_box;
        private Label label3;
        private Label label2;
    }
}