namespace WaterTankApp.Controls
{
	partial class WaterTankPanel
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.LevelProgressBar = new WaterTankApp.Controls.VerticalProgressBar();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(21, 4);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(59, 16);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "<Name>";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(3, 100);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(94, 29);
			this.StartButton.TabIndex = 1;
			this.StartButton.Text = "Старт";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// LevelProgressBar
			// 
			this.LevelProgressBar.Location = new System.Drawing.Point(3, 23);
			this.LevelProgressBar.Maximum = 300;
			this.LevelProgressBar.Name = "LevelProgressBar";
			this.LevelProgressBar.Size = new System.Drawing.Size(94, 74);
			this.LevelProgressBar.Step = 1;
			this.LevelProgressBar.TabIndex = 2;
			// 
			// WaterTankPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.LevelProgressBar);
			this.Name = "WaterTankPanel";
			this.Size = new System.Drawing.Size(100, 130);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Button StartButton;
		private VerticalProgressBar LevelProgressBar;
	}
}
