using System;

namespace LOD.After
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
        internal void ChangeJobPositionTo(string newDesignatioName)
        {
            Title = newDesignatioName;
        }
    }
}
