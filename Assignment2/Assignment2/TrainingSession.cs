using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    public enum Mode { Conference, Journal, Other };

    class TrainingSession
    {
        /*public TrainingSession(string title, int year, DateTime certified, Mode mode)
        {
            Title = title;
            Year = year;
            Certified = certified;
            ModeType = mode;
        }*/

        public string Title { get; set; }
        public int Year { get; set; }
        public DateTime Certified { get; set; }
        public Mode ModeType { get; set; }
        public int Freshness
        {
            get { return (DateTime.Now - Certified).Days; }
        }

        public override string ToString()
        {
            return $"{Title} completed by {ModeType.ToString()} on {Certified.ToString()}";
        }
    }
}
