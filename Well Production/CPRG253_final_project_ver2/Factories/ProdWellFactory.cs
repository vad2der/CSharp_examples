using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace CPRG253_final_project_ver2.Factories
{
    public class ProdWellFactory : WellFactory
    {
        public override IWell GetWell()
        {
            return new ProdWell();
        }
    }
}
