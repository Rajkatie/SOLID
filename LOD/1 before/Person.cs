namespace LOD.before
{
    public class Person
    {
        public string Name { get; private set; }

        public JoB Designation { get; private set; }

        public Person(string name, JoB jobDetails)
        {
            Name = name;
            Designation = jobDetails;

        }
        public JoB GetJob() => Designation;
                
    }

}
