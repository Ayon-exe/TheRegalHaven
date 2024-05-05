namespace WindowsFormsApp1
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label3 = new System.Windows.Forms.Label();
            this.addTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailTb = new System.Windows.Forms.TextBox();
            this.rnameTb = new System.Windows.Forms.TextBox();
            this.register1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rPassTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rCpassTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rPhTb = new System.Windows.Forms.TextBox();
            this.FemaleRb = new System.Windows.Forms.RadioButton();
            this.MaleRb = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTb = new System.Windows.Forms.DateTimePicker();
            this.reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.UserTb = new System.Windows.Forms.TextBox();
            this.backBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addTb
            // 
            this.addTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTb.Location = new System.Drawing.Point(169, 98);
            this.addTb.Name = "addTb";
            this.addTb.Size = new System.Drawing.Size(148, 20);
            this.addTb.TabIndex = 4;
            this.addTb.TextChanged += new System.EventHandler(this.addTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mailTb
            // 
            this.mailTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTb.Location = new System.Drawing.Point(169, 173);
            this.mailTb.Name = "mailTb";
            this.mailTb.Size = new System.Drawing.Size(148, 20);
            this.mailTb.TabIndex = 8;
            this.mailTb.TextChanged += new System.EventHandler(this.mailTb_TextChanged);
            // 
            // rnameTb
            // 
            this.rnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rnameTb.Location = new System.Drawing.Point(169, 48);
            this.rnameTb.Name = "rnameTb";
            this.rnameTb.Size = new System.Drawing.Size(148, 20);
            this.rnameTb.TabIndex = 2;
            // 
            // register1
            // 
            this.register1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register1.BackColor = System.Drawing.Color.Black;
            this.register1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register1.ForeColor = System.Drawing.Color.Goldenrod;
            this.register1.Location = new System.Drawing.Point(178, 251);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(139, 61);
            this.register1.TabIndex = 12;
            this.register1.Text = "Register";
            this.register1.UseVisualStyleBackColor = false;
            this.register1.Click += new System.EventHandler(this.register1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date of Birth";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rPassTb
            // 
            this.rPassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPassTb.Location = new System.Drawing.Point(169, 198);
            this.rPassTb.Name = "rPassTb";
            this.rPassTb.PasswordChar = '*';
            this.rPassTb.Size = new System.Drawing.Size(148, 20);
            this.rPassTb.TabIndex = 9;
            this.toolTip1.SetToolTip(this.rPassTb, "Password needs to be more than 3 characters.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(11, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Confirm Password";
            // 
            // rCpassTb
            // 
            this.rCpassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rCpassTb.Location = new System.Drawing.Point(169, 223);
            this.rCpassTb.Name = "rCpassTb";
            this.rCpassTb.PasswordChar = '*';
            this.rCpassTb.Size = new System.Drawing.Size(148, 20);
            this.rCpassTb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phone Number";
            // 
            // rPhTb
            // 
            this.rPhTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPhTb.Location = new System.Drawing.Point(169, 73);
            this.rPhTb.Name = "rPhTb";
            this.rPhTb.Size = new System.Drawing.Size(148, 20);
            this.rPhTb.TabIndex = 3;
            // 
            // FemaleRb
            // 
            this.FemaleRb.AutoSize = true;
            this.FemaleRb.BackColor = System.Drawing.Color.Transparent;
            this.FemaleRb.ForeColor = System.Drawing.Color.Goldenrod;
            this.FemaleRb.Location = new System.Drawing.Point(258, 150);
            this.FemaleRb.Name = "FemaleRb";
            this.FemaleRb.Size = new System.Drawing.Size(59, 17);
            this.FemaleRb.TabIndex = 7;
            this.FemaleRb.TabStop = true;
            this.FemaleRb.Text = "Female";
            this.FemaleRb.UseVisualStyleBackColor = false;
            this.FemaleRb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // MaleRb
            // 
            this.MaleRb.AutoSize = true;
            this.MaleRb.BackColor = System.Drawing.Color.Transparent;
            this.MaleRb.ForeColor = System.Drawing.Color.Goldenrod;
            this.MaleRb.Location = new System.Drawing.Point(169, 150);
            this.MaleRb.Name = "MaleRb";
            this.MaleRb.Size = new System.Drawing.Size(48, 17);
            this.MaleRb.TabIndex = 6;
            this.MaleRb.TabStop = true;
            this.MaleRb.Text = "Male";
            this.MaleRb.UseVisualStyleBackColor = false;
            this.MaleRb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(11, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Gender";
            // 
            // dateTb
            // 
            this.dateTb.CustomFormat = "dd/MM/yyyy";
            this.dateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTb.Location = new System.Drawing.Point(169, 123);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(148, 23);
            this.dateTb.TabIndex = 5;
            this.dateTb.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            // 
            // reset
            // 
            this.reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reset.BackColor = System.Drawing.Color.Black;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.Goldenrod;
            this.reset.Location = new System.Drawing.Point(15, 251);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(139, 61);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(11, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Username";
            // 
            // UserTb
            // 
            this.UserTb.Location = new System.Drawing.Point(169, 23);
            this.UserTb.Name = "UserTb";
            this.UserTb.Size = new System.Drawing.Size(148, 20);
            this.UserTb.TabIndex = 1;
            // 
            // backBox1
            // 
            this.backBox1.Image = ((System.Drawing.Image)(resources.GetObject("backBox1.Image")));
            this.backBox1.Location = new System.Drawing.Point(12, 12);
            this.backBox1.Name = "backBox1";
            this.backBox1.Size = new System.Drawing.Size(65, 30);
            this.backBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBox1.TabIndex = 33;
            this.backBox1.TabStop = false;
            this.backBox1.Click += new System.EventHandler(this.backBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.register1);
            this.groupBox1.Controls.Add(this.rnameTb);
            this.groupBox1.Controls.Add(this.UserTb);
            this.groupBox1.Controls.Add(this.mailTb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTb);
            this.groupBox1.Controls.Add(this.addTb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FemaleRb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MaleRb);
            this.groupBox1.Controls.Add(this.rPassTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rPhTb);
            this.groupBox1.Controls.Add(this.rCpassTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(286, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 334);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(281, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Please Enter The Following Details.";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailTb;
        private System.Windows.Forms.TextBox rnameTb;
        private System.Windows.Forms.Button register1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rPassTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rCpassTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rPhTb;
        private System.Windows.Forms.RadioButton FemaleRb;
        private System.Windows.Forms.RadioButton MaleRb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTb;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.PictureBox backBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}