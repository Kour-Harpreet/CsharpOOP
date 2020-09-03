using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CsharpOOP.School
{
    public class Pencil : WritingInstrument
    {
        private double _graphiteLevel;
        public double GraphiteLevel
        {
            get
            {
                // Borrowed math from Sai
                return Math.Round(_graphiteLevel / 5.0) * 5;
            }
            private set
            {
                // If the incoming value is over the current value, throw an exception.
                if (value > _graphiteLevel)
                {
                    throw new Exception("You can't add graphite to a pencil!");
                }
                // If the incoming value is below 0, throw an exception.
                if (value < 0)
                {
                    throw new Exception("Not enough ink to do that writing!");
                }

                _graphiteLevel = value;
            }
        }
        // Borrowed from Jia
        public bool HasEraser { get; set; }

        // Without the override keyword, we hide the base class' abstract method rather than implementing it, and C# doesn't like that.
        public override void Write(int characterCount)
        {
            GraphiteLevel /* <- Setting */ = _graphiteLevel /* <- Getting */ - 0.1 * characterCount;
        }

        public Pencil()
        {
            Brand = "Pilot";
            HasEraser = true;
            GraphiteLevel = 100;
        }
    }
}