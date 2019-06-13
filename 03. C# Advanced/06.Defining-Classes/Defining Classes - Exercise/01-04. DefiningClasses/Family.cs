using System;
using System.Text;

namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
              familyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            Person olderPerson = familyMembers.OrderByDescending(p => p.Age).FirstOrDefault();
            return olderPerson;
        }

        public List<Person> FilteredFamily()
        {
            var filtered = familyMembers.Where(p => p.Age > 30).OrderBy(x => x.Name).ToList();
            return filtered;
        }
    }
}
