using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WaterTankApp.Classes
{
	class WaterTank : INotifyPropertyChanged
	{
		public string Name { get; set; }

		public double Level
		{
			get { return level; }
			set
			{
				level = value;
				OnPropertyChanged();
			}
		}

		public double Kokp { get; set; }
		public double Koks { get; set; }
		public double Yz { get; set; }
		public double Precision { get; set; }

		public bool IsEqualToGiven { get { return Math.Abs(Yz - Level) / Yz < Precision; } }

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string property = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(property));
		}

		private double level;
	}
}
