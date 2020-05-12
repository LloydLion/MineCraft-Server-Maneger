using MineCraft_Server_Maneger.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.SubClasses
{
    class NamedCollection<T> : List<T>, INamedCollection<T> where T : INamedObject
    {
        public T GetElementByName(string name)
        {
            return this.Where((s) => s.Name == name).Single();
        }

        public NamedCollection(T[] a) : base(a)
        {

        }
    }
}
