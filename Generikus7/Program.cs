using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus7
{
    public class SearchableList<T>
    {
        private List<T> items;

        public SearchableList()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Find(Func<T, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate), "Predicate cannot be null.");
            }

            return items.FirstOrDefault(predicate);
        }

        public List<T> FindAll(Func<T, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate), "Predicate cannot be null.");
            }

            return items.Where(predicate).ToList();
        }

        public int Count => items.Count;

        public void Clear()
        {
            items.Clear();
        }
    }
}
