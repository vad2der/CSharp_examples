using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{

    public interface IWell
    {    
        //ID
        int Id { get; set;}      
        //Sprud Date
        DateTime SprudDate { get; set; }
        
    }
}
