namespace LOD.before
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Person person = new Person("Homer", new JoB(99000, "SSE"));

            person.GetJob().setPosition("Solution Architect");


        }
    }
}
