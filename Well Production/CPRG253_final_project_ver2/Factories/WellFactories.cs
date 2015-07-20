using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253_final_project_ver2.Factories
{
    public class WellFactories
    {
        public static WellFactory GetFactory(string WellType)
        {
            switch (WellType)
            {
                case "Production":
                    return new ProdWellFactory();
                case "Injection":
                    return new InjWellFactory();
            }
            throw new Exception("No such well type");
        }
    }
}
