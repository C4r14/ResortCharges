using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carla_Pretorius_36184950_CH6ChargesInALuxuryResort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalcStayCharges(out decimal StayCharges, int NumberOfDaysStayed)
        {
            StayCharges = NumberOfDaysStayed * 450;
            return StayCharges;
        }

        private decimal CalcMiscCharges(out decimal MiscCharges, decimal ResturantCharges,
            decimal SpaCharges, decimal MedicationCharges, decimal CarCharges)
        {
            MiscCharges = ResturantCharges + SpaCharges + MedicationCharges + CarCharges;
            return MiscCharges;
        }

        private decimal CalcTotalCharges(out decimal TotalCharges, decimal MiscCharges, decimal StayCharges)
        {
            TotalCharges = MiscCharges + StayCharges;
            return TotalCharges;
        }
        private void btnCalculateTotalCharges_Click(object sender, EventArgs e)
        {
            int NumberOfDaysStayed;
            decimal ResturantCharges;
            decimal SpaCharges;
            decimal MedicationCharges;
            decimal CarCharges;

            decimal StayCharges;
            decimal MiscCharges;
            decimal TotalCharges;

            if ((int.TryParse(txtNumDaysStayed.Text, out NumberOfDaysStayed))
                && (NumberOfDaysStayed > 0) && (NumberOfDaysStayed < 15))       // ()
            {
                if (decimal.TryParse(txtResturantCharges.Text, out ResturantCharges))
                {
                    if (decimal.TryParse(txtSpaTreatmentCharges.Text, out SpaCharges))
                    {
                        if (decimal.TryParse(txtCarRentalCharges.Text, out CarCharges))
                        {
                            if (decimal.TryParse(txtMedicationCharges.Text, out  MedicationCharges))
                            {
                                CalcStayCharges(out StayCharges, NumberOfDaysStayed);
                                CalcMiscCharges(out MiscCharges, ResturantCharges, SpaCharges,
                                    MedicationCharges, CarCharges);
                                CalcTotalCharges(out TotalCharges, MiscCharges, StayCharges);

                                rtbOutput.Text = "Stay charges: " + StayCharges.ToString("C") + '\n';
                                rtbOutput.AppendText("Miscellaneous charges: " + MiscCharges.ToString("C") + '\n');
                                rtbOutput.AppendText("Total charges: " + TotalCharges.ToString("C"));
                            }
                            else
                            {
                                MessageBox.Show("Invalid medication charges.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid car rental charges.");
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid spa charges.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid resturant charges");
                }
            }
            else 
            {
                MessageBox.Show("Invalid number of days stayed.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
