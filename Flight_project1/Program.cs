using System;

namespace Flight_project1
{
	public class Program
    {
		city o = new city("Louisville, KY", 38.2527, 85.7585);
		city d = new city("Los Angeles, CA", 34.0522, 118.243680);
		private static readonly city city = new city("Louisville, KY", 38.2527, 85.7585);
		
		private readonly city d2 = new city("New York, NY", 40.7128, 74.0060);

		public Program(city d2)
		{
			this.d2 = d2;
		}








	}//end main

}//end class