using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WaterTankApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Classes.DataBaseAdapter dba = new Classes.DataBaseAdapter("user", "password", "database");

			for (int i = 0; i < 3; ++i)
			{
				var wts = new Classes.WaterTankSimulation(new Classes.WaterTank() {
					Name = String.Format("Бак №{0}", i + 1),
					Yz = 1.0,
					Precision = 0.1
				});
				
				TabPage tp = new TabPage(wts.Tank.Name);
				tp.Controls.Add(new Controls.WaterTankControl(wts) { Dock = DockStyle.Fill });

				MainTabControl.TabPages.Add(tp);
				Master.AddSimulation(wts);
				dba.AddSimulation(wts);
			}			
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
