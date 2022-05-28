namespace WaterTankApp.Controls
{
	partial class MasterControl
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
            this.StartButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.TanksPanel = new System.Windows.Forms.Panel();
            this.Tank2Panel = new WaterTankApp.Controls.WaterTankPanel();
            this.Tank3Panel = new WaterTankApp.Controls.WaterTankPanel();
            this.Tank1Panel = new WaterTankApp.Controls.WaterTankPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TanksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(4, 5);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(4, 48);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(143, 549);
            this.LogTextBox.TabIndex = 1;
            // 
            // TanksPanel
            // 
            this.TanksPanel.BackgroundImage = global::WaterTankApp.Properties.Resources.Workarea;
            this.TanksPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TanksPanel.Controls.Add(this.label11);
            this.TanksPanel.Controls.Add(this.label10);
            this.TanksPanel.Controls.Add(this.label9);
            this.TanksPanel.Controls.Add(this.label8);
            this.TanksPanel.Controls.Add(this.label7);
            this.TanksPanel.Controls.Add(this.label6);
            this.TanksPanel.Controls.Add(this.label5);
            this.TanksPanel.Controls.Add(this.label4);
            this.TanksPanel.Controls.Add(this.label3);
            this.TanksPanel.Controls.Add(this.label2);
            this.TanksPanel.Controls.Add(this.label1);
            this.TanksPanel.Controls.Add(this.Tank2Panel);
            this.TanksPanel.Controls.Add(this.Tank3Panel);
            this.TanksPanel.Controls.Add(this.Tank1Panel);
            this.TanksPanel.Location = new System.Drawing.Point(156, 5);
            this.TanksPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TanksPanel.Name = "TanksPanel";
            this.TanksPanel.Size = new System.Drawing.Size(645, 596);
            this.TanksPanel.TabIndex = 2;
            // 
            // Tank2Panel
            // 
            this.Tank2Panel.Location = new System.Drawing.Point(288, 234);
            this.Tank2Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Tank2Panel.Name = "Tank2Panel";
            this.Tank2Panel.Size = new System.Drawing.Size(133, 160);
            this.Tank2Panel.TabIndex = 0;
            // 
            // Tank3Panel
            // 
            this.Tank3Panel.Location = new System.Drawing.Point(288, 432);
            this.Tank3Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Tank3Panel.Name = "Tank3Panel";
            this.Tank3Panel.Size = new System.Drawing.Size(133, 160);
            this.Tank3Panel.TabIndex = 0;
            // 
            // Tank1Panel
            // 
            this.Tank1Panel.Location = new System.Drawing.Point(288, 43);
            this.Tank1Panel.Margin = new System.Windows.Forms.Padding(5);
            this.Tank1Panel.Name = "Tank1Panel";
            this.Tank1Panel.Size = new System.Drawing.Size(133, 160);
            this.Tank1Panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Потребитель 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Потребитель 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Потребитель 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кст1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кст2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Кст3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(213, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Кпр1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(213, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Кпр2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(213, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Кпр3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Входная магистраль";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Повысительный насос";
            // 
            // MasterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.TanksPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MasterControl";
            this.Size = new System.Drawing.Size(813, 603);
            this.TanksPanel.ResumeLayout(false);
            this.TanksPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.TextBox LogTextBox;
		private System.Windows.Forms.Panel TanksPanel;
		private WaterTankPanel Tank1Panel;
		private WaterTankPanel Tank2Panel;
		private WaterTankPanel Tank3Panel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
