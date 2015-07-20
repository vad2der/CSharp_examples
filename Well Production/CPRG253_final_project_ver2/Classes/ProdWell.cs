using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace CPRG253_final_project_ver2
{
    [Serializable]
    class ProdWell:BaseClasses.IProductionWell
    {
        //ID
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //Sprud Date
        private DateTime _sprudDate;
        public DateTime SprudDate
        {
            get { return _sprudDate; }
            set { _sprudDate = value; }
        }
        //List of daily production
        private List<IOilProduction> _dailyProduction = new List<IOilProduction>();
        public List<IOilProduction> DailyProduction
        {
            get { return _dailyProduction; }
            set { _dailyProduction = value; }
        }
        //Display for Combo Box
        public string DisplayComboBox
        {
            get { return Id.ToString() + " " + SprudDate.ToString("D"); }
        }
        //constructor
        public ProdWell()
        {

        }
        public ProdWell(int id, DateTime sprudDate)
        {
            _id = id;
            _sprudDate = sprudDate;
        }
    }
}
