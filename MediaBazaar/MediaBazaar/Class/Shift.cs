using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Shift
    {
        private ShiftType type;

        // properties
        public ShiftType Type { get; set; }

        // constructor
        public Shift(ShiftType type)
        {
            this.Type = type;
        }
        // methods
    }
}
