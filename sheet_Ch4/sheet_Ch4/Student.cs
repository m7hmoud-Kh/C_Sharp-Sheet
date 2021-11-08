using System;
using System.Collections.Generic;
using System.Text;

namespace sheet_Ch4
{
    class Student
    {
        private string Id;
        private string name;
        private decimal sub1;
        private decimal sub2;
        private decimal sub3;

        public Student(string id,string name,decimal s1,decimal s2 , decimal s3)
        {
            Id = id;
            this.name = name;
            Sub1 = s1;
            Sub2 = s2;
            Sub3 = s3;
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

        public decimal Sub1
        {
            set
            {
                if (value > 0)
                    sub1 = value;
                else
                    sub3 = Math.Abs(value);
            }
            get
            {
                return sub1;
            }
        }

        public decimal Sub2
        {
            set
            {
                if (value > 0)
                    sub2 = value;
                else
                    sub3 = Math.Abs(value);
            }
            get
            {
                return sub2;
            }
        }

        public decimal Sub3
        {
            set
            {
                if (value > 0)
                    sub3 = value;
                else
                    sub3 = Math.Abs(value);
            }
            get
            {
                return sub3;
            }
        }


        public decimal GetAggregate()
        {
            return sub1 + sub2 + sub3;
        }

        public decimal GetPercentage()
        {
            return (this.GetAggregate() / 50) * 100;
        }

    }
}
