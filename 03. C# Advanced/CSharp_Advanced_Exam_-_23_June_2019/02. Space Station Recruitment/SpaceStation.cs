using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
     public class SpaceStation
    {
        private List<Astronaut> spaceStation;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count =>
            spaceStation.Count;

        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            spaceStation = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (Capacity>Count)
            {
                spaceStation.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            bool isValid = true;
            Astronaut astronaut = spaceStation.FirstOrDefault(x => x.Name == name);
            spaceStation.Remove(astronaut);
            if (astronaut==null)
            {
                isValid = false;
            }
            return isValid;
        }
        public Astronaut GetOldestAstronaut()
        {
            Astronaut astronaut = spaceStation.OrderByDescending(x => x.Age).FirstOrDefault();
            return astronaut;
        }
        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = spaceStation.Where(x => x.Name == name).FirstOrDefault();
            return astronaut;
        }
        public string 	Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var item in spaceStation)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
