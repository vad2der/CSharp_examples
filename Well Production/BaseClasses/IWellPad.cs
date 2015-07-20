using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    public interface IWellPad
    {
        //ID
        int Id { get; set; }
        //Province
        string Province { get; set; }
        //Location
        string Location { get; set; }
        //associated Wells
        List<IWell> Wells { get; set; }
    }
}
