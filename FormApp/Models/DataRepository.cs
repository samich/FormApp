namespace FormApp.Models
{
    public class DataRepository
    {

        private static List<Person> _persons = new List<Person>();

        public static void addPerson(Person person) 
        {            
            _persons.Add(person);        
        }

        public static List<Person> GetPersons() {         
            return _persons;        
        }

        public static void RemoveAll() { 
            _persons.Clear(); 
        }

    }
}
