using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_behavior
{
    public class GenericAnimal<T> : IGeneric_Animal<T>
    {
        public string GetGenericAnimal(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
                {
                    case AnimalType.Harvivore:
                        behavior = "The Animal Eats Grass";
                        break;
                    case AnimalType.carnivore:
                        behavior = "The Animal Eats Meat";
                        break;
                    case AnimalType.Omnivore:
                        behavior = "The Animal Eats EveryThing";
                        break;
                    default:
                        behavior = "unknown behavior";
                        break;
                }
            }
            else { behavior = "Not an animal"; }
            return behavior;

        }
    }
}
