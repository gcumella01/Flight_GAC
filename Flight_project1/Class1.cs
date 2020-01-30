using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_project1
{
	/**
 * This object represents a flight
 * @author Gage Cumella
 * @version 1.0
 * Lab04 - Solution
 * SP19
 */



	public class flight_Test
	{
		private String airLineName;
		private city destinationcity;
		private String flightNumber;



		/**
		 * Empty-argument constructor to put 
		 * the object into a consistent state.
		 */
		public flight_Test()

		{
			airLineName = null;
			SetOriginCity1(null);
			destinationcity = null;
			flightNumber = null;
		}//end constructor

		/**
		 * Preferred constructor for this object
		 * @param aln - airline number
		 * @param fn - flight number
		 * @param o - origin city
		 * @param d - destination city
		 */
		public flight_Test(string aln, string fn, city o, city d)
		{

			setAirLineName(aln);
			setFlightNumber(fn);
			setOriginCity(o);
			SetDestinationCity(d);

		}//end constructor

		private void setOriginCity(city o)
		{
			throw new NotImplementedException();
		}

		private void SetDestinationCity(city d)
		{
			throw new NotImplementedException();
		}

		/**
		 * Method uses the haversine formulae
		 * to calculate the distance around the 
		 * globe from one city to another.
		 * @return - distance in miles
		 */
		public double calcDistanceToFly()
		{

			double R = 6371000;
			double lat1 = OriginCity.getLatitude();
			double lat2 = destinationcity.getLatitude();
			double lon1 = OriginCity.getLongitude();
			double lon2 = destinationcity.getLongitude();

			double lat1Radians = Math.PI*(lat1);
			double lat2Radians = Math.PI*(lat2);
			double lon1Radians = Math.PI*(lon1);
			double lon2Radians = Math.PI*(lon2);
			double deltaLat = Math.PI*(lat2 - lat1);
			double deltaLon = Math.PI*(lon2 - lon1);

			double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + (Math.Cos(lat1Radians) * Math.Cos(lat2Radians) * Math.Pow(Math.Sin(deltaLon / 2), 2));

			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

			double distance = R * c;

			return distance * 0.000621371;
		}//end 

		/**
		 * This method will return all of the flight
		 * details including the airline, flight number,
		 * and distance between two city objects.
		 * @return -String representing the flight details
		 */
		public String printFlightDetails()
		{

			var formatter = NumberFormat.getNumberInstance();

			StringBuilder sb = new StringBuilder();

			sb.Append(airLineName + " " + flightNumber + "\n");
			sb.Append(value: OriginCity.getName() + " to " + destinationcity.getName() + "\n");
			sb.Append("Distance: " + formatter.format(this.calcDistanceToFly()) + " miles.\n");

			return sb.ToString();
		}//end printFlightDetails

		/**
		 * getter for airLineName
		 * @return
		 */
		public String getAirLineName()
		{
			return airLineName;
		}//end getAirline

		/**
		 * Setter for airLineName
		 * @param airLineName
		 */
		public void setAirLineName(String airLineName)
		{
			this.airLineName = airLineName;
		}//end setAirLineName

		/**
		 * Getter for flightNumber
		 * @return
		 */
		public String getFlightNumber()
		{
			return flightNumber;
		}//end getFlightNumber

		/**
		 * Setter for flightNumber
		 * @param flightNumber
		 */
		public void setFlightNumber(String flightNumber)
		{
			this.flightNumber = flightNumber;
		}//end setFlightNumber

		/**
		 * Getter for originCity
		 * @return
		 */
		/**
 * Getter for originCity
 * @return
 */
		public city OriginCity { get; private set; }
		public city DestinationCity { get; private set; }

		/**
		 * Getter for originCity
		 * @return
		 */
		private void SetOriginCity1(city value)
		{
			OriginCity = value;
		}

		/**
		 * Setter for originCity
		 * @param originCity
		 */
		void SetOriginCity(city originCity)
		{
			SetOriginCity1(originCity);
		}//end setOriginCity

		/**
		 * Getter for destinationCity
		 * @return
		 */
		public city GetDestinationCity()
		{
			return DestinationCity;//end getDestinationCity
		}

		/**
		 * Setter for destinationCity
		 * @param destinationCity
		 */
		void SetDestinationcity(city destinationCity)
		{
			this.destinationcity = destinationCity;
		}//end setDestinationCity


#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
		private string ToString()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
		{
			return "Flight [airLineName=" + airLineName + ", originCity=" + OriginCity + ", destinationCity="
					+ destinationcity + ", flightNumber=" + flightNumber + "]";
		}//end toString


	}//end class

}

