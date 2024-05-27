using System;
using System.Windows.Forms;

namespace LifeGoals
{
    public partial class CreateGoalForm : Form
    {
        private bool isRepeatingChecked;

        public CreateGoalForm()
        {
            InitializeComponent();
            isRepeatingChecked = false;
            rbtnRepeating.Click += rbtnRepeating_Click;
        }

        private void rbtnRepeating_Click(object sender, EventArgs e)
        {
            if (isRepeatingChecked)
            {
                rbtnRepeating.Checked = false;
                isRepeatingChecked = false;
            }
            else
            {
                isRepeatingChecked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Code to save the goal
        }
    }
}
