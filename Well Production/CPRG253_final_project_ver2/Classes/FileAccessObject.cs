using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using BaseClasses;
using System.IO;

namespace CPRG253_final_project_ver2
{
    public class FileAccessObject
    {
        public void Serialize(List<WellPad> pads)
        {
            using (Stream stream = new FileStream("DataBase.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, pads);
                stream.Close();
            }
        }
        
        public List<WellPad> Deserialize()
        {
            using (Stream stream = new FileStream("DataBase.dat", FileMode.Open))
            {
                //stream.ReadTimeout = 1000; //Does not read dat file from previous session - Timeout exception, have not found how to handle this yet..
                BinaryFormatter formatter = new BinaryFormatter();
                List<WellPad> pads = new List<WellPad>();
                if (stream.Length != 0)
                {
                    pads = formatter.Deserialize(stream) as List<WellPad>;
                }
                stream.Close();
                return pads;
            }
        }
    }
}
