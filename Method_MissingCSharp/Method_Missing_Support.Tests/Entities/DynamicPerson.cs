using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaProgrammingCSharp.Tests.Entities
{
    public class DynamicPerson : Dynamic
    {
        public string Name { get; set; }
        
        public DynamicPerson()
        {
            Name = "Joao";
           
        }

        
    }
}
