namespace PMAppGUI
{
    partial class MainWindow
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
            this.mainHeading = new System.Windows.Forms.Label();
            this.buttonCreateProject = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonAddResource = new System.Windows.Forms.Button();
            this.buttonManageStatuses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(24, 49);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(273, 24);
            this.mainHeading.TabIndex = 0;
            this.mainHeading.Text = "Create and manage projects";
            // 
            // buttonCreateProject
            // 
            this.buttonCreateProject.Location = new System.Drawing.Point(28, 150);
            this.buttonCreateProject.Name = "buttonCreateProject";
            this.buttonCreateProject.Size = new System.Drawing.Size(269, 39);
            this.buttonCreateProject.TabIndex = 1;
            this.buttonCreateProject.Text = "New project";
            this.buttonCreateProject.UseVisualStyleBackColor = true;
            this.buttonCreateProject.Click += new System.EventHandler(this.ButtonCreateProject_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(28, 206);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(269, 39);
            this.buttonAddTask.TabIndex = 1;
            this.buttonAddTask.Text = "New task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // buttonAddResource
            // 
            this.buttonAddResource.Location = new System.Drawing.Point(423, 150);
            this.buttonAddResource.Name = "buttonAddResource";
            this.buttonAddResource.Size = new System.Drawing.Size(192, 39);
            this.buttonAddResource.TabIndex = 1;
            this.buttonAddResource.Text = "New worker";
            this.buttonAddResource.UseVisualStyleBackColor = true;
            this.buttonAddResource.Click += new System.EventHandler(this.ButtonAddResource_Click);
            // 
            // buttonManageStatuses
            // 
            this.buttonManageStatuses.Location = new System.Drawing.Point(423, 379);
            this.buttonManageStatuses.Name = "buttonManageStatuses";
            this.buttonManageStatuses.Size = new System.Drawing.Size(192, 39);
            this.buttonManageStatuses.TabIndex = 1;
            this.buttonManageStatuses.Text = "New status";
            this.buttonManageStatuses.UseVisualStyleBackColor = true;
            this.buttonManageStatuses.Click += new System.EventHandler(this.ButtonManageStatuses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resources management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Settings";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonManageStatuses);
            this.Controls.Add(this.buttonAddResource);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.buttonCreateProject);
            this.Controls.Add(this.mainHeading);
            this.Name = "MainWindow";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Button buttonCreateProject;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonAddResource;
        private System.Windows.Forms.Button buttonManageStatuses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}