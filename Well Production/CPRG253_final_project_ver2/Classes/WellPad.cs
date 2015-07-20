using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace CPRG253_final_project_ver2
{
    [Serializable]
    public class WellPad : BaseClasses.IWellPad
    {
        //ID
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //Province
        private string _prov;
        public string Province
        {
            get { return _prov; }
            set { _prov = value; }
        }
        //Sprud Date
        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        //Associated Production Wells
        private List<IWell> _wells = new List<IWell> ();
        public List<IWell> Wells
        {
            get { return _wells ;}
            set { _wells = value; }
        }
        //Display Member
        public string DisplayComboBox
        {
            get { return Id.ToString() + " "+ Location+ " " + Province;}
        }

        public string DisplayTreeView
        {
            get { return Id.ToString() + " " + Location; }
        }

        public List<WellPad> GetWellPads()
        {
            return new List<WellPad>();
        }
        public static WellPad Create
        {
            get { return new WellPad(); }
        }
    }
}
