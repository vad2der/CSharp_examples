using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    public interface IProductionWell : IWell
    {
        List<IOilProduction> DailyProduction { get; set; }
    }
}
