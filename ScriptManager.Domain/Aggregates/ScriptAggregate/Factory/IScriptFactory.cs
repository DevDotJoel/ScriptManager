using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Domain.Aggregates.ScriptAggregate.Factory
{
    public interface IScriptFactory
    {
        Script Create(string name, string description);
    }
}
