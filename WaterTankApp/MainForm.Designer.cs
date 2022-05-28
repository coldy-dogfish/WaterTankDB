namespace WaterTankApp
{
	partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DispatcherTabPage = new System.Windows.Forms.TabPage();
            this.Master = new WaterTankApp.Controls.MasterControl();
            this.MainTabControl.SuspendLayout();
            this.DispatcherTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DispatcherTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(845, 667);
            this.MainTabControl.TabIndex = 0;
            // 
            // DispatcherTabPage
            // 
            this.DispatcherTabPage.Controls.Add(this.Master);
            this.DispatcherTabPage.Location = new System.Drawing.Point(4, 25);
            this.DispatcherTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DispatcherTabPage.Name = "DispatcherTabPage";
            this.DispatcherTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DispatcherTabPage.Size = new System.Drawing.Size(837, 638);
            this.DispatcherTabPage.TabIndex = 0;
            this.DispatcherTabPage.Text = "Диспетчер";
            this.DispatcherTabPage.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            this.Master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Master.Location = new System.Drawing.Point(4, 4);
            this.Master.Margin = new System.Windows.Forms.Padding(5);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(829, 630);
            this.Master.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 667);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Насосная станция участка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.DispatcherTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTabControl;
		private System.Windows.Forms.TabPage DispatcherTabPage;
		private Controls.MasterControl Master;
	}
}

