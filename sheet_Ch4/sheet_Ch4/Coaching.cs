using System;
using System.Collections.Generic;
using System.Text;

namespace sheet_Ch4
{
    class Coaching
    {
        private string type;
        private int number_of_palyer;
        private string class_timing;
        private double charge;

        public Coaching(string type,int number_of_player,string class_timing,double charge)
        {
            Type = type;
            Number_of_palyer = number_of_player;
            Class_timing = class_timing;
            Charge = charge;

        }

        public string Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }

        public int Number_of_palyer
        {
            set
            {
                number_of_palyer = value;
            }
            get
            {
                return number_of_palyer;
            }
        }

        public string Class_timing
        {
            set
            {
                class_timing = value;
            }
            get
            {
                return class_timing;
            }
        }

        public double Charge
        {
            set
            {
                charge = value;
            }
            get
            {
                return charge;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{this.Type} && number of palyer: {this.Number_of_palyer} && {this.Class_timing} && {this.Charge:C}");
        }
    }
}
