namespace WaterTankApp.Controls
{
	partial class WaterTankControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.NameLabel = new System.Windows.Forms.Label();
			this.LevelSetter = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.KoksSetter = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.KokpSetter = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.ProcessChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.LevelProgressBar = new WaterTankApp.Controls.VerticalProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.LevelSetter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KoksSetter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.KokpSetter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProcessChart)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(64, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(83, 24);
			this.NameLabel.TabIndex = 7;
			this.NameLabel.Text = "<Name>";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LevelSetter
			// 
			this.LevelSetter.DecimalPlaces = 2;
			this.LevelSetter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LevelSetter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.LevelSetter.Location = new System.Drawing.Point(304, 51);
			this.LevelSetter.Name = "LevelSetter";
			this.LevelSetter.Size = new System.Drawing.Size(139, 23);
			this.LevelSetter.TabIndex = 15;
			this.LevelSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(304, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Заданный уровень, м:";
			// 
			// KoksSetter
			// 
			this.KoksSetter.DecimalPlaces = 1;
			this.KoksSetter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.KoksSetter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.KoksSetter.Location = new System.Drawing.Point(153, 51);
			this.KoksSetter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.KoksSetter.Name = "KoksSetter";
			this.KoksSetter.Size = new System.Drawing.Size(131, 23);
			this.KoksSetter.TabIndex = 13;
			this.KoksSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(153, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "К откр. кс, от 0 до 1:";
			// 
			// KokpSetter
			// 
			this.KokpSetter.DecimalPlaces = 1;
			this.KokpSetter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.KokpSetter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.KokpSetter.Location = new System.Drawing.Point(4, 51);
			this.KokpSetter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.KokpSetter.Name = "KokpSetter";
			this.KokpSetter.Size = new System.Drawing.Size(132, 23);
			this.KokpSetter.TabIndex = 10;
			this.KokpSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "К откр. кп, от 0 до 1:";
			// 
			// LevelLabel
			// 
			this.LevelLabel.AutoSize = true;
			this.LevelLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LevelLabel.Location = new System.Drawing.Point(23, 107);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Size = new System.Drawing.Size(78, 32);
			this.LevelLabel.TabIndex = 16;
			this.LevelLabel.Text = "Уровень, м:\r\n{0}";
			this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProcessChart
			// 
			chartArea1.AxisX.Title = "Время, с";
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.AxisY.Title = "Уровень, м";
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea1.Name = "LevelChartArea";
			this.ProcessChart.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "LevelLegend";
			this.ProcessChart.Legends.Add(legend1);
			this.ProcessChart.Location = new System.Drawing.Point(134, 143);
			this.ProcessChart.Name = "ProcessChart";
			series1.ChartArea = "LevelChartArea";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "LevelLegend";
			series1.Name = "LevelSeries";
			this.ProcessChart.Series.Add(series1);
			this.ProcessChart.Size = new System.Drawing.Size(463, 254);
			this.ProcessChart.TabIndex = 11;
			this.ProcessChart.Text = "График переходного процесса";
			title1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title1.Name = "ProcessTitle";
			title1.Text = "График переходной функции";
			this.ProcessChart.Titles.Add(title1);
			// 
			// LevelProgressBar
			// 
			this.LevelProgressBar.Location = new System.Drawing.Point(26, 163);
			this.LevelProgressBar.Maximum = 300;
			this.LevelProgressBar.Name = "LevelProgressBar";
			this.LevelProgressBar.Size = new System.Drawing.Size(75, 198);
			this.LevelProgressBar.TabIndex = 9;
			// 
			// WaterTankControlFree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.LevelSetter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.KoksSetter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.KokpSetter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LevelLabel);
			this.Controls.Add(this.LevelProgressBar);
			this.Controls.Add(this.ProcessChart);
			this.Name = "WaterTankControlFree";
			this.Size = new System.Drawing.Size(600, 400);
			((System.ComponentModel.ISupportInitialize)(this.LevelSetter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KoksSetter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.KokpSetter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProcessChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.NumericUpDown LevelSetter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown KoksSetter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown KokpSetter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LevelLabel;
		private VerticalProgressBar LevelProgressBar;
		private System.Windows.Forms.DataVisualization.Charting.Chart ProcessChart;
	}
}
