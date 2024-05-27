namespace LifeGoals
{
    partial class CreateGoalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton rbtnRepeating;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lstCategory;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rbtnRepeating = new System.Windows.Forms.RadioButton();
            this.lblLength = new System.Windows.Forms.Label();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 32);
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
            this.lblDescription.Size = new System.Drawing.Size(142, 32);
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
            this.rbtnRepeating.Size = new System.Drawing.Size(130, 32);
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
            this.lblLength.Size = new System.Drawing.Size(88, 32);
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
            this.lblCategory.Size = new System.Drawing.Size(112, 32);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
                "Finance",
                "Physical" });
            this.cmbCategory.Location = new System.Drawing.Point(150, 355);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 33);
            this.cmbCategory.TabIndex = 9;
            // 
            // lstCategory
            // 
            //this.lstCategory.FormattingEnabled = true;
            //this.lstCategory.ItemHeight = 25;
            //this.lstCategory.Items.AddRange(new object[] {
            //"Finance",
            //"Physical"});
            //this.lstCategory.Location = new System.Drawing.Point(150, 394);
            //this.lstCategory.Name = "lstCategory";
            //this.lstCategory.Size = new System.Drawing.Size(121, 79);
            //this.lstCategory.TabIndex = 10;
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
            // CreateGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.rbtnRepeating);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "CreateGoalForm";
            this.Text = "Life Goal Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
