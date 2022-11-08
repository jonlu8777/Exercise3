using System.Xml.Linq;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                PersonHandler pHandler = new PersonHandler();
                Person person = pHandler.CreatePerson(20, "Jonas", "Lundberg", 100, 100);
                pHandler.SetAge(person, 40);
                pHandler.SetFName(person, "Niklas");
                pHandler.SetLName(person, "Andersson");
                Console.WriteLine(person.ToString());
                Console.WriteLine(pHandler.MakeToFullString(person));
                Console.WriteLine();

                Person p1 = pHandler.CreatePerson(20, "Jonas", "Lundberg", 100, 100);
                Person p2 = pHandler.CreatePerson(20, "Thomas", "Mattson", 100, 100);
                Person p3 = pHandler.CreatePerson(20, "Niklas", "Qvist", 100, 100);

                var persons = new List<Person>();
                persons.Add(p1);
                persons.Add(p2);
                persons.Add(p3);

                foreach (Person p in persons)
                {
                    pHandler.SetAge(p, 500);
                    Console.WriteLine(pHandler.MakeToFullString(p));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex); 
            }

        }
    }
}