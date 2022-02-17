using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_behavior
{
   public interface IGeneric_Animal<T>
    {
        string GetGenericAnimal(T obj);
    }
}
