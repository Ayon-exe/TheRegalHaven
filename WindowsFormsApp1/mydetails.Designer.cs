namespace WindowsFormsApp1
{
    partial class mydetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mydetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newaccount = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.newaccount);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(262, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // newaccount
            // 
            this.newaccount.AutoSize = true;
            this.newaccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newaccount.BackColor = System.Drawing.Color.Black;
            this.newaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccount.Location = new System.Drawing.Point(159, 292);
            this.newaccount.Name = "newaccount";
            this.newaccount.Size = new System.Drawing.Size(222, 36);
            this.newaccount.TabIndex = 8;
            this.newaccount.Text = "Create New Account";
            this.newaccount.UseVisualStyleBackColor = false;
            this.newaccount.Click += new System.EventHandler(this.newaccount_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(24, 232);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(71, 20);
            this.gender.TabIndex = 7;
            this.gender.Text = "Gender: ";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(24, 202);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(123, 20);
            this.phone.TabIndex = 6;
            this.phone.Text = "Phone Number: ";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(24, 172);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(110, 20);
            this.dob.TabIndex = 5;
            this.dob.Text = "Date Of Birth: ";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(24, 142);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 20);
            this.address.TabIndex = 4;
            this.address.Text = "Address: ";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(25, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.Goldenrod;
            this.email.Location = new System.Drawing.Point(24, 112);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(56, 20);
            this.email.TabIndex = 2;
            this.email.Text = "Email: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.Color.Goldenrod;
            this.name.Location = new System.Drawing.Point(24, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name: ";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.Goldenrod;
            this.username.Location = new System.Drawing.Point(24, 52);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 0;
            this.username.Text = "Username: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mydetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mydetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Details";
            this.Load += new System.EventHandler(this.mydetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button newaccount;
    }
}