namespace LifeGoals
{
    partial class MainWindowForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCreateGoal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpGoals;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.Button btnCreateGoal;
        private System.Windows.Forms.Button btnToday306090;
        private System.Windows.Forms.Button btnCategory;
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpGoals = new System.Windows.Forms.GroupBox();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.btnCreateGoal = new System.Windows.Forms.Button();
            this.btnToday306090 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panelCreateGoal = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rbtnRepeating = new System.Windows.Forms.RadioButton();
            this.lblLength = new System.Windows.Forms.Label();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.grpGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            this.panelCreateGoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblDate);
            this.panelMain.Controls.Add(this.lblTime);
            this.panelMain.Controls.Add(this.grpGoals);
            this.panelMain.Controls.Add(this.btnCreateGoal);
            this.panelMain.Controls.Add(this.btnToday306090);
            this.panelMain.Controls.Add(this.btnCategory);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 488);
            this.panelMain.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(212, 37);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Month Day, Year";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(12, 63);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(254, 37);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "HH:MM:SS | AM-PM";
            // 
            // grpGoals
            // 
            this.grpGoals.Controls.Add(this.dgvGoals);
            this.grpGoals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpGoals.Location = new System.Drawing.Point(12, 120);
            this.grpGoals.Name = "grpGoals";
            this.grpGoals.Size = new System.Drawing.Size(776, 250);
            this.grpGoals.TabIndex = 2;
            this.grpGoals.TabStop = false;
            this.grpGoals.Text = "Today\'s Goals";
            // 
            // dgvGoals
            // 
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoals.Location = new System.Drawing.Point(6, 30);
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.RowHeadersWidth = 62;
            this.dgvGoals.RowTemplate.Height = 33;
            this.dgvGoals.Size = new System.Drawing.Size(764, 214);
            this.dgvGoals.TabIndex = 0;
            // 
            // btnCreateGoal
            // 
            this.btnCreateGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateGoal.Location = new System.Drawing.Point(12, 376);
            this.btnCreateGoal.Name = "btnCreateGoal";
            this.btnCreateGoal.Size = new System.Drawing.Size(250, 100);
            this.btnCreateGoal.TabIndex = 3;
            this.btnCreateGoal.Text = "Create Goal";
            this.btnCreateGoal.UseVisualStyleBackColor = true;
            this.btnCreateGoal.Click += new System.EventHandler(this.btnCreateGoal_Click);
            // 
            // btnToday306090
            // 
            this.btnToday306090.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToday306090.Location = new System.Drawing.Point(268, 376);
            this.btnToday306090.Name = "btnToday306090";
            this.btnToday306090.Size = new System.Drawing.Size(250, 100);
            this.btnToday306090.TabIndex = 4;
            this.btnToday306090.Text = "Today-30-60-90";
            this.btnToday306090.UseVisualStyleBackColor = true;
            this.btnToday306090.Click += new System.EventHandler(this.btnToday306090_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCategory.Location = new System.Drawing.Point(524, 376);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(250, 100);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panelCreateGoal
            // 
            this.panelCreateGoal.Controls.Add(this.lblTitle);
            this.panelCreateGoal.Controls.Add(this.txtTitle);
            this.panelCreateGoal.Controls.Add(this.lblDescription);
            this.panelCreateGoal.Controls.Add(this.txtDescription);
            this.panelCreateGoal.Controls.Add(this.rbtnRepeating);
            this.panelCreateGoal.Controls.Add(this.lblLength);
            this.panelCreateGoal.Controls.Add(this.cmbLength);
            this.panelCreateGoal.Controls.Add(this.lblCategory);
            this.panelCreateGoal.Controls.Add(this.cmbCategory);
            this.panelCreateGoal.Controls.Add(this.btnSave);
            this.panelCreateGoal.Controls.Add(this.btnBack);
            this.panelCreateGoal.Location = new System.Drawing.Point(0, 494);
            this.panelCreateGoal.Name = "panelCreateGoal";
            this.panelCreateGoal.Size = new System.Drawing.Size(800, 488);
            this.panelCreateGoal.TabIndex = 6;
            this.panelCreateGoal.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 75);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(760, 31);
            this.txtTitle.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 155);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(760, 150);
            this.txtDescription.TabIndex = 3;
            // 
            // rbtnRepeating
            // 
            this.rbtnRepeating.AutoSize = true;
            this.rbtnRepeating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnRepeating.Location = new System.Drawing.Point(620, 20);
            this.rbtnRepeating.Name = "rbtnRepeating";
            this.rbtnRepeating.Size = new System.Drawing.Size(88, 23);
            this.rbtnRepeating.TabIndex = 4;
            this.rbtnRepeating.TabStop = true;
            this.rbtnRepeating.Text = "Repeating";
            this.rbtnRepeating.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLength.Location = new System.Drawing.Point(12, 320);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(58, 21);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
            // 
            // cmbLength
            // 
            this.cmbLength.FormattingEnabled = true;
            this.cmbLength.Items.AddRange(new object[] {
            "1 Day",
            "30 Days"});
            this.cmbLength.Location = new System.Drawing.Point(12, 355);
            this.cmbLength.Name = "cmbLength";
            this.cmbLength.Size = new System.Drawing.Size(121, 33);
            this.cmbLength.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(150, 320);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 21);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(150, 355);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 33);
            this.cmbCategory.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(550, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(680, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 50);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 487);
            this.Controls.Add(this.panelCreateGoal);
            this.Controls.Add(this.panelMain);
            this.Name = "MainWindowForm";
            this.Text = "Life Goal Organizer";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.grpGoals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.panelCreateGoal.ResumeLayout(false);
            this.panelCreateGoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
