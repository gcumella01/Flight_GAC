using System;

namespace Flight_project1
{
   public class city
    {
        private string v1;
        private double v2;
        private double v3;

        public city(string v1, double v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public city()
        {
        }

        internal string getName()
        {
            throw new NotImplementedException();
        }

        internal double getLongitude()
        {
            throw new NotImplementedException();
        }

        internal double getLatitude()
        {
            throw new NotImplementedException();
        }
    }
}