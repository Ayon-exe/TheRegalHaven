namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.Button();
            this.withdrawTb = new System.Windows.Forms.TextBox();
            this.depositTb = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.toTb = new System.Windows.Forms.TextBox();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.commentTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.mydetails = new System.Windows.Forms.Button();
            this.Loan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sip = new System.Windows.Forms.Button();
            this.ppf = new System.Windows.Forms.Button();
            this.rd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(85, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // withdraw
            // 
            this.withdraw.AutoSize = true;
            this.withdraw.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.withdraw.BackColor = System.Drawing.Color.Black;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.Goldenrod;
            this.withdraw.Location = new System.Drawing.Point(118, 232);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(123, 39);
            this.withdraw.TabIndex = 4;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // withdrawTb
            // 
            this.withdrawTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawTb.Location = new System.Drawing.Point(247, 241);
            this.withdrawTb.Name = "withdrawTb";
            this.withdrawTb.Size = new System.Drawing.Size(100, 26);
            this.withdrawTb.TabIndex = 3;
            this.toolTip1.SetToolTip(this.withdrawTb, "The minimum balance for this account is  ₹200");
            // 
            // depositTb
            // 
            this.depositTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositTb.Location = new System.Drawing.Point(247, 284);
            this.depositTb.Name = "depositTb";
            this.depositTb.Size = new System.Drawing.Size(100, 26);
            this.depositTb.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(76, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Account number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(73, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Goldenrod;
            this.update.Location = new System.Drawing.Point(353, 146);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(101, 39);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Transfer.BackColor = System.Drawing.Color.Black;
            this.Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer.ForeColor = System.Drawing.Color.Goldenrod;
            this.Transfer.Location = new System.Drawing.Point(298, 463);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(113, 39);
            this.Transfer.TabIndex = 10;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // toTb
            // 
            this.toTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTb.Location = new System.Drawing.Point(178, 412);
            this.toTb.Name = "toTb";
            this.toTb.Size = new System.Drawing.Size(100, 26);
            this.toTb.TabIndex = 7;
            // 
            // amountTb
            // 
            this.amountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTb.Location = new System.Drawing.Point(178, 444);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(100, 26);
            this.amountTb.TabIndex = 8;
            // 
            // commentTb
            // 
            this.commentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentTb.Location = new System.Drawing.Point(178, 476);
            this.commentTb.Name = "commentTb";
            this.commentTb.Size = new System.Drawing.Size(100, 26);
            this.commentTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(136, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(98, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(77, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Comments";
            // 
            // transactions
            // 
            this.transactions.BackColor = System.Drawing.Color.Black;
            this.transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactions.ForeColor = System.Drawing.Color.Goldenrod;
            this.transactions.Location = new System.Drawing.Point(659, 363);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(113, 58);
            this.transactions.TabIndex = 11;
            this.transactions.Text = "Account Statement";
            this.transactions.UseVisualStyleBackColor = false;
            this.transactions.Click += new System.EventHandler(this.transactions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(199, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Valuefrombalance";
            // 
            // deposit
            // 
            this.deposit.AutoSize = true;
            this.deposit.BackColor = System.Drawing.Color.Black;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.Goldenrod;
            this.deposit.Location = new System.Drawing.Point(118, 275);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(123, 39);
            this.deposit.TabIndex = 6;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout.BackColor = System.Drawing.Color.Black;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Goldenrod;
            this.Logout.Location = new System.Drawing.Point(850, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(88, 36);
            this.Logout.TabIndex = 18;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // mydetails
            // 
            this.mydetails.AutoSize = true;
            this.mydetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mydetails.BackColor = System.Drawing.Color.Black;
            this.mydetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mydetails.ForeColor = System.Drawing.Color.Goldenrod;
            this.mydetails.Location = new System.Drawing.Point(709, 191);
            this.mydetails.Name = "mydetails";
            this.mydetails.Size = new System.Drawing.Size(124, 36);
            this.mydetails.TabIndex = 17;
            this.mydetails.Text = "My Details";
            this.mydetails.UseVisualStyleBackColor = false;
            this.mydetails.Click += new System.EventHandler(this.mydetails_Click);
            // 
            // Loan
            // 
            this.Loan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Loan.BackColor = System.Drawing.Color.Black;
            this.Loan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loan.ForeColor = System.Drawing.Color.Goldenrod;
            this.Loan.Location = new System.Drawing.Point(659, 235);
            this.Loan.Name = "Loan";
            this.Loan.Size = new System.Drawing.Size(113, 58);
            this.Loan.TabIndex = 12;
            this.Loan.Text = "Loan";
            this.Loan.UseVisualStyleBackColor = false;
            this.Loan.Click += new System.EventHandler(this.Loan_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(659, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "Fixed Deposits";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // sip
            // 
            this.sip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sip.BackColor = System.Drawing.Color.Black;
            this.sip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sip.ForeColor = System.Drawing.Color.Goldenrod;
            this.sip.Location = new System.Drawing.Point(778, 235);
            this.sip.Name = "sip";
            this.sip.Size = new System.Drawing.Size(113, 58);
            this.sip.TabIndex = 13;
            this.sip.Text = "SIP";
            this.sip.UseVisualStyleBackColor = false;
            this.sip.Click += new System.EventHandler(this.sip_Click);
            // 
            // ppf
            // 
            this.ppf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ppf.BackColor = System.Drawing.Color.Black;
            this.ppf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppf.ForeColor = System.Drawing.Color.Goldenrod;
            this.ppf.Location = new System.Drawing.Point(778, 299);
            this.ppf.Name = "ppf";
            this.ppf.Size = new System.Drawing.Size(113, 58);
            this.ppf.TabIndex = 15;
            this.ppf.Text = "PPF";
            this.ppf.UseVisualStyleBackColor = false;
            this.ppf.Click += new System.EventHandler(this.ppf_Click);
            // 
            // rd
            // 
            this.rd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rd.BackColor = System.Drawing.Color.Black;
            this.rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd.ForeColor = System.Drawing.Color.Goldenrod;
            this.rd.Location = new System.Drawing.Point(778, 363);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(113, 58);
            this.rd.TabIndex = 16;
            this.rd.Text = "Recurring Deposits";
            this.rd.UseVisualStyleBackColor = false;
            this.rd.Click += new System.EventHandler(this.rd_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.rd);
            this.Controls.Add(this.ppf);
            this.Controls.Add(this.sip);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Loan);
            this.Controls.Add(this.mydetails);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commentTb);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.toTb);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.depositTb);
            this.Controls.Add(this.withdrawTb);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.TextBox withdrawTb;
        private System.Windows.Forms.TextBox depositTb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.TextBox toTb;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.TextBox commentTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button transactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button mydetails;
        private System.Windows.Forms.Button Loan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button sip;
        private System.Windows.Forms.Button ppf;
        private System.Windows.Forms.Button rd;
    }
}