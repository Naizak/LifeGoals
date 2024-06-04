namespace LifeGoals
{
    partial class MainWindowForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCreateGoal;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelCreateCategory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Label lblCategoryList;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpGoals;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.Button btnCreateGoal;
        private System.Windows.Forms.Button btnToday306090;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnBackFromCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnBackFromCreateCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton rbtnRepeating;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblColorPicker;
        private System.Windows.Forms.Panel panelColorPicker;
        private System.Windows.Forms.Label lblRelevantGoals;
        private System.Windows.Forms.ListBox lstRelevantGoals;
        private System.Windows.Forms.Button btnDeleteCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            InitializeMainPanel();
            InitializeCreateGoalPanel();
            InitializeCategoryPanel();
            InitializeCreateCategoryPanel();
            this.Text = "Life Goal Organizer";
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelCreateGoal);
            this.Controls.Add(panelCategory);
            this.Controls.Add(panelCreateCategory);
        }

        private void InitializeMainPanel()
        {
            panelMain = new System.Windows.Forms.Panel();
            lblDate = new System.Windows.Forms.Label();
            lblTime = new System.Windows.Forms.Label();
            grpGoals = new System.Windows.Forms.GroupBox();
            dgvGoals = new System.Windows.Forms.DataGridView();
            btnCreateGoal = new System.Windows.Forms.Button();
            btnToday306090 = new System.Windows.Forms.Button();
            btnCategory = new System.Windows.Forms.Button();

            panelMain.Controls.Add(lblDate);
            panelMain.Controls.Add(lblTime);
            panelMain.Controls.Add(grpGoals);
            panelMain.Controls.Add(btnCreateGoal);
            panelMain.Controls.Add(btnToday306090);
            panelMain.Controls.Add(btnCategory);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(800, 488);
            panelMain.TabIndex = 0;

            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDate.Location = new System.Drawing.Point(12, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(393, 54);
            lblDate.TabIndex = 0;
            lblDate.Text = "Month Day, Year";

            lblTime.AutoSize = true;
            lblTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTime.Location = new System.Drawing.Point(12, 63);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(297, 54);
            lblTime.TabIndex = 1;
            lblTime.Text = "HH:MM:SS | AM-PM";

            grpGoals.Controls.Add(dgvGoals);
            grpGoals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grpGoals.Location = new System.Drawing.Point(12, 120);
            grpGoals.Name = "grpGoals";
            grpGoals.Size = new System.Drawing.Size(776, 250);
            grpGoals.TabIndex = 2;
            grpGoals.TabStop = false;
            grpGoals.Text = "Today's Goals";

            dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoals.Location = new System.Drawing.Point(6, 30);
            dgvGoals.Name = "dgvGoals";
            dgvGoals.RowHeadersWidth = 62;
            dgvGoals.RowTemplate.Height = 33;
            dgvGoals.Size = new System.Drawing.Size(764, 214);
            dgvGoals.TabIndex = 0;

            btnCreateGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCreateGoal.Location = new System.Drawing.Point(12, 376);
            btnCreateGoal.Name = "btnCreateGoal";
            btnCreateGoal.Size = new System.Drawing.Size(250, 100);
            btnCreateGoal.TabIndex = 3;
            btnCreateGoal.Text = "Create Goal";
            btnCreateGoal.UseVisualStyleBackColor = true;
            btnCreateGoal.Click += new System.EventHandler(this.btnCreateGoal_Click);

            btnToday306090.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnToday306090.Location = new System.Drawing.Point(268, 376);
            btnToday306090.Name = "btnToday306090";
            btnToday306090.Size = new System.Drawing.Size(250, 100);
            btnToday306090.TabIndex = 4;
            btnToday306090.Text = "Today-30-60-90";
            btnToday306090.UseVisualStyleBackColor = true;
            btnToday306090.Click += new System.EventHandler(this.btnToday306090_Click);

            btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCategory.Location = new System.Drawing.Point(524, 376);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new System.Drawing.Size(250, 100);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
        }

        private void InitializeCreateGoalPanel()
        {
            panelCreateGoal = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            rbtnRepeating = new System.Windows.Forms.RadioButton();
            lblLength = new System.Windows.Forms.Label();
            cmbLength = new System.Windows.Forms.ComboBox();
            lblCategory = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();

            panelCreateGoal.Controls.Add(lblTitle);
            panelCreateGoal.Controls.Add(txtTitle);
            panelCreateGoal.Controls.Add(lblDescription);
            panelCreateGoal.Controls.Add(txtDescription);
            panelCreateGoal.Controls.Add(rbtnRepeating);
            panelCreateGoal.Controls.Add(lblLength);
            panelCreateGoal.Controls.Add(cmbLength);
            panelCreateGoal.Controls.Add(lblCategory);
            panelCreateGoal.Controls.Add(cmbCategory);
            panelCreateGoal.Controls.Add(btnSave);
            panelCreateGoal.Controls.Add(btnBack);
            panelCreateGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCreateGoal.Location = new System.Drawing.Point(0, 0);
            panelCreateGoal.Name = "panelCreateGoal";
            panelCreateGoal.Size = new System.Drawing.Size(800, 488);
            panelCreateGoal.TabIndex = 6;
            panelCreateGoal.Visible = false;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(12, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(66, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";

            txtTitle.Location = new System.Drawing.Point(12, 75);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(760, 31);
            txtTitle.TabIndex = 1;

            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDescription.Location = new System.Drawing.Point(12, 120);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(142, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";

            txtDescription.Location = new System.Drawing.Point(12, 155);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(760, 150);
            txtDescription.TabIndex = 3;

            rbtnRepeating.AutoSize = true;
            rbtnRepeating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rbtnRepeating.Location = new System.Drawing.Point(620, 20);
            rbtnRepeating.Name = "rbtnRepeating";
            rbtnRepeating.Size = new System.Drawing.Size(130, 32);
            rbtnRepeating.TabIndex = 4;
            rbtnRepeating.TabStop = true;
            rbtnRepeating.Text = "Repeating";
            rbtnRepeating.UseVisualStyleBackColor = true;

            lblLength.AutoSize = true;
            lblLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLength.Location = new System.Drawing.Point(12, 320);
            lblLength.Name = "lblLength";
            lblLength.Size = new System.Drawing.Size(88, 32);
            lblLength.TabIndex = 5;
            lblLength.Text = "Length";

            cmbLength.FormattingEnabled = true;
            cmbLength.Items.AddRange(new object[] { "1 Day", "30 Days" });
            cmbLength.Location = new System.Drawing.Point(12, 355);
            cmbLength.Name = "cmbLength";
            cmbLength.Size = new System.Drawing.Size(121, 33);
            cmbLength.TabIndex = 6;

            lblCategory.AutoSize = true;
            lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategory.Location = new System.Drawing.Point(150, 320);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(112, 32);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";

            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(150, 355);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(121, 33);
            cmbCategory.TabIndex = 9;

            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSave.Location = new System.Drawing.Point(550, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(110, 50);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);

            btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(680, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(110, 50);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
        }

        private void InitializeCategoryPanel()
        {
            panelCategory = new System.Windows.Forms.Panel();
            flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            btnAddCategory = new System.Windows.Forms.Button();
            lblCategoryList = new System.Windows.Forms.Label();
            btnBackFromCategory = new System.Windows.Forms.Button();

            panelCategory.Controls.Add(flowLayoutPanelCategories);
            panelCategory.Controls.Add(btnAddCategory);
            panelCategory.Controls.Add(lblCategoryList);
            panelCategory.Controls.Add(btnBackFromCategory);
            panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCategory.Location = new System.Drawing.Point(0, 0);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new System.Drawing.Size(800, 488);
            panelCategory.TabIndex = 7;
            panelCategory.Visible = false;

            flowLayoutPanelCategories.AutoScroll = true;
            flowLayoutPanelCategories.Location = new System.Drawing.Point(12, 50);
            flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            flowLayoutPanelCategories.Size = new System.Drawing.Size(776, 362);
            flowLayoutPanelCategories.TabIndex = 1;

            btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddCategory.Location = new System.Drawing.Point(12, 418);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new System.Drawing.Size(250, 50);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Create Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);

            lblCategoryList.AutoSize = true;
            lblCategoryList.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategoryList.Location = new System.Drawing.Point(300, 9);
            lblCategoryList.Name = "lblCategoryList";
            lblCategoryList.Size = new System.Drawing.Size(241, 45);
            lblCategoryList.TabIndex = 2;
            lblCategoryList.Text = "List of Categories:";
            lblCategoryList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            btnBackFromCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBackFromCategory.Location = new System.Drawing.Point(670, 418);
            btnBackFromCategory.Name = "btnBackFromCategory";
            btnBackFromCategory.Size = new System.Drawing.Size(118, 50);
            btnBackFromCategory.TabIndex = 3;
            btnBackFromCategory.Text = "Back";
            btnBackFromCategory.UseVisualStyleBackColor = true;
            btnBackFromCategory.Click += new System.EventHandler(this.btnBackFromCategory_Click);
        }

        private void InitializeCreateCategoryPanel()
        {
            panelCreateCategory = new System.Windows.Forms.Panel();
            lblCategoryName = new System.Windows.Forms.Label();
            txtCategoryName = new System.Windows.Forms.TextBox();
            lblColorPicker = new System.Windows.Forms.Label();
            panelColorPicker = new System.Windows.Forms.Panel();
            lblRelevantGoals = new System.Windows.Forms.Label();
            lstRelevantGoals = new System.Windows.Forms.ListBox();
            btnSaveCategory = new System.Windows.Forms.Button();
            btnBackFromCreateCategory = new System.Windows.Forms.Button();
            btnDeleteCategory = new System.Windows.Forms.Button();

            panelCreateCategory.Controls.Add(lblCategoryName);
            panelCreateCategory.Controls.Add(txtCategoryName);
            panelCreateCategory.Controls.Add(lblColorPicker);
            panelCreateCategory.Controls.Add(panelColorPicker);
            panelCreateCategory.Controls.Add(lblRelevantGoals);
            panelCreateCategory.Controls.Add(lstRelevantGoals);
            panelCreateCategory.Controls.Add(btnSaveCategory);
            panelCreateCategory.Controls.Add(btnBackFromCreateCategory);
            panelCreateCategory.Controls.Add(btnDeleteCategory);
            panelCreateCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCreateCategory.Location = new System.Drawing.Point(0, 0);
            panelCreateCategory.Name = "panelCreateCategory";
            panelCreateCategory.Size = new System.Drawing.Size(800, 488);
            panelCreateCategory.TabIndex = 8;
            panelCreateCategory.Visible = false;

            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategoryName.Location = new System.Drawing.Point(12, 40);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new System.Drawing.Size(177, 32);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category Name";

            txtCategoryName.Location = new System.Drawing.Point(12, 75);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new System.Drawing.Size(760, 31);
            txtCategoryName.TabIndex = 1;

            lblColorPicker.AutoSize = true;
            lblColorPicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblColorPicker.Location = new System.Drawing.Point(12, 120);
            lblColorPicker.Name = "lblColorPicker";
            lblColorPicker.Size = new System.Drawing.Size(138, 32);
            lblColorPicker.TabIndex = 2;
            lblColorPicker.Text = "Color Picker";

            panelColorPicker.BackColor = System.Drawing.Color.White;
            panelColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelColorPicker.Location = new System.Drawing.Point(12, 155);
            panelColorPicker.Name = "panelColorPicker";
            panelColorPicker.Size = new System.Drawing.Size(200, 200);
            panelColorPicker.TabIndex = 3;

            lblRelevantGoals.AutoSize = true;
            lblRelevantGoals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRelevantGoals.Location = new System.Drawing.Point(300, 120);
            lblRelevantGoals.Name = "lblRelevantGoals";
            lblRelevantGoals.Size = new System.Drawing.Size(173, 32);
            lblRelevantGoals.TabIndex = 4;
            lblRelevantGoals.Text = "Relevant Goals";

            lstRelevantGoals.FormattingEnabled = true;
            lstRelevantGoals.ItemHeight = 25;
            lstRelevantGoals.Location = new System.Drawing.Point(300, 155);
            lstRelevantGoals.Name = "lstRelevantGoals";
            lstRelevantGoals.Size = new System.Drawing.Size(200, 204);
            lstRelevantGoals.TabIndex = 5;

            btnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSaveCategory.Location = new System.Drawing.Point(550, 400);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new System.Drawing.Size(110, 50);
            btnSaveCategory.TabIndex = 6;
            btnSaveCategory.Text = "Save";
            btnSaveCategory.UseVisualStyleBackColor = true;
            btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);

            btnBackFromCreateCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBackFromCreateCategory.Location = new System.Drawing.Point(680, 400);
            btnBackFromCreateCategory.Name = "btnBackFromCreateCategory";
            btnBackFromCreateCategory.Size = new System.Drawing.Size(110, 50);
            btnBackFromCreateCategory.TabIndex = 7;
            btnBackFromCreateCategory.Text = "Back";
            btnBackFromCreateCategory.UseVisualStyleBackColor = true;
            btnBackFromCreateCategory.Click += new System.EventHandler(this.btnBackFromCreateCategory_Click);

            btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeleteCategory.Location = new System.Drawing.Point(12, 400);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new System.Drawing.Size(110, 50);
            btnDeleteCategory.TabIndex = 8;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
        }

        #endregion
    }
}
