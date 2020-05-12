using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Interfaces
{
	interface INamedCollection<T> : IEnumerable<T>, IEnumerable, ICollection<T> where T : INamedObject
	{
		
	}

	interface INamedCollection : INamedCollection<INamedObject> {}
}
