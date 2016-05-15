using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Mark
    {
        private int year;
        private string country;
        private double cost;
        private int circulation;
        private string features;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string Country
        {
            get { return country; }
        }

        public int Circulation
        {
            get { return circulation; }
        }

        public string Featires
        {
            get { return features; }
            set { features = value; }
        }

        public Mark(int year, string country, double cost, int circulation, string features)
        {
            this.year = year;
            this.country = country;
            this.cost = cost;
            this.circulation = circulation;
            this.features = features;
        }
    }
}
