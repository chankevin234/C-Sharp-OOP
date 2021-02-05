using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises._2Inheritance
{
    class Consultant : Person
    {
        public Consultant(string name, decimal hourlyRate, int hoursReported) : base(name) // this constructor passes values up to the base class .. at least pass up name
        {
            HourlyRate = hourlyRate;
            HoursReported = hoursReported;
        }
        //properties
        public decimal HourlyRate { get; set; }
        public int HoursReported { get; set; }
    }
}
