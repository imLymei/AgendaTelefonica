using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhoneList
    {
        public List<Person> PersonList { get; set; } = new List<Person>() { };
    
        public void Add(Person person)
        {
            PersonList.Add(person);
        }

        public Person FindPerson(string name)
        {
            foreach (Person person in PersonList)
            {
                if (person.Name == name)
                {
                    return person;
                }
            }
            return null;
        }

        public void Remove(Person person)
        {
            int index = PersonList.IndexOf(person);
            PersonList.RemoveAt(index);
            PersonList.Remove(person);
        }
    }

}
