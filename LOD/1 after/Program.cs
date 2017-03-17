namespace LOD.After
{
    public class Program
    {
        public static void Main(string[] args)
        {

            JoB jobDetails = new JoB(99000,"SSE");

            Person person = new Person("Homer", jobDetails);

            person.ChangeJobPositionTo("Solution Architect");

        }
    }
}
