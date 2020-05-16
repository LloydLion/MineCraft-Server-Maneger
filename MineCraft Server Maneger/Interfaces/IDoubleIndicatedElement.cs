using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Interfaces
{
    interface IDoubleIndicatedElement : IIndicatedElement
    {
        int NumId { get; set; }
    }
}
