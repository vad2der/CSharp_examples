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

namespace CPRG253_final_project_ver2
{
    public partial class WellProductionForm : BaseForms.WellProduction
    {
        WellPad wellPad;
        ProdWell prodWell;
        public List<WellPad> pads;
        string selectedWP;

        public WellProductionForm(ref List<WellPad> pads)
        {
            InitializeComponent();
            ComboBoxLoad1(ref pads);
            this.pads = pads;
        }

        private void ComboBoxLoad1(ref List<WellPad> pads)
        {//loading Well Pad combo Box
            WellPadcomboBox.DataSource = pads;
            WellPadcomboBox.DisplayMember = "DisplayComboBox";
            
            ComboBoxLoad2(ref pads);
        }

        private void ComboBoxLoad2(ref List<WellPad> pads)
        {//loading Well Combo Box depending on what WellPad is selected
            if (pads != null)
            {
                selectedWP = this.WellPadcomboBox.GetItemText(this.WellPadcomboBox.SelectedItem);
                wellPad = pads.Find(s => s.DisplayComboBox == selectedWP); //Lambda         
                if (wellPad != null)
                {
                    var filtered = from f in wellPad.Wells //LINQ
                                   where (f is ProdWell)
                                   select f;
                    WellComboBox.DataSource = filtered.ToList<IWell>();
                    WellComboBox.DisplayMember = "Id";
                    

                }
            }
        }

        private void WellProductionForm_Load(object sender, EventArgs e)
        {//change of index of Well Pad selected in list
            ComboBoxLoad2(ref pads);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isInteger = false;
            int numOfBarrels;
            bool isDateTme = false;
            DateTime dt;

            if (WellPadcomboBox.SelectedIndex > -1 && WellComboBox.SelectedIndex > -1 && BarrelsProducedTextBox.Text.Length > 0 && prodDateTextBox.Text.Length > 0)
            {
                isInteger = Int32.TryParse(BarrelsProducedTextBox.Text, out numOfBarrels);                
                if (isInteger == false)
                {
                    MessageBox.Show("Number of produced barrels must be an INTEGER");
                }
                isDateTme = DateTime.TryParse(prodDateTextBox.Text, out dt);
                if (isDateTme == false)
                {
                    MessageBox.Show("Date should be in DateTime format");
                }
                if (isInteger == true && isDateTme == true)
                {
                    string selectedW = this.WellComboBox.GetItemText(this.WellComboBox.SelectedItem);
                    prodWell = wellPad.Wells.Find(w => w.Id.ToString() == selectedW) as ProdWell;
                    prodWell.DailyProduction.Add(new OilProduction {BarrelsProduced = Convert.ToInt32(BarrelsProducedTextBox.Text), ProductionDate = DateTime.Parse(prodDateTextBox.Text)});
                    MessageBox.Show("Oil Production Entry Added");
                    MainForm.isChanged = true; //sign for checker
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory");
            }
        }
    }
}
