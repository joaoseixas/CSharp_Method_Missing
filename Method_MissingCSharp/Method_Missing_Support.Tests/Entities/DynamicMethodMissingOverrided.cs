using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_MissingCSharp.Entities
{
    public class DynamicMethodMissingOverrided : Dynamic
    {
        public override void MethodMissing(string methodName, out object result, object[] parameters)
        {
            result = "No " + methodName + " declared in this class";
        }
    }
}
