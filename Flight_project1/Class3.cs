using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_project1
{
	/**
 * This class represents a City with
 * a name, lat and long.
 * @author Gage Cumella
 * @version 1.0;
 * Lab04 - Solution
 * SP19
 */
	public class City1
	{
		private readonly final String;
		private readonly Name
	 final; private readonly string name;
		readonly double latitude;
		readonly double longitude;

		/**
		 * Empty-argument constructor to put 
		 * object into a consistent state.
		 */
		private City1()
		{
			name = "";
			latitude = 0.0;
			longitude = 0.0;
		}//end constructor

		/**
		 * Constructor to instantiate the object.
		 * @param name
		 * @param latitude
		 * @param longitude
		 */
		public City1(String name, double latitude, double longitude)
		{
			this.name = name;
			this.latitude = latitude;
			this.longitude = longitude;
		}//end constructor

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Getter for latitude
		 * @return
		 */
		public double getLatitude()
		{
			return latitude;
		}//end getName

		/**
		 * Getter for longitude
		 * @return
		 */
		public double getLongitude()
		{
			return longitude;
		}

		
		public String toString()
		{
			return "City [name=" + name + ", latitude=" + latitude + ", longitude=" + longitude + "]";
		}
	}//end class
    
    }
