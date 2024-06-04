using System;
using System.Windows.Forms;

namespace LifeGoals
{
    public partial class MainWindowForm : Form
    {
        private bool isRepeatingChecked;

        public MainWindowForm()
        {
            InitializeComponent();
            Load += MainWindowForm_Load;
            UpdateDateTime();
            isRepeatingChecked = false;
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            CenterDateTimeLabels();
            InitializeDataGridView();
            ShowMainPanel();
            InitializeRadioButton();
            CenterCategoryLabel();
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

        private void CenterCategoryLabel()
        {
            lblCategoryList.Left = (ClientSize.Width - lblCategoryList.Width) / 2;
        }

        private void btnCreateGoal_Click(object sender, EventArgs e)
        {
            ShowCreateGoalPanel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowMainPanel();
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
            ShowCategoryPanel();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            ShowCreateCategoryPanel();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            AddCategoryPanel(txtCategoryName.Text);
            ShowCategoryPanel();
        }

        private void btnBackFromCategory_Click(object sender, EventArgs e)
        {
            ShowMainPanel();
        }

        private void btnBackFromCreateCategory_Click(object sender, EventArgs e)
        {
            ShowCategoryPanel();
        }

        private void ShowMainPanel()
        {
            panelMain.Visible = true;
            panelCreateGoal.Visible = false;
            panelCategory.Visible = false;
            panelCreateCategory.Visible = false;
        }

        private void ShowCreateGoalPanel()
        {
            panelMain.Visible = false;
            panelCreateGoal.Visible = true;
            panelCategory.Visible = false;
            panelCreateCategory.Visible = false;
        }

        private void ShowCategoryPanel()
        {
            panelMain.Visible = false;
            panelCreateGoal.Visible = false;
            panelCategory.Visible = true;
            panelCreateCategory.Visible = false;
        }

        private void ShowCreateCategoryPanel()
        {
            panelMain.Visible = false;
            panelCreateGoal.Visible = false;
            panelCategory.Visible = false;
            panelCreateCategory.Visible = true;
        }

        private void InitializeRadioButton()
        {
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
                rbtnRepeating.Checked = true;
                isRepeatingChecked = true;
            }
        }

        private void AddCategoryPanel(string categoryName)
        {
            var categoryPanel = new Panel
            {
                Size = new System.Drawing.Size(200, 50),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = categoryName,
                BackColor = System.Drawing.Color.LightGray
            };

            var lblCategoryName = new Label
            {
                Text = categoryName,
                AutoSize = true,
                Location = new System.Drawing.Point(10, 15)
            };

            var btnDelete = new Button
            {
                Text = "−",
                Size = new System.Drawing.Size(20, 20),
                Location = new System.Drawing.Point(170, 5),
                Visible = false,
                BackColor = System.Drawing.Color.Red,
                ForeColor = System.Drawing.Color.White
            };
            btnDelete.Click += (s, e) => DeleteCategoryPanel(categoryPanel);

            categoryPanel.Controls.Add(lblCategoryName);
            categoryPanel.Controls.Add(btnDelete);
            categoryPanel.MouseEnter += (s, e) => btnDelete.Visible = true;
            categoryPanel.MouseLeave += (s, e) => btnDelete.Visible = false;

            flowLayoutPanelCategories.Controls.Add(categoryPanel);
        }

        private void DeleteCategoryPanel(Panel categoryPanel)
        {
            flowLayoutPanelCategories.Controls.Remove(categoryPanel);
            categoryPanel.Dispose();
        }
    }
}
