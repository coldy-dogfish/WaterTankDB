using System;
using System.Windows.Forms;

namespace WaterTankApp.Controls
{
	partial class WaterTankControl : UserControl
	{
		public WaterTankControl(Classes.WaterTankSimulation wts)
		{
			InitializeComponent();

			NameLabel.Text = wts.Tank.Name;
			LevelSetter.Value = (decimal)wts.Tank.Yz;
			KokpSetter.Value = (decimal)wts.Tank.Kokp;
			KoksSetter.Value = (decimal)wts.Tank.Koks;

			wts.Tank.PropertyChanged += (s, e) =>
			{
				SetLevel((s as Classes.WaterTank).Level);
			};

			wts.SimulationStart += () =>
			{
				ProcessChart.BeginInvoke(new Action(() =>
					ProcessChart.Series[0].Points.Clear()));
				LevelProgressBar.BeginInvoke(new Action(() =>
					LevelProgressBar.Value = 0));
			};

			wts.PointCalculated += AddPoint;

			KokpSetter.ValueChanged += delegate { wts.Tank.Kokp = (double)KokpSetter.Value; };
			KoksSetter.ValueChanged += delegate { wts.Tank.Koks = (double)KoksSetter.Value; };
			LevelSetter.ValueChanged += delegate { wts.Tank.Yz = (double)LevelSetter.Value; };
		}
		private void AddPoint(double x, double y)
		{
			if (ProcessChart.InvokeRequired)
			{
				ProcessChart.Invoke(new Action<double, double>(AddPoint), x, y);
				return;
			}
			ProcessChart.Series[0].Points.AddXY(x, y);
		}

		private void SetLevel(double x)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new Action<double>(SetLevel), x);
				return;
			}
			LevelProgressBar.Value = (int)(x * 100);
			LevelLabel.Text = String.Format("Уровень, м:{0}{1:F1}", Environment.NewLine, x);
		}
	}
}
