using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace CPRG253_final_project_ver2
{
    [Serializable]
    public class InjWell : BaseClasses.IInjectionWell
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
        //Water type
        private WaterType _waterType;
        public WaterType WaterType
        {
            get { return _waterType; }
            set { _waterType = value; }
        }
        //constructors
        public InjWell()
        {

        }
        public InjWell(int id, DateTime sprudDate, WaterType wt)
        {
            _id = id;
            _sprudDate = sprudDate;
            _waterType = wt;
        }
    }
}
