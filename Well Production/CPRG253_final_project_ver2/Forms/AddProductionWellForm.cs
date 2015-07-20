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
using CPRG253_final_project_ver2.Factories;

namespace CPRG253_final_project_ver2
{
    
    public partial class AddProductionWellForm : BaseForms.AddWell
    {
        public List<WellPad> pads;
        public AddProductionWellForm(ref List<WellPad> pads)
        {
            InitializeComponent();
            ComboBoxLoad(ref pads);
            this.pads = pads;
        }

        private void ComboBoxLoad(ref List<WellPad> pads)
        {
            WellPadComboBox.DataSource = pads;
            WellPadComboBox.DisplayMember = "DisplayComboBox";
        }

        private void AddProductionWell_Load(object sender, EventArgs e)
        {
            WaterTypeComboBox.Visible = false;
            label4.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool isInteger = false;
            bool isDateTme = false;
            int id;
            DateTime dt;

            if (WellPadComboBox.SelectedIndex > -1 && IDTextBox.Text.Length > 0 && SpudDateTextBox.Text.Length > 0)
            {
                isInteger = Int32.TryParse(IDTextBox.Text, out id);
                isDateTme = DateTime.TryParse(SpudDateTextBox.Text, out dt);
                if (WellPadComboBox.SelectedIndex > -1 && isInteger == true && isDateTme == true)
                {
                    int selectedIndex = WellPadComboBox.SelectedIndex; // getting index from combo box choice
                    var well = WellFactories.GetFactory("Production").GetWell(); // getting well from wellFactories
                    well.Id = Convert.ToInt32(IDTextBox.Text);
                    well.SprudDate = DateTime.Parse(SpudDateTextBox.Text);

                    ProdWell prodWell = well as ProdWell; //cast to ProdWell type to have a list of OilProduction

                    pads[selectedIndex].Wells.Add(prodWell); //add well to well list for the selected wellPad
                    MessageBox.Show("Production Well Added");
                    MainForm.isChanged = true; //sign for checker
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ID should be INTEGER, \nand/or Spud Date is in wrong format");
                }
            }
            else
            {
                MessageBox.Show("All fields are Mandatory");
            }
        }
    }
}
