using System;
using System.Windows.Forms;

namespace LifeGoals
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
            Load += MainWindowForm_Load;
            UpdateDateTime();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            CenterDateTimeLabels();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvGoals.ColumnCount = 1;
            dgvGoals.Columns[0].Name = "Goal";

            // Create the checkbox column
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Done";
            dgvGoals.Columns.Add(checkBoxColumn);
        }

        private void UpdateDateTime()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            var timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (sender, args) =>
            {
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                CenterDateTimeLabels();
            };
            timer.Start();
        }

        private void CenterDateTimeLabels()
        {
            lblDate.Left = (ClientSize.Width - lblDate.Width) / 2;
            lblTime.Left = (ClientSize.Width - lblTime.Width) / 2;
        }

        private void btnCreateGoal_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelCreateGoal.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelCreateGoal.Visible = false;
            panelMain.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Code to save the goal
        }

        private void btnToday306090_Click(object sender, EventArgs e)
        {
            // Code for Today-30-60-90 button
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            // Code for Category button
        }
    }
}
