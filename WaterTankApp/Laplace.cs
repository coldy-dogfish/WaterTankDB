using System;

namespace WaterTankApp
{
	static class Laplace
	{
		public static double HF(double t)
		{
			return af1 * Math.Exp(b1 * t) + af2 * Math.Exp(b2 * t) +
				af3 * Math.Cos(c * t) * Math.Exp(b3 * t) + af4 * Math.Sin(c * t) * Math.Exp(b3 * t);
		}

		public static double HU(double t)
		{
			return au1 * Math.Exp(b1 * t) + au2 * Math.Exp(b2 * t) +
				au3 * Math.Cos(c * t) * Math.Exp(b3 * t) + au4 * Math.Sin(c * t) * Math.Exp(b3 * t) + d;
		}

		public static double H(double t)
		{
			return HF(t) + HU(t);
		}
		//private static double kz02 = 2.0;
		private static double af1 = 2.7817625216776405042e-23;//kz02 * 
		private static double af2 = 6.9794902147981082042e-9;//(1.0 / kz02) * 
		private static double af3 = 6.9794902147981360219e-9;//(1.0 / kz02) * 
		private static double af4 = - 0.048842194822822429755;//kz02 * 

		private static double au1 = 1.05e-21;//kz02 * 
		private static double au2 = -0.000028062222747743516348;
		private static double au3 = -0.99997193777725225649;//kz02 * 
		private static double au4 =  -0.29806113461529317455;//(kz02/4) *

		private static double d =  1;//kz02 *

		private static double b1 = -0.0014992503748125937031;
		private static double b2 = -0.50000701634413954253;
		private static double b3 = -0.00074611701533652558404;

		private static double c = 0.0017149377369749152461;
	}
}
