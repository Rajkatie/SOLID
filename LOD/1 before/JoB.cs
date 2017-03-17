using System;

namespace LOD.before
{
    public class JoB
    {
        public int Salary { get; set; }

        public String Title { get; set; }
        public JoB(int salary,string designation)
        {
            Title = designation;
            Salary = salary;

        }
        internal void setPosition(string newPosition)
        {
            Title = newPosition;
            // save into database;
        }

    }
}
