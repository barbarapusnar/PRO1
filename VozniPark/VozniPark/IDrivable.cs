using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozniPark
{
    internal interface IDrivable
    {
        // Vmesnik IDrivable bi moral 
        // vključevati metodo Drive, ki meri razdaljo
        // v kilometrih in vrne količino porabljenega goriva
        double Drive(int štKilometrov);
    }
}
