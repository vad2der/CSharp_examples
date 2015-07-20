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

namespace CPRG253_final_project_ver2
{
    public partial class AddWellPadForm : BaseForms.AddPad
    {
        List<WellPad> pads;
        public AddWellPadForm(ref List<string> PrvinceList, ref List<WellPad> pads)
        {
            InitializeComponent();
            ComboBoxLoad(ref PrvinceList);
            this.pads = pads;
        }

        private void ComboBoxLoad(ref List<string> PrvinceList)
        {
            ProvinceComboBox.DataSource = PrvinceList;
        }

        private void AddWellPadForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {            
            bool isInteger = false;
            int id;
            if (IDTextBox.Text.Length > 0)
            {
                isInteger = Int32.TryParse(IDTextBox.Text, out id);
            }
            if (isInteger == false) 
            {
                MessageBox.Show("ID must be an INTEGER");
            }
            if (isInteger == true && LocationTextBox.Text.Length > 0)
            {
                //check if ID was used already by Lambda expression
                bool match = pads.Any(wp => wp.Id == Convert.ToInt32(IDTextBox.Text));
                if (match == false)
                {
                    pads.Add(new WellPad { Id = Convert.ToInt32(IDTextBox.Text), Location = LocationTextBox.Text, Province = ProvinceComboBox.Text });
                    MessageBox.Show("Well Pad added: \n" + pads[pads.Count - 1].Id.ToString() + "\n" + pads[pads.Count - 1].Location + "\n" + pads[pads.Count - 1].Province);
                    MainForm.isChanged = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This ID alreay has been used. Enter a different one.");
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory.");
            }
        }
    }
}
