using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForms;
using System.IO;

namespace CPRG253_final_project_ver2
{
    public partial class MainForm : BaseForms.Main
    {
        //Declaration of variables
        public List<string> PrvinceList; //variable to read the list of trovinces from CSV
        ExplorerFrm explorer;
        AddWellPadForm addWellPad;
        AddProductionWellForm addProductionWell;
        AddInjectionWellForm addInjectionWell;
        WellProductionForm wellProduction;
        TheDelegate theDelegte;
        
        public List<WellPad> pads;
        
        public static bool isChanged = true; //variable to track changes in DB
        public static bool isSerialized = false; //variable to track if serialization is done
        public static int TimeInterval1; //interval of checing if db has been changed 

        FileAccessObject file = new FileAccessObject();
        //Methods
        public void InitDelegate()
        {
            //Instatiation of the deleagate (did not allow to pass non-static method if located on class level)
            theDelegte = new TheDelegate(StatusLabelChange);
        }

        public void StatusLabelChange (string value)
        {
            statusLabel.Text = value;            
        }

        public MainForm()
        {
            
            InitDelegate();
            InitializeComponent();
            PrvinceList = LoadProvinceCSV(); //taking content from method into varaible
            CheckTimer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Taking list of Well Pads from FacilityManager class realized as singleton pattern
            pads = FacilityManager.Instance;
            pads = file.Deserialize();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (explorer == null || explorer.IsDisposed == true)
            {
                explorer = new ExplorerFrm(ref PrvinceList);
                explorer.MdiParent = this;
                explorer.WindowState = FormWindowState.Maximized;
                explorer.Show();
                theDelegte("Explorer form opens...");
            }
        }

        private void addWellPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addWellPad == null || addWellPad.IsDisposed == true)
            {
                addWellPad = new AddWellPadForm(ref PrvinceList, ref pads);
                addWellPad.Show();
                addWellPad.BringToFront();
                theDelegte("Add Well Pad form opens...");
            }
        }

        private void addProductionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addProductionWell == null || addProductionWell.IsDisposed == true)
            {
                addProductionWell = new AddProductionWellForm(ref pads);
                addProductionWell.Show();
                addProductionWell.BringToFront();
                theDelegte("Add Production form opens...");
            }
        }

        private void addInjectionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addInjectionWell == null || addInjectionWell.IsDisposed == true)
            {
                addInjectionWell = new AddInjectionWellForm(ref pads);
                addInjectionWell.Show();
                addInjectionWell.BringToFront();
                theDelegte("Add Injection Well form opens...");
            }
        }

        private void wellProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wellProduction == null || wellProduction.IsDisposed == true)
            {
                wellProduction = new WellProductionForm(ref pads);
                wellProduction.Show();
                wellProduction.BringToFront();
                theDelegte("Add Production Well form opens...");
            }
        }

        private List<string> LoadProvinceCSV()
        {
            string wantedPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            wantedPath = wantedPath + "/prov.csv";
            string csvFile = File.ReadAllText(wantedPath);
            List<string> provList = csvFile.Split(',').ToList();
            return provList;
        }

        private Timer timer;
        private void CheckTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(checkIfDBWasChanged);
            if (TimeInterval1 == 0)
            {
                TimeInterval1 = 1500;
            }
            timer.Interval = TimeInterval1;
            timer.Start();
        }

        private void checkIfDBWasChanged(object sender, EventArgs e)
        {
            if (MainForm.isChanged == true)
            {
                theDelegte("Saving data...");
                MainForm.isChanged = false;
                file.Serialize(pads);                
                MainForm.isSerialized = true;
            }
            statusLabel.Text = "Ready";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
