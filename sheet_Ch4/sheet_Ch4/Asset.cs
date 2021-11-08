using System;
using System.Collections.Generic;
using System.Text;

namespace sheet_Ch4
{
    class Asset
    {
        private string name;
        private decimal val;
        private double depreciation_rate;

        public Asset(string name,decimal type,double depreciation_rate)
        {
            Name = name;
            Value = type;
            Depreciation = depreciation_rate;
        }


        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public decimal Value
        {
            set
            {
                if (value > 0)
                    val = value;
            }
            get
            {
                return val;
            }
        }

        public double Depreciation
        {
            set
            {
                if (value > 0)
                    depreciation_rate = value;
            }
            get
            {
                return depreciation_rate;
            }
        }

    }
}
