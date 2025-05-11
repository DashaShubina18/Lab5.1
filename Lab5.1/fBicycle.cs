using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._1
{
    public partial class fBicycle : Form
    {
        public Bicycle TheBicycle;
        public fBicycle( Bicycle b)
        {
            InitializeComponent();
            TheBicycle = b;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            
                TheBicycle.Model = tbModel.Text.Trim();
                TheBicycle.Year = int.Parse(tbYear.Text.Trim());
                TheBicycle.Colour = tbColour.Text.Trim();
                TheBicycle.Price = double.Parse(tbPrice.Text.Trim());
                TheBicycle.FrameLoadCapacity = int.Parse(tbFrameLoadCapacity.Text.Trim());
                TheBicycle.Weight = double.Parse(tbWeight.Text.Trim());
                TheBicycle.WasUsed = chbWasUsed.Checked;
                TheBicycle.WasDamaged = chbWasDamaged.Checked;

                DialogResult = DialogResult.OK;
                this.Close();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fBicycle_Load(object sender, EventArgs e)
        {

            if (TheBicycle != null)
            {
                tbModel.Text = TheBicycle.Model;
                tbYear.Text = TheBicycle.Year.ToString();
                tbColour.Text = TheBicycle.Colour;
                tbFrameLoadCapacity.Text = TheBicycle.FrameLoadCapacity.ToString();
                tbPrice.Text = TheBicycle.Price.ToString("0.00");
                tbWeight.Text = TheBicycle.Weight.ToString("0.00");
                chbWasUsed.Checked = TheBicycle.WasUsed;
                chbWasDamaged.Checked = TheBicycle.WasDamaged;
            }

        }

       
    }
}
    
