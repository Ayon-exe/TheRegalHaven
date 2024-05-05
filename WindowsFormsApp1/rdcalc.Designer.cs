namespace WindowsFormsApp1
{
    partial class rdcalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rdcalc));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.investedamount = new System.Windows.Forms.Label();
            this.Tvalue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.estreturns = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 22.6506F;
            legend2.Position.Width = 13.86861F;
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend2.TextWrapThreshold = 50;
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleForeColor = System.Drawing.Color.White;
            legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            legend2.TitleSeparatorColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(554, 28);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Loan";
            this.chart1.Series.Add(series2);
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
            this.label6.Location = new System.Drawing.Point(123, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(118, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Est. Returns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(102, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Invested Amount";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(319, 157);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 29;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(319, 119);
            this.trackBar3.Maximum = 15;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(144, 45);
            this.trackBar3.TabIndex = 31;
            this.trackBar3.TickFrequency = 2;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(319, 82);
            this.trackBar2.Maximum = 200000;
            this.trackBar2.Minimum = 500;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(144, 45);
            this.trackBar2.TabIndex = 30;
            this.trackBar2.TickFrequency = 20000;
            this.trackBar2.Value = 500;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // investedamount
            // 
            this.investedamount.AutoSize = true;
            this.investedamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investedamount.ForeColor = System.Drawing.Color.Goldenrod;
            this.investedamount.Location = new System.Drawing.Point(140, 301);
            this.investedamount.Name = "investedamount";
            this.investedamount.Size = new System.Drawing.Size(54, 26);
            this.investedamount.TabIndex = 28;
            this.investedamount.Text = "EMI";
            // 
            // Tvalue
            // 
            this.Tvalue.AutoSize = true;
            this.Tvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tvalue.ForeColor = System.Drawing.Color.Goldenrod;
            this.Tvalue.Location = new System.Drawing.Point(92, 471);
            this.Tvalue.Name = "Tvalue";
            this.Tvalue.Size = new System.Drawing.Size(150, 26);
            this.Tvalue.TabIndex = 23;
            this.Tvalue.Text = "Total amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(19, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Time Period (in Years.)";
            // 
            // estreturns
            // 
            this.estreturns.AutoSize = true;
            this.estreturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estreturns.ForeColor = System.Drawing.Color.Goldenrod;
            this.estreturns.Location = new System.Drawing.Point(121, 378);
            this.estreturns.Name = "estreturns";
            this.estreturns.Size = new System.Drawing.Size(92, 26);
            this.estreturns.TabIndex = 24;
            this.estreturns.Text = "Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(19, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Rate of Interst (p.a)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(19, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Monthly Investment";
            // 
            // Duration
            // 
            this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(197, 151);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(100, 26);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "1";
            this.toolTip1.SetToolTip(this.Duration, "We allow for a maximum of 10 years.");
            this.Duration.TextChanged += new System.EventHandler(this.Duration_TextChanged);
            // 
            // Lamount
            // 
            this.Lamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lamount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lamount.Location = new System.Drawing.Point(197, 87);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(100, 26);
            this.Lamount.TabIndex = 1;
            this.Lamount.Text = "500";
            this.toolTip1.SetToolTip(this.Lamount, "We can only allow a maximum of ₹2,00,000.");
            this.Lamount.TextChanged += new System.EventHandler(this.Lamount_TextChanged);
            // 
            // Interest
            // 
            this.Interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interest.Location = new System.Drawing.Point(197, 119);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(100, 26);
            this.Interest.TabIndex = 2;
            this.Interest.Text = "1";
            this.toolTip1.SetToolTip(this.Interest, "Our policies allow us for a maximum of 15%.");
            this.Interest.TextChanged += new System.EventHandler(this.Interest_TextChanged);
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calculate.BackColor = System.Drawing.Color.Black;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.Goldenrod;
            this.Calculate.Location = new System.Drawing.Point(106, 212);
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
            this.Apply.Location = new System.Drawing.Point(226, 212);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(77, 36);
            this.Apply.TabIndex = 35;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // rdcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.investedamount);
            this.Controls.Add(this.Tvalue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.estreturns);
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
            this.Name = "rdcalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RD Calculator";
            this.Load += new System.EventHandler(this.rdcalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label investedamount;
        private System.Windows.Forms.Label Tvalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label estreturns;
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