namespace LifeGoals
{
    partial class MainWindowForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpGoals;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.Button btnCreateGoal;
        private System.Windows.Forms.Button btnToday306090;
        private System.Windows.Forms.Button btnCategory;

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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpGoals = new System.Windows.Forms.GroupBox();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.btnCreateGoal = new System.Windows.Forms.Button();
            this.btnToday306090 = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.grpGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(393, 54);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Month Day, Year";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(12, 63);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(297, 54);
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
            this.grpGoals.Text = "Today's Goals";
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
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnToday306090);
            this.Controls.Add(this.btnCreateGoal);
            this.Controls.Add(this.grpGoals);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Name = "MainWindowForm";
            this.Text = "Life Goal Organizer";
            this.grpGoals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
