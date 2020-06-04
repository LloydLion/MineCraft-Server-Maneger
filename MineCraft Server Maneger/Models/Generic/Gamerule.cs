using StandardLibrary.Interfaces;
using StandardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models.Generic
{
    class Gamerule<T> : Model, IPrivateNamedObject
    {
        public Gamerule(string name, Func<string, T> parseFunction)
        {
            Name = name;
            ParseFunction = parseFunction;
        }

        public string Name { get; }
        public Func<string, T> ParseFunction { get; }

        public override object Clone()
        {
            throw new NotImplementedException();
        }
    }

    class Gamerule : Gamerule<object>
    {
        public Gamerule(Type gameruleType, string name, Func<string, object> parseFunction) 
            : base(name, parseFunction)
        {
            GameruleType = gameruleType;
        }

        public Type GameruleType { get; }


        public static Gamerule TypeDownCast<T>(Gamerule<T> obj)
        {
            return new Gamerule(typeof(T), obj.Name, (s) => obj.ParseFunction(s));
        }
    }
}
