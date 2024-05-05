namespace Gold_s_Gym
{
    partial class Equipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipments));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            equipment_box = new TextBox();
            richTextBox1 = new RichTextBox();
            customer_mobile_box = new TextBox();
            save_btn = new Button();
            reset_btn = new Button();
            view_btn = new Button();
            customer_box = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(589, 408);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 28;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(589, 704);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 29;
            label2.Text = "Customer Mobile";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(589, 481);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 30;
            label3.Text = "Address";
            // 
            // equipment_box
            // 
            equipment_box.Location = new Point(801, 409);
            equipment_box.Name = "equipment_box";
            equipment_box.Size = new Size(298, 27);
            equipment_box.TabIndex = 33;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(801, 482);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(303, 171);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = "";
            // 
            // customer_mobile_box
            // 
            customer_mobile_box.Location = new Point(801, 704);
            customer_mobile_box.Name = "customer_mobile_box";
            customer_mobile_box.Size = new Size(298, 27);
            customer_mobile_box.TabIndex = 35;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.FromArgb(255, 128, 128);
            save_btn.Cursor = Cursors.Hand;
            save_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            save_btn.ForeColor = SystemColors.InactiveCaptionText;
            save_btn.Location = new Point(689, 819);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(176, 44);
            save_btn.TabIndex = 38;
            save_btn.Text = "Order And Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(128, 255, 128);
            reset_btn.Cursor = Cursors.Hand;
            reset_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            reset_btn.ForeColor = SystemColors.InactiveCaptionText;
            reset_btn.Location = new Point(886, 819);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(119, 44);
            reset_btn.TabIndex = 39;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // view_btn
            // 
            view_btn.BackColor = SystemColors.ActiveCaption;
            view_btn.Cursor = Cursors.Hand;
            view_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            view_btn.ForeColor = SystemColors.InactiveCaptionText;
            view_btn.Location = new Point(1022, 819);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(171, 44);
            view_btn.TabIndex = 40;
            view_btn.Text = "View Equipments";
            view_btn.UseVisualStyleBackColor = false;
            view_btn.Click += view_btn_Click_1;
            // 
            // customer_box
            // 
            customer_box.Location = new Point(801, 335);
            customer_box.Name = "customer_box";
            customer_box.Size = new Size(298, 27);
            customer_box.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(589, 334);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 41;
            label6.Text = "Customer Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(854, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // Equipments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1815, 874);
            Controls.Add(pictureBox1);
            Controls.Add(customer_box);
            Controls.Add(label6);
            Controls.Add(view_btn);
            Controls.Add(reset_btn);
            Controls.Add(save_btn);
            Controls.Add(customer_mobile_box);
            Controls.Add(richTextBox1);
            Controls.Add(equipment_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.MenuHighlight;
            Name = "Equipments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Place Order";
            WindowState = FormWindowState.Maximized;
            Load += Equipments_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox equipment_box;
        private RichTextBox richTextBox1;
        private TextBox customer_mobile_box;
        private Button save_btn;
        private Button reset_btn;
        private Button view_btn;
        private TextBox customer_box;
        private Label label6;
        private Button order_view;
        private PictureBox pictureBox1;
    }
}