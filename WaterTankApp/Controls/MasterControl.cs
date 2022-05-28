using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WaterTankApp.Controls
{
	partial class MasterControl : UserControl
	{
		public MasterControl()
		{
			InitializeComponent();

			tankPanels[0] = Tank1Panel;
			tankPanels[1] = Tank2Panel;
			tankPanels[2] = Tank3Panel;
		}

		public void AddSimulation(Classes.WaterTankSimulation wts)
		{
			tankPanels[simuls.Count].SetSimulation(wts);

			wts.SimulationStart += delegate
			{
				LogTankEvent(String.Format("{0} начал заполняться...", wts.Tank.Name));
				SetStartButtonText("Стоп");
			};

			wts.SimulationDone += (result) =>
			{
				string log = "";
				if (result == Classes.WaterTankSimulation.Result.Success)
					log = String.Format("Для {0} расчёт завершён.", wts.Tank.Name);
				else
					log = String.Format("Заполнение {0} отменено.", wts.Tank.Name);
				LogTankEvent(log);
				SetStartButtonText("Старт");
			};

			wts.TankFilled += delegate { LogTankEvent(String.Format("{0} заполнен!", wts.Tank.Name)); };

			simuls.Add(wts);
		}

		private void StartButtonClick(object sender, EventArgs e)
		{
			if (StartButton.Text == "Старт")
			{
				foreach (var sim in simuls)
					sim.Run();
			}
			else
			{
				foreach (var sim in simuls)
					sim.Stop();
			}
		}

		private void LogTankEvent(string ev)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(LogTankEvent), ev);
				return;
			}
			LogTextBox.Text += ev + Environment.NewLine;
		}

		private void SetStartButtonText(string text)
		{
			if (InvokeRequired)
			{
				Invoke(new Action<string>(SetStartButtonText), text);
				return;
			}
			StartButton.Text = text;
		}

		private List<Classes.WaterTankSimulation> simuls = new List<Classes.WaterTankSimulation>();
		private WaterTankPanel[] tankPanels = new WaterTankPanel[3];
	}
}
