using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov
{
    class Lab2
    {
        private string name;
        private int inf;
        private int programmy;
        private int math;
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;

            }

        }
        public int Inf
        {
            get
            {
                return inf;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) inf = value;
                if (value >= 2) inf = value;

            }

        }
        public int Programmy
        {
            get
            {
                return programmy;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) programmy = value;
                if (value >= 2) programmy = value;

            }

        }
        public int Math
        {
            get
            {
                return math;

            }
            set
            {
                if (value >= 6) value = 5;
                if (value < 2) value = 2;
                if (value <= 5) math = value;
                if (value >= 2) math = value;

            }

        }
    }
}
    

