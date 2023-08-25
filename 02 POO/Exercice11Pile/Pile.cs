using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11Pile
{
    internal class Pile<T>
    {
        private List<T> _values = new List<T>();

        public List<T> Values { get => _values; set => _values = value; }

        public Pile(List<T> values)
        {
            Values = new List<T>();
        }

        public void Empiler(T element)
        {
            Console.WriteLine($"J'empile l'élément {element}");
            Values.Add(element);
        }
        public T Depiler(T element)
        {
            if (Values.Count == 0)
            {
                Console.WriteLine("La pile est vide");
            }
            T lastIndex = _values[Values.Count - 1];
            Console.WriteLine($"Je dépile le dernier élément {element}");
            Values.RemoveAt(Values.Count-1);
            return lastIndex;
            
        }

        
    }
}
