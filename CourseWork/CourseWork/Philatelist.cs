using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Philatelist
    {
        private string name;
        private string country;
        private string details;

        private List<Mark> raremarks;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public Philatelist(string name, string country, string details)
        {
            this.name = name;
            this.country = country;
            this.details = details;
            raremarks = new List<Mark>();
        }
    }

}
