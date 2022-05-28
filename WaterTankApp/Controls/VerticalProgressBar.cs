﻿using System;
using System.Windows.Forms;

namespace WaterTankApp.Controls
{
	class VerticalProgressBar : ProgressBar
	{
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.Style |= 0x04;
				return cp;
			}
		}
	}
}
