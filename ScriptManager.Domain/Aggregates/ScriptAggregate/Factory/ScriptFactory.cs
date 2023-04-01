using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Factory
{
    public class ScriptFactory : IScriptFactory
    {
        public Script Create(string name, string description)
        {
           return new Script(name, description);
        }
    }
}
