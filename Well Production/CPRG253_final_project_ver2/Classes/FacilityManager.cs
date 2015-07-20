using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253_final_project_ver2
{
    public class FacilityManager
    {
        private static List<WellPad> _instance = null;

        public static List<WellPad> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new List<WellPad>();
                }
                return _instance;
            }
        }

        private FacilityManager()
        {

        }

    }
}
