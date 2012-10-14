using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;


namespace Method_MissingCSharp
{
    public class Dynamic : DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            bool canInvoke = base.TryInvokeMember(binder, args, out result);

            if (!canInvoke) 
                this.MethodMissing(binder.Name,out result,args);

            return true;
        }

        public virtual void MethodMissing(string methodName, out object result, object[] parameters)
        {
            var className = GetType().ToString();
            throw new MissingMethodException(className, methodName);
        }


    }
}
