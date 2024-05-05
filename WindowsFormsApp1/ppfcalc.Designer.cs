namespace WindowsFormsApp1
{
    partial class ppfcalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ppfcalc));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.investedaount = new System.Windows.Forms.Label();
            this.maturity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Interestearned = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.TextBox();
            this.Lamount = new System.Windows.Forms.TextBox();
            this.Interest = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 22.6506F;
            legend1.Position.Width = 13.86861F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend1.TextWrapThreshold = 50;
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(554, 28);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Loan";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(384, 358);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(143, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Maturity Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(147, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Total Interest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(133, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Invested Amount";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(314, 95);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Minimum = 15;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(144, 45);
            this.trackBar3.TabIndex = 31;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Value = 15;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(314, 58);
            this.trackBar2.Maximum = 150000;
            this.trackBar2.Minimum = 500;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(144, 45);
            this.trackBar2.TabIndex = 30;
            this.trackBar2.TickFrequency = 25000;
            this.trackBar2.Value = 500;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // investedaount
            // 
            this.investedaount.AutoSize = true;
            this.investedaount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investedaount.ForeColor = System.Drawing.Color.Goldenrod;
            this.investedaount.Location = new System.Drawing.Point(171, 293);
            this.investedaount.Name = "investedaount";
            this.investedaount.Size = new System.Drawing.Size(54, 26);
            this.investedaount.TabIndex = 28;
            this.investedaount.Text = "EMI";
            // 
            // maturity
            // 
            this.maturity.AutoSize = true;
            this.maturity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maturity.ForeColor = System.Drawing.Color.Goldenrod;
            this.maturity.Location = new System.Drawing.Point(123, 463);
            this.maturity.Name = "maturity";
            this.maturity.Size = new System.Drawing.Size(150, 26);
            this.maturity.TabIndex = 23;
            this.maturity.Text = "Total amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(21, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Rate of Interst";
            // 
            // Interestearned
            // 
            this.Interestearned.AutoSize = true;
            this.Interestearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interestearned.ForeColor = System.Drawing.Color.Goldenrod;
            this.Interestearned.Location = new System.Drawing.Point(152, 370);
            this.Interestearned.Name = "Interestearned";
            this.Interestearned.Size = new System.Drawing.Size(92, 26);
            this.Interestearned.TabIndex = 24;
            this.Interestearned.Text = "Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(21, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Time Period (in Years.)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(21, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Yearly Investment";
            // 
            // Duration
            // 
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(192, 98);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(100, 26);
            this.Duration.TabIndex = 2;
            this.Duration.Text = "15";
            this.toolTip1.SetToolTip(this.Duration, "Our policy can only allow for a maximum of 50 years.");
            this.Duration.TextChanged += new System.EventHandler(this.Duration_TextChanged);
            // 
            // Lamount
            // 
            this.Lamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lamount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lamount.Location = new System.Drawing.Point(192, 63);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(100, 26);
            this.Lamount.TabIndex = 1;
            this.Lamount.Text = "500";
            this.toolTip1.SetToolTip(this.Lamount, "We only allow for a maximum of 1,50,000.");
            this.Lamount.TextChanged += new System.EventHandler(this.Lamount_TextChanged);
            // 
            // Interest
            // 
            this.Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interest.Location = new System.Drawing.Point(192, 133);
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            this.Interest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Interest.Size = new System.Drawing.Size(100, 26);
            this.Interest.TabIndex = 3;
            this.Interest.Text = "7.1%";
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calculate.BackColor = System.Drawing.Color.Black;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.Goldenrod;
            this.Calculate.Location = new System.Drawing.Point(137, 184);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(113, 36);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Tip";
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Apply.BackColor = System.Drawing.Color.Black;
            this.Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply.Location = new System.Drawing.Point(257, 184);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(77, 36);
            this.Apply.TabIndex = 35;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ppfcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.investedaount);
            this.Controls.Add(this.maturity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Interestearned);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Lamount);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ppfcalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPF Calculator";
            this.Load += new System.EventHandler(this.ppfcalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label investedaount;
        private System.Windows.Forms.Label maturity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Interestearned;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox Lamount;
        private System.Windows.Forms.TextBox Interest;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Apply;
    }
}