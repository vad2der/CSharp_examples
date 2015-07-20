using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    public interface IOilProduction
    {
        DateTime ProductionDate { get; set; }
        int BarrelsProduced { get; set; }
    }
}
