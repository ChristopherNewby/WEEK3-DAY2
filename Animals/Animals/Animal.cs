using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public abstract int NumLegs { get; set; }
        public abstract bool HasFur { get; set; }
        public abstract bool GivesLiveBirth { get; }

        
    }
}
