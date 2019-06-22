using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroCollection;

        public int Count
            => heroCollection.Count;
        public HeroRepository()
        {
            heroCollection = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            heroCollection.Add(hero);
        }
        public void Remove(string name)
        {
            Hero targetHero = heroCollection.FirstOrDefault(x => x.Name == name);
            heroCollection.Remove(targetHero);
        }
        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = heroCollection.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.heroCollection.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return hero;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
        Hero hero = heroCollection.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
        return hero;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var hero in heroCollection)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString();
        }

    }
}
