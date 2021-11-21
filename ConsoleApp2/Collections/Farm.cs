using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
    public class Farm<T> : IEnumerable<T> where T : Animal
    {

        private List<T> animals = new List<T>();

        public List<T> Animals
        {
            get
            {
                return animals;
            }
        }



        public IEnumerator<T> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        public void MakeNoise()
        {
            foreach(T animal in animals)
            {
                animal.MakeANoise();
            }
        }

        public void FeedTheAnimals()
        {
            foreach(T animal in animals)
            {
                animal.Feed();
            }
        }

        public Farm<Cow> getCows()
        {
            Farm<Cow> cowFarm = new Farm<Cow>();
            foreach(T animal in animals)
            {
                if(animal is Cow)
                {
                    cowFarm.Animals.Add(animal as Cow);
                }
            }
            return cowFarm;
        }

        public void Add(T animal)
        {
            animals.Add(animal);
        }
    }
}
