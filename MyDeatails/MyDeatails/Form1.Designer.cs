namespace MyDeatails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new ComboBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 30);
            label1.TabIndex = 0;
            label1.Text = "My Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 31);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(25, 139);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(22, 196);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 4;
            label5.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(22, 263);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // numericUpDown1
            // 
            numericUpDown1.FormattingEnabled = true;
            numericUpDown1.Location = new Point(124, 33);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(216, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 8;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(124, 194);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(216, 23);
            txtUser.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(124, 265);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(216, 23);
            txtPass.TabIndex = 10;
            txtPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Location = new Point(12, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 11;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(103, 312);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 12;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(195, 312);
            button3.Name = "button3";
            button3.Size = new Size(75, 44);
            button3.TabIndex = 13;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Location = new Point(285, 312);
            button4.Name = "button4";
            button4.Size = new Size(75, 44);
            button4.TabIndex = 14;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(378, 312);
            button5.Name = "button5";
            button5.Size = new Size(75, 44);
            button5.TabIndex = 15;
            button5.Text = "Deleate";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(650, 301);
            dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(786, 463);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox numericUpDown1;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
