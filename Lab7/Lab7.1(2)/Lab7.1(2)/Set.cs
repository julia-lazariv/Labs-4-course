// Set.cs
using System.Collections.Generic;
using System.Linq;

namespace Lab7._1_2_
{
    class Set<T>
    {
        private List<T> _list;
        Set()
        {
            _list = new List<T>();
        }
        public Set(params T[] args)
            : this()
        {
            _list.AddRange(args);
        }
        public Set(IEnumerable<T> mas)
            : this()
        {
            _list.AddRange(mas);
        }

        public void Add(T elem)
        {
            _list.Add(elem);
        }

        public void Delete(T elem)
        {
            _list.Remove(elem);
        }

        public Set<T> Intersect(Set<T> Source)
        {
            return new Set<T>(_list.Intersect(Source._list));
        }

        public Set<T> Union(Set<T> Source)
        {
            return new Set<T>(_list.Union(Source._list));
        }

        public Set<T> Except(Set<T> Source)
        {
            return new Set<T>(_list.Except(Source._list));
        }

        public override string ToString()
        {
            return string.Join(",", _list);
        }
    }
}
