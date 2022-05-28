using System;
using System.Threading;

namespace WaterTankApp.Classes
{
	class WaterTankSimulation
	{
		public WaterTankSimulation(WaterTank tank, int points = 8000)
		{
			Tank = tank;
			Points = points;
		}

		public enum Result { Success, Canceled }

		public WaterTank Tank { get; private set; }
		public int Points { get; private set; }
		public bool IsWork { get { return work; } }

		public void Run()
		{
			if (!work)
			{
				work = true;
				new Thread(Calculation)
				{
					Name = String.Format("Calculating simulation for tank \"{0}\" thread", Tank.Name),
					Priority = ThreadPriority.BelowNormal,
					IsBackground = true
				}.Start();
			}
		}

		public void Stop()
		{
			work = false;
		}

		public event Action SimulationStart;
		public event Action<Result> SimulationDone;
		public event Action<double, double> PointCalculated;
		public event Action TankFilled;

		private void Calculation()
		{
			if (SimulationStart != null)
				SimulationStart();

			int count = 0;
			bool filled = false;
			for (int t = 0; work && t < Points; t += 10)
			{
				Tank.Level = Laplace.H(t);
				count = Tank.IsEqualToGiven ? count + 1 : 0;
				filled = count == 50 && !filled;

				if (filled && TankFilled != null)
					TankFilled();
				if (PointCalculated != null)
					PointCalculated(t, Tank.Level);
				Thread.Sleep(20);
			}

			if (SimulationDone != null)
				SimulationDone(work ? Result.Success : Result.Canceled);
			work = false;
		}

		private bool work = false;
	}
}
