using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterTankApp.Controls
{
	partial class WaterTankPanel : UserControl
	{
		public WaterTankPanel()
		{
			InitializeComponent();
		}

		public void SetSimulation(Classes.WaterTankSimulation wts)
		{
			NameLabel.Text = wts.Tank.Name;

			wts.PointCalculated += (t, v) => { SetLevel(v); };
			wts.SimulationStart += delegate { SetButtonText("Стоп"); };
			wts.SimulationDone += delegate { SetButtonText("Старт"); };

			StartButton.Click += delegate
			{
				if (wts.IsWork)
					wts.Stop();
				else
					wts.Run();
			};
		}

		private void SetLevel(double level)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<double>(SetLevel), level);
				return;
			}
			LevelProgressBar.Value = (int)(level + 100);
		}

		private void SetButtonText(string text)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(SetButtonText), text);
				return;
			}
			StartButton.Text = text;
		}
	}
}
