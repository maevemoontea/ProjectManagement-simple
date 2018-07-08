namespace PMAppGUI
{
    partial class ProjectCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headingCreateProject = new System.Windows.Forms.Label();
            this.TextBoxProjName = new System.Windows.Forms.TextBox();
            this.labelSetProjName = new System.Windows.Forms.Label();
            this.buttonCreateProj = new System.Windows.Forms.Button();
            this.TextBoxProjDescr = new System.Windows.Forms.TextBox();
            this.labelSetProjDescr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFinishProject = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // headingCreateProject
            // 
            this.headingCreateProject.AutoSize = true;
            this.headingCreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCreateProject.Location = new System.Drawing.Point(13, 13);
            this.headingCreateProject.Name = "headingCreateProject";
            this.headingCreateProject.Size = new System.Drawing.Size(122, 24);
            this.headingCreateProject.TabIndex = 0;
            this.headingCreateProject.Text = "New project";
            // 
            // TextBoxProjName
            // 
            this.TextBoxProjName.Location = new System.Drawing.Point(116, 59);
            this.TextBoxProjName.Name = "TextBoxProjName";
            this.TextBoxProjName.Size = new System.Drawing.Size(227, 20);
            this.TextBoxProjName.TabIndex = 1;
            // 
            // labelSetProjName
            // 
            this.labelSetProjName.AutoSize = true;
            this.labelSetProjName.Location = new System.Drawing.Point(14, 62);
            this.labelSetProjName.Name = "labelSetProjName";
            this.labelSetProjName.Size = new System.Drawing.Size(74, 13);
            this.labelSetProjName.TabIndex = 2;
            this.labelSetProjName.Text = "Project Name:";
            // 
            // buttonCreateProj
            // 
            this.buttonCreateProj.Location = new System.Drawing.Point(96, 423);
            this.buttonCreateProj.Name = "buttonCreateProj";
            this.buttonCreateProj.Size = new System.Drawing.Size(175, 37);
            this.buttonCreateProj.TabIndex = 3;
            this.buttonCreateProj.Text = "Create";
            this.buttonCreateProj.UseVisualStyleBackColor = true;
            this.buttonCreateProj.Click += new System.EventHandler(this.ButtonCreateProj_Click);
            // 
            // TextBoxProjDescr
            // 
            this.TextBoxProjDescr.Location = new System.Drawing.Point(116, 94);
            this.TextBoxProjDescr.Multiline = true;
            this.TextBoxProjDescr.Name = "TextBoxProjDescr";
            this.TextBoxProjDescr.Size = new System.Drawing.Size(227, 91);
            this.TextBoxProjDescr.TabIndex = 1;
            // 
            // labelSetProjDescr
            // 
            this.labelSetProjDescr.AutoSize = true;
            this.labelSetProjDescr.Location = new System.Drawing.Point(14, 97);
            this.labelSetProjDescr.Name = "labelSetProjDescr";
            this.labelSetProjDescr.Size = new System.Drawing.Size(74, 13);
            this.labelSetProjDescr.TabIndex = 2;
            this.labelSetProjDescr.Text = "Project Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expire date:";
            // 
            // dateTimePickerFinishProject
            // 
            this.dateTimePickerFinishProject.Location = new System.Drawing.Point(116, 200);
            this.dateTimePickerFinishProject.Name = "dateTimePickerFinishProject";
            this.dateTimePickerFinishProject.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinishProject.TabIndex = 6;
            // 
            // ProjectCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 482);
            this.Controls.Add(this.dateTimePickerFinishProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateProj);
            this.Controls.Add(this.labelSetProjDescr);
            this.Controls.Add(this.labelSetProjName);
            this.Controls.Add(this.TextBoxProjDescr);
            this.Controls.Add(this.TextBoxProjName);
            this.Controls.Add(this.headingCreateProject);
            this.Name = "ProjectCreateForm";
            this.Text = "New project";
            this.Load += new System.EventHandler(this.ProjectCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingCreateProject;
        private System.Windows.Forms.TextBox TextBoxProjName;
        private System.Windows.Forms.Label labelSetProjName;
        private System.Windows.Forms.Button buttonCreateProj;
        private System.Windows.Forms.TextBox TextBoxProjDescr;
        private System.Windows.Forms.Label labelSetProjDescr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishProject;
    }
}
