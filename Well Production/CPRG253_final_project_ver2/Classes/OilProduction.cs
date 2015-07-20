using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace CPRG253_final_project_ver2
{
    [Serializable]
    public class OilProduction : BaseClasses.IOilProduction
    {
        //Barrels Produced
        private int _barrelsProduced;
        public int BarrelsProduced
        {
            get { return _barrelsProduced; }
            set { _barrelsProduced = value; }
        }
        //Production Date
        private DateTime _productionDate;
        public DateTime ProductionDate
        {
            get { return _productionDate; }
            set { _productionDate = value; }
        }
    }
}
