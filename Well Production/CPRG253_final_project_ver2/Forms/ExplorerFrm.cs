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
using BaseClasses;
using System.Runtime.Serialization.Formatters.Binary;

namespace CPRG253_final_project_ver2
{
    public partial class ExplorerFrm : BaseForms.Explorer
    {
        public List<string> PrvinceList;
        public List<WellPad> pads;
        TreeNode root;
        public static int TimeInterval2; //interval of checing if db has been serialized 
        FileAccessObject file = new FileAccessObject();

        public ExplorerFrm(ref List<string> PrvinceList)
        {
            pads = file.Deserialize(); 
            InitializeComponent();
            root = uxTreeView.Nodes.Add("Facilities");
            this.PrvinceList = PrvinceList;
            CheckTimer(); //start of timer metod for the check
            DefaultView();
        }

        private void ExplorerFrm_Load(object sender, EventArgs e)
        {
            PopulateTree();
        }

        private Timer timer;
        private void CheckTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(checkIfDBWasSerialized);
            if (TimeInterval2 == 0)
            {
                TimeInterval2 = 500; 
            }
            timer.Interval = TimeInterval2;
            timer.Start();
        }

        private void checkIfDBWasSerialized(object sender, EventArgs e)
        {
            if (MainForm.isSerialized == true)
            {
                MainForm.isSerialized = false;
                pads = file.Deserialize();                
                string directory = uxTreeView.SelectedNode.Text;
                string parentDirectory = "";
                int index = uxTreeView.SelectedNode.Level;
                if (index > 0)
                {
                    parentDirectory = uxTreeView.SelectedNode.Parent.Text;
                }
                SetView(directory, index, parentDirectory);
                PopulateTree();
            }
        }

        private void PopulateTree()
        {
            root.Nodes.Clear();
            foreach (string p in PrvinceList)
            {                                
                TreeNode ProvinceNode = new TreeNode(p);
                root.Nodes.Add(ProvinceNode);
                foreach (WellPad wp in pads)
                {
                    TreeNode wellNode = new TreeNode(wp.Location);
                    if (wp.Province == p)
                    {
                        ProvinceNode.Nodes.Add(wellNode);
                        if (wp.Wells != null)
                        {
                            foreach (IWell well in wp.Wells)
                            {
                                wellNode.Nodes.Add(well.SprudDate.ToString("D"));
                            }
                        }
                    }

                }
            }

        }

        protected override void OnResize(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Point NewLoc = Screen.FromControl(this).WorkingArea.Location;
            this.Location = NewLoc;
            Size NewSize = Screen.FromControl(this).WorkingArea.Size;
            this.Size = NewSize;
            
            this.MinimumSize = this.Size;
            this.MaximumSize = this.MinimumSize;
        }

        private void uxTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string directory = e.Node.Text;
            string parentDirectory = "";
            int index = uxTreeView.SelectedNode.Level;
            if (index > 0)
            {
                parentDirectory = e.Node.Parent.Text;
            }
            SetView(directory, index, parentDirectory);
        }

        public void DefaultView()
        {
            uxTreeView.SelectedNode = root;
        }

        private void SetView(string directory, int index, string parentDirectory)
        {
            uxListView.Columns.Clear();
            uxListView.Items.Clear();
            uxListView.View = View.Details;

            int WellCount = 0;
            int ProductionWellCount = 0;
            int InjectionWellCount = 0;
            switch (index)
            {
                case 0:
                    //add columns
                    uxListView.Columns.Add("Province");
                    uxListView.Columns.Add("Well Pad Count");
                    uxListView.Columns.Add("Producing Well Count");
                    uxListView.Columns.Add("Injection Well Count");
                    //collect data to display
                    foreach (var p in PrvinceList)
                    {
                        foreach (var wp in pads)
                        {
                            if (wp.Province == p)
                            {
                                WellCount += 1;
                                foreach (var w in wp.Wells)
                                {
                                    if (w is ProdWell)
                                    {
                                        ProductionWellCount += 1;
                                    }
                                    if (w is InjWell)
                                    {
                                        InjectionWellCount += 1;
                                    }
                                }
                            }
                        }
                        //put collected data in list view
                        uxListView.Items.Add(new ListViewItem(new string[] { p, WellCount.ToString(), ProductionWellCount.ToString(), InjectionWellCount.ToString() }));
                        WellCount = 0;
                        ProductionWellCount = 0;
                        InjectionWellCount = 0;
                    }                 
                    break;
                case 1:
                    uxListView.Columns.Add("Location");
                    uxListView.Columns.Add("Producing Well Count");
                    uxListView.Columns.Add("Injection Well Count");
                    foreach (var wp in pads)
                    {
                        if (wp.Province==directory)
                        {
                            foreach (var w in wp.Wells)
                            {
                                if (w is ProdWell)
                                {
                                    ProductionWellCount += 1;
                                }
                                if (w is InjWell)
                                {
                                    InjectionWellCount += 1;
                                }
                            }
                            //put collected data in list view
                            uxListView.Items.Add(new ListViewItem(new string[] { wp.Location, ProductionWellCount.ToString(), InjectionWellCount.ToString() }));
                            ProductionWellCount = 0;
                            InjectionWellCount = 0;
                        }
                    }
                    break;
                case 2:
                    uxListView.Columns.Add("Spud Date");
                    uxListView.Columns.Add("Barrels Produced");
                    var wellPad = pads.Find(p => p.Location == directory);
                    foreach (var w in wellPad.Wells)
                    {
                        if (w is ProdWell)
                        {
                            int barrels = 0;
                            var w1 = w as ProdWell;
                            foreach (var entry in w1.DailyProduction)
                            {
                                barrels = barrels + entry.BarrelsProduced;
                            }
                            uxListView.Items.Add(new ListViewItem(new string[] { w.SprudDate.ToString("D"),  barrels.ToString()}));
                        }
                        if (w is InjWell)
                        {
                            uxListView.Items.Add(new ListViewItem(new string[] { w.SprudDate.ToString("D"), "0" }));
                        }
                    }
                    break;
                case 3 :
                    uxListView.Columns.Add("Production Date");
                    uxListView.Columns.Add("Barrels Produced");                    
                    var wellPad1 = pads.Find(p => p.Location == parentDirectory);
                    foreach (var w in wellPad1.Wells)
                    {
                        if (w.SprudDate.ToString("D") == directory)
                        {
                            if (w is ProdWell)
                            {   
                                var w1 = w as ProdWell;
                                foreach (var entry in w1.DailyProduction)
                                {
                                    uxListView.Items.Add(new ListViewItem(new string[] { entry.ProductionDate.ToString("d"), entry.BarrelsProduced.ToString() }));
                                    uxListView.Sorting = SortOrder.Descending;
                                }                                
                            }
                            if (w is InjWell)
                            {
                                uxListView.Items.Add(new ListViewItem(new string[] { "N/A", "0" }));
                            }
                        }                        
                    }
                    break;
            }                            
            uxListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //set column width by header width
        }
    }
}
